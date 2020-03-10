namespace JSON2CSV
{
    partial class J2C_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(J2C_Form));
            this.J2C_TabControl = new System.Windows.Forms.TabControl();
            this.J2C_TabPage1 = new System.Windows.Forms.TabPage();
            this.J2C_TextBox_JSep = new System.Windows.Forms.TextBox();
            this.J2C_ListBox_Folder = new System.Windows.Forms.ListBox();
            this.J2C_Button_Save = new System.Windows.Forms.Button();
            this.J2C_Button_AddFolder = new System.Windows.Forms.Button();
            this.J2C_TextBox_JPath = new System.Windows.Forms.TextBox();
            this.J2C_Button_Convert = new System.Windows.Forms.Button();
            this.J2C_DataGridView = new System.Windows.Forms.DataGridView();
            this.J2C_TabPage2 = new System.Windows.Forms.TabPage();
            this.J2C_ListBox_Logs = new System.Windows.Forms.ListBox();
            this.J2C_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.J2C_AddFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.J2C_SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.J2C_AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.J2C_TabControl.SuspendLayout();
            this.J2C_TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.J2C_DataGridView)).BeginInit();
            this.J2C_TabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // J2C_TabControl
            // 
            this.J2C_TabControl.Controls.Add(this.J2C_TabPage1);
            this.J2C_TabControl.Controls.Add(this.J2C_TabPage2);
            this.J2C_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.J2C_TabControl.Location = new System.Drawing.Point(0, 24);
            this.J2C_TabControl.Name = "J2C_TabControl";
            this.J2C_TabControl.SelectedIndex = 0;
            this.J2C_TabControl.Size = new System.Drawing.Size(1119, 575);
            this.J2C_TabControl.TabIndex = 0;
            // 
            // J2C_TabPage1
            // 
            this.J2C_TabPage1.Controls.Add(this.J2C_TextBox_JSep);
            this.J2C_TabPage1.Controls.Add(this.J2C_ListBox_Folder);
            this.J2C_TabPage1.Controls.Add(this.J2C_Button_Save);
            this.J2C_TabPage1.Controls.Add(this.J2C_Button_AddFolder);
            this.J2C_TabPage1.Controls.Add(this.J2C_TextBox_JPath);
            this.J2C_TabPage1.Controls.Add(this.J2C_Button_Convert);
            this.J2C_TabPage1.Controls.Add(this.J2C_DataGridView);
            this.J2C_TabPage1.Location = new System.Drawing.Point(4, 22);
            this.J2C_TabPage1.Name = "J2C_TabPage1";
            this.J2C_TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.J2C_TabPage1.Size = new System.Drawing.Size(1111, 549);
            this.J2C_TabPage1.TabIndex = 0;
            this.J2C_TabPage1.Text = "Convert";
            this.J2C_TabPage1.UseVisualStyleBackColor = true;
            // 
            // J2C_TextBox_JSep
            // 
            this.J2C_TextBox_JSep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_TextBox_JSep.Location = new System.Drawing.Point(9, 35);
            this.J2C_TextBox_JSep.Name = "J2C_TextBox_JSep";
            this.J2C_TextBox_JSep.Size = new System.Drawing.Size(1094, 20);
            this.J2C_TextBox_JSep.TabIndex = 16;
            this.J2C_TextBox_JSep.Text = "/";
            this.J2C_ToolTip.SetToolTip(this.J2C_TextBox_JSep, "Separator");
            this.J2C_TextBox_JSep.TextChanged += new System.EventHandler(this.J2C_TextBox_JSep_TextChanged);
            // 
            // J2C_ListBox_Folder
            // 
            this.J2C_ListBox_Folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_ListBox_Folder.FormattingEnabled = true;
            this.J2C_ListBox_Folder.Location = new System.Drawing.Point(9, 61);
            this.J2C_ListBox_Folder.Name = "J2C_ListBox_Folder";
            this.J2C_ListBox_Folder.Size = new System.Drawing.Size(898, 134);
            this.J2C_ListBox_Folder.TabIndex = 15;
            this.J2C_ToolTip.SetToolTip(this.J2C_ListBox_Folder, "List of folders to convert json files from");
            // 
            // J2C_Button_Save
            // 
            this.J2C_Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_Button_Save.Enabled = false;
            this.J2C_Button_Save.Location = new System.Drawing.Point(1011, 61);
            this.J2C_Button_Save.Name = "J2C_Button_Save";
            this.J2C_Button_Save.Size = new System.Drawing.Size(92, 134);
            this.J2C_Button_Save.TabIndex = 14;
            this.J2C_Button_Save.Text = "Save";
            this.J2C_Button_Save.UseVisualStyleBackColor = true;
            this.J2C_Button_Save.EnabledChanged += new System.EventHandler(this.J2C_Button_Save_EnabledChanged);
            this.J2C_Button_Save.Click += new System.EventHandler(this.J2C_Save_Click);
            // 
            // J2C_Button_AddFolder
            // 
            this.J2C_Button_AddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_Button_AddFolder.Location = new System.Drawing.Point(913, 61);
            this.J2C_Button_AddFolder.Name = "J2C_Button_AddFolder";
            this.J2C_Button_AddFolder.Size = new System.Drawing.Size(92, 134);
            this.J2C_Button_AddFolder.TabIndex = 13;
            this.J2C_Button_AddFolder.Text = "Add Folder";
            this.J2C_Button_AddFolder.UseVisualStyleBackColor = true;
            this.J2C_Button_AddFolder.Click += new System.EventHandler(this.J2C_AddFolder_Click);
            // 
            // J2C_TextBox_JPath
            // 
            this.J2C_TextBox_JPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_TextBox_JPath.Location = new System.Drawing.Point(8, 8);
            this.J2C_TextBox_JPath.Name = "J2C_TextBox_JPath";
            this.J2C_TextBox_JPath.Size = new System.Drawing.Size(1095, 20);
            this.J2C_TextBox_JPath.TabIndex = 11;
            this.J2C_ToolTip.SetToolTip(this.J2C_TextBox_JPath, "JSON Path > $..<name>[*]");
            this.J2C_TextBox_JPath.TextChanged += new System.EventHandler(this.J2C_TextBox_JPath_TextChanged);
            // 
            // J2C_Button_Convert
            // 
            this.J2C_Button_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_Button_Convert.Location = new System.Drawing.Point(8, 201);
            this.J2C_Button_Convert.Name = "J2C_Button_Convert";
            this.J2C_Button_Convert.Size = new System.Drawing.Size(1095, 62);
            this.J2C_Button_Convert.TabIndex = 10;
            this.J2C_Button_Convert.Text = "Convert";
            this.J2C_Button_Convert.UseVisualStyleBackColor = true;
            this.J2C_Button_Convert.Click += new System.EventHandler(this.J2C_Convert_Click);
            // 
            // J2C_DataGridView
            // 
            this.J2C_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.J2C_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.J2C_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.J2C_DataGridView.Location = new System.Drawing.Point(8, 269);
            this.J2C_DataGridView.Name = "J2C_DataGridView";
            this.J2C_DataGridView.Size = new System.Drawing.Size(1095, 272);
            this.J2C_DataGridView.TabIndex = 9;
            // 
            // J2C_TabPage2
            // 
            this.J2C_TabPage2.Controls.Add(this.J2C_ListBox_Logs);
            this.J2C_TabPage2.Location = new System.Drawing.Point(4, 22);
            this.J2C_TabPage2.Name = "J2C_TabPage2";
            this.J2C_TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.J2C_TabPage2.Size = new System.Drawing.Size(1111, 549);
            this.J2C_TabPage2.TabIndex = 1;
            this.J2C_TabPage2.Text = "Logs";
            this.J2C_TabPage2.UseVisualStyleBackColor = true;
            // 
            // J2C_ListBox_Logs
            // 
            this.J2C_ListBox_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.J2C_ListBox_Logs.FormattingEnabled = true;
            this.J2C_ListBox_Logs.Location = new System.Drawing.Point(3, 3);
            this.J2C_ListBox_Logs.Name = "J2C_ListBox_Logs";
            this.J2C_ListBox_Logs.Size = new System.Drawing.Size(1105, 543);
            this.J2C_ListBox_Logs.TabIndex = 0;
            // 
            // J2C_ToolTip
            // 
            this.J2C_ToolTip.AutoPopDelay = 10000;
            this.J2C_ToolTip.InitialDelay = 500;
            this.J2C_ToolTip.IsBalloon = true;
            this.J2C_ToolTip.ReshowDelay = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.J2C_AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.J2C_AddFolderToolStripMenuItem,
            this.J2C_SaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // J2C_AddFolderToolStripMenuItem
            // 
            this.J2C_AddFolderToolStripMenuItem.Name = "J2C_AddFolderToolStripMenuItem";
            this.J2C_AddFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.J2C_AddFolderToolStripMenuItem.Text = "Add Folder";
            this.J2C_AddFolderToolStripMenuItem.Click += new System.EventHandler(this.J2C_AddFolder_Click);
            // 
            // J2C_SaveToolStripMenuItem
            // 
            this.J2C_SaveToolStripMenuItem.Enabled = false;
            this.J2C_SaveToolStripMenuItem.Name = "J2C_SaveToolStripMenuItem";
            this.J2C_SaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.J2C_SaveToolStripMenuItem.Text = "Save";
            this.J2C_SaveToolStripMenuItem.Click += new System.EventHandler(this.J2C_Save_Click);
            // 
            // J2C_AboutToolStripMenuItem
            // 
            this.J2C_AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.J2C_AboutToolStripMenuItem.Name = "J2C_AboutToolStripMenuItem";
            this.J2C_AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.J2C_AboutToolStripMenuItem.Text = "About";
            this.J2C_AboutToolStripMenuItem.Click += new System.EventHandler(this.J2C_About_Click);
            // 
            // J2C_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 599);
            this.Controls.Add(this.J2C_TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "J2C_Form";
            this.Text = "JSON2CSV";
            this.Load += new System.EventHandler(this.J2C_Form_Load);
            this.J2C_TabControl.ResumeLayout(false);
            this.J2C_TabPage1.ResumeLayout(false);
            this.J2C_TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.J2C_DataGridView)).EndInit();
            this.J2C_TabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl J2C_TabControl;
        private System.Windows.Forms.TabPage J2C_TabPage1;
        private System.Windows.Forms.ListBox J2C_ListBox_Folder;
        private System.Windows.Forms.Button J2C_Button_Save;
        private System.Windows.Forms.Button J2C_Button_AddFolder;
        private System.Windows.Forms.TextBox J2C_TextBox_JPath;
        private System.Windows.Forms.Button J2C_Button_Convert;
        private System.Windows.Forms.DataGridView J2C_DataGridView;
        private System.Windows.Forms.TabPage J2C_TabPage2;
        private System.Windows.Forms.ListBox J2C_ListBox_Logs;
        private System.Windows.Forms.TextBox J2C_TextBox_JSep;
        private System.Windows.Forms.ToolTip J2C_ToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem J2C_AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem J2C_AddFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem J2C_SaveToolStripMenuItem;
    }
}

