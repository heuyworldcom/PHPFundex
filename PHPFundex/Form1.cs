using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PHPFundex
{
    public partial class Form1 : Form
    {
        public string sFolderName;
        public bool FolderIsSet;
        public DirectoryInfo diFolderName;

        public Form1()
        {
            InitializeComponent();
            FolderIsSet = false;
        }

        
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            
            fileDial.ShowDialog();
            string sFolder = fileDial.FileName;
            if (sFolder.Length > 0) {
                Tools t = new Tools();
                sFolder = t.ReverseString(sFolder);
                sFolderName = sFolder;
                FolderIsSet = true;
                lblStartingFolder.Text = "Starting Folder: " + sFolder;
                t.Dispose();
                btnStartIndexing.Enabled = true;
            }
        }

        private void btnStartIndexing_Click(object sender, EventArgs e)
        {
            
            diFolderName = new DirectoryInfo(sFolderName);
            Tools t = new Tools();
            StringBuilder al = new StringBuilder();
            al = t.WalkDirectoryTree(diFolderName);
            tb_right.Text = al.ToString();
            t.Dispose();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void getDBSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql += "-- phpMyAdmin SQL Dump" + Environment.NewLine;
            sql += "-- version 4.9.2" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- Host: 127.0.0.1" + Environment.NewLine;
            sql += "-- Server version: 10.4.11-MariaDB" + Environment.NewLine;
            sql += "-- PHP Version: 7.3.11" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "SET SQL_MODE = \"NO_AUTO_VALUE_ON_ZERO\";" + Environment.NewLine;
            sql += "SET AUTOCOMMIT = 0;" + Environment.NewLine;
            sql += "START TRANSACTION;" + Environment.NewLine;
            sql += "SET time_zone = \"+00:00\";" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- Database: `fundexdb`" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "-- --------------------------------------------------------" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- Table structure for table `fundexes`" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "DROP TABLE IF EXISTS `fundexes`;" + Environment.NewLine;
            sql += "CREATE TABLE `fundexes` (" + Environment.NewLine;
            sql += "  `ID` int(11) NOT NULL," + Environment.NewLine;
            sql += "  `file_path` varchar(255) NOT NULL," + Environment.NewLine;
            sql += "  `func_name` varchar(50) NOT NULL," + Environment.NewLine;
            sql += "  `func_type` varchar(10) DEFAULT ''," + Environment.NewLine;
            sql += "  `func_params` varchar(255) DEFAULT ''," + Environment.NewLine;
            sql += "  `line_num` mediumint(9) NOT NULL DEFAULT 0" + Environment.NewLine;
            sql += ") ENGINE=InnoDB DEFAULT CHARSET=latin1;" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- Indexes for dumped tables" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- Indexes for table `fundexes`" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "ALTER TABLE `fundexes`" + Environment.NewLine;
            sql += "  ADD PRIMARY KEY (`ID`);" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- AUTO_INCREMENT for dumped tables" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "-- AUTO_INCREMENT for table `fundexes`" + Environment.NewLine;
            sql += "--" + Environment.NewLine;
            sql += "ALTER TABLE `fundexes`" + Environment.NewLine;
            sql += "  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;" + Environment.NewLine;
            sql += "COMMIT;" + Environment.NewLine;

            tb_right.Text = sql;
        }
    }
}
