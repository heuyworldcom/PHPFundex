namespace PHPFundex
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.fileDial = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartingFolder = new System.Windows.Forms.Label();
            this.btnStartIndexing = new System.Windows.Forms.Button();
            this.tb_right = new System.Windows.Forms.TextBox();
            this.pbIndexing = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDBSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(24, 84);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(108, 23);
            this.btnOpenFolder.TabIndex = 0;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // fileDial
            // 
            this.fileDial.Filter = "PHP files|*.php";
            this.fileDial.SupportMultiDottedExtensions = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select any .php file to select a starting folder.";
            // 
            // lblStartingFolder
            // 
            this.lblStartingFolder.AutoSize = true;
            this.lblStartingFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingFolder.Location = new System.Drawing.Point(23, 110);
            this.lblStartingFolder.Name = "lblStartingFolder";
            this.lblStartingFolder.Size = new System.Drawing.Size(93, 15);
            this.lblStartingFolder.TabIndex = 2;
            this.lblStartingFolder.Text = "Starting Folder: ";
            // 
            // btnStartIndexing
            // 
            this.btnStartIndexing.Enabled = false;
            this.btnStartIndexing.Location = new System.Drawing.Point(24, 148);
            this.btnStartIndexing.Name = "btnStartIndexing";
            this.btnStartIndexing.Size = new System.Drawing.Size(108, 23);
            this.btnStartIndexing.TabIndex = 3;
            this.btnStartIndexing.Text = "Start Indexing";
            this.btnStartIndexing.UseVisualStyleBackColor = true;
            this.btnStartIndexing.Click += new System.EventHandler(this.btnStartIndexing_Click);
            // 
            // tb_right
            // 
            this.tb_right.Location = new System.Drawing.Point(267, 12);
            this.tb_right.Multiline = true;
            this.tb_right.Name = "tb_right";
            this.tb_right.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_right.Size = new System.Drawing.Size(574, 531);
            this.tb_right.TabIndex = 4;
            // 
            // pbIndexing
            // 
            this.pbIndexing.Location = new System.Drawing.Point(24, 196);
            this.pbIndexing.Name = "pbIndexing";
            this.pbIndexing.Size = new System.Drawing.Size(215, 23);
            this.pbIndexing.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.getDBSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // getDBSQLToolStripMenuItem
            // 
            this.getDBSQLToolStripMenuItem.Name = "getDBSQLToolStripMenuItem";
            this.getDBSQLToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.getDBSQLToolStripMenuItem.Text = "Get DB SQL";
            this.getDBSQLToolStripMenuItem.Click += new System.EventHandler(this.getDBSQLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 555);
            this.Controls.Add(this.pbIndexing);
            this.Controls.Add(this.tb_right);
            this.Controls.Add(this.btnStartIndexing);
            this.Controls.Add(this.lblStartingFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHP FunDex - Function Indexer - by Kevin J Brosnahan (www.LateNiteWare.com)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.OpenFileDialog fileDial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartingFolder;
        private System.Windows.Forms.Button btnStartIndexing;
        private System.Windows.Forms.TextBox tb_right;
        private System.Windows.Forms.ProgressBar pbIndexing;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDBSQLToolStripMenuItem;
    }
}

