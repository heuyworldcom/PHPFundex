using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace PHPFundex
{
    class Tools : IDisposable
    {
        StringBuilder sbOutput = new StringBuilder();

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }        
        
        public string ReverseString( string sFolder ) {
            char[] arr = sFolder.ToCharArray();
            Array.Reverse(arr);
            sFolder = new string(arr);

            int i = sFolder.IndexOf('\\');
            sFolder = sFolder.Substring(i);

            arr = sFolder.ToCharArray();
            Array.Reverse(arr);
            sFolder = new string(arr);

            arr = null;

            return sFolder;
        }

        public StringBuilder WalkDirectoryTree(System.IO.DirectoryInfo root) //, ref ProgressBar pbIndexing)
    {
        System.IO.FileInfo[] files = null;
        System.IO.DirectoryInfo[] subDirs = null;
        ArrayList alOutput = new ArrayList();
        


        // First, process all the files directly under this folder
        try
        {
            files = root.GetFiles("*.php");
        }
        // This is thrown if even one of the files requires permissions greater
        // than the application provides.
        catch (UnauthorizedAccessException e)
        {
            // This code just writes out the message and continues to recurse.
            // You may decide to do something different here. For example, you
            // can try to elevate your privileges and access the file again.
           // log.Add(e.Message);
        }

        catch (System.IO.DirectoryNotFoundException e)
        {
           // Console.WriteLine(e.Message);
        }
        
        if (files != null)
        {
         //   pbIndexing.Maximum = files.Length;
            int FileCount = 0;

            foreach (System.IO.FileInfo fi in files)
            {
                // In this example, we only access the existing FileInfo object. If we
                // want to open, delete or modify the file, then
                // a try-catch block is required here to handle the case
                // where the file has been deleted since the call to TraverseTree().

                FileCount++;
           //     pbIndexing.Value = FileCount;

                System.IO.StreamReader file = new System.IO.StreamReader(fi.FullName);

                string line = "";
                string lline = "";
                int iPos = 0;
                int LineNum = 0;
                int iLParen = 0;
                int iRParen = 0;
                string sql = "";

                while ((line = file.ReadLine()) != null)
                {
                    LineNum++;
                    lline = line.ToLower();    
                    iPos = lline.IndexOf("unction ");
                    if (iPos > 0) {
                       FunctionInfo FuncInfo = new FunctionInfo();

                       FuncInfo.LineNum = LineNum;

                        if (lline.IndexOf("ublic") > 0) { 
                          FuncInfo.Type = "Public";
                        }
                        
                        if (lline.IndexOf("rivate") > 0) {
                            FuncInfo.Type = "Private";
                        }

                        try
                        {
                            iLParen = lline.IndexOf('(');
                            if (iLParen > 0)
                            {
                                FuncInfo.Name = line.Substring(iPos + 8, iLParen-(iPos+8));

                                iRParen = lline.IndexOf(')');

                                if (iRParen > 0) {
                                    FuncInfo.Params = line.Substring(iLParen+1, (iRParen - iLParen-1));
                                }
                            }

                            sql = "INSERT INTO `fundexes`(`file_path`, `func_name`, `func_type`, `func_params`, `line_num`) VALUES ('";
                            string fn = fi.FullName.Replace(@"\", @"\\");
                            sql += fn + "', '" + FuncInfo.Name.Trim() + "', '" + FuncInfo.Type.Trim() + "', '" + addslashes(FuncInfo.Params.Trim()) + "', '" + FuncInfo.LineNum + "');";
                            sbOutput.AppendLine(sql);
                        }
                            
                        catch (Exception e) { 
                        }

                       

                        
                    }
                }

                file.Close(); 


               // Console.WriteLine(fi.FullName);
            }

            // Now find all the subdirectories under this directory.
            subDirs = root.GetDirectories();

            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                // Resursive call for each subdirectory.
                WalkDirectoryTree(dirInfo);
            }
         }
        return sbOutput;
    }

        public struct FunctionInfo {
            public string Type;
            public string Name;
            public int LineNum;
            public string Params;
        }
        public string addslashes(string str)
        {
            string ret = "";
            foreach (char c in str)
            {
                switch (c)
                {
                    case '\'': ret += "\\\'"; break;
                    case '\"': ret += "\\\""; break;
                    case '\0': ret += "\\0"; break;
                    case '\\': ret += "\\\\"; break;
                    default: ret += c.ToString(); break;
                }
            }
            return ret;
        }
    }
}
