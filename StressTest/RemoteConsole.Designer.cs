namespace StressTest
{
    partial class RemoteForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_Captured = new System.Windows.Forms.PictureBox();
            this.button_SendCmd = new System.Windows.Forms.Button();
            this.textBox_CaptureQuality = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_File_Refresh = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_File_Root = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.treeView_RemoteFiles = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_fileTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.下载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip_fileTree.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "捕捉屏幕";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_CaptureClick);
            // 
            // pictureBox_Captured
            // 
            this.pictureBox_Captured.Location = new System.Drawing.Point(3, 1);
            this.pictureBox_Captured.Name = "pictureBox_Captured";
            this.pictureBox_Captured.Size = new System.Drawing.Size(284, 193);
            this.pictureBox_Captured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Captured.TabIndex = 10;
            this.pictureBox_Captured.TabStop = false;
            this.pictureBox_Captured.Click += new System.EventHandler(this.pictureBox_Captured_Click);
            this.pictureBox_Captured.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Captured_MouseClick);
            this.pictureBox_Captured.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Captured_MouseDoubleClick);
            // 
            // button_SendCmd
            // 
            this.button_SendCmd.Location = new System.Drawing.Point(160, 65);
            this.button_SendCmd.Name = "button_SendCmd";
            this.button_SendCmd.Size = new System.Drawing.Size(75, 23);
            this.button_SendCmd.TabIndex = 11;
            this.button_SendCmd.Text = "发送命令";
            this.button_SendCmd.UseVisualStyleBackColor = true;
            this.button_SendCmd.Click += new System.EventHandler(this.button_Click_Click);
            // 
            // textBox_CaptureQuality
            // 
            this.textBox_CaptureQuality.Location = new System.Drawing.Point(9, 20);
            this.textBox_CaptureQuality.Name = "textBox_CaptureQuality";
            this.textBox_CaptureQuality.Size = new System.Drawing.Size(100, 21);
            this.textBox_CaptureQuality.TabIndex = 12;
            this.textBox_CaptureQuality.Text = "100";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_Captured);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 729);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.treeView_RemoteFiles);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 506);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件管理";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_File_Refresh,
            this.toolStrip_File_Root,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(236, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_File_Refresh
            // 
            this.toolStrip_File_Refresh.Name = "toolStrip_File_Refresh";
            this.toolStrip_File_Refresh.Size = new System.Drawing.Size(32, 22);
            this.toolStrip_File_Refresh.Text = "刷新";
            this.toolStrip_File_Refresh.Click += new System.EventHandler(this.toolStrip_File_Refresh_Click);
            // 
            // toolStrip_File_Root
            // 
            this.toolStrip_File_Root.Name = "toolStrip_File_Root";
            this.toolStrip_File_Root.Size = new System.Drawing.Size(56, 22);
            this.toolStrip_File_Root.Text = "返回顶层";
            this.toolStrip_File_Root.Click += new System.EventHandler(this.toolStrip_File_Root_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "向上一级";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // treeView_RemoteFiles
            // 
            this.treeView_RemoteFiles.ContextMenuStrip = this.contextMenuStrip_fileTree;
            this.treeView_RemoteFiles.Location = new System.Drawing.Point(9, 65);
            this.treeView_RemoteFiles.Name = "treeView_RemoteFiles";
            this.treeView_RemoteFiles.Size = new System.Drawing.Size(226, 435);
            this.treeView_RemoteFiles.TabIndex = 15;
            this.treeView_RemoteFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_RemoteFiles_NodeMouseDoubleClick);
            this.treeView_RemoteFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_RemoteFiles_MouseClick);
            // 
            // contextMenuStrip_fileTree
            // 
            this.contextMenuStrip_fileTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载文件ToolStripMenuItem});
            this.contextMenuStrip_fileTree.Name = "contextMenuStrip_fileTree";
            this.contextMenuStrip_fileTree.Size = new System.Drawing.Size(125, 26);
            // 
            // 下载文件ToolStripMenuItem
            // 
            this.下载文件ToolStripMenuItem.Name = "下载文件ToolStripMenuItem";
            this.下载文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.下载文件ToolStripMenuItem.Text = "下载文件";
            this.下载文件ToolStripMenuItem.Click += new System.EventHandler(this.下载文件ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_cmd);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_SendCmd);
            this.groupBox1.Controls.Add(this.textBox_CaptureQuality);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 118);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能";
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Location = new System.Drawing.Point(6, 65);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(135, 21);
            this.textBox_cmd.TabIndex = 13;
            this.textBox_cmd.Text = "getMousePos";
            // 
            // RemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 729);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RemoteForm";
            this.Text = "Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Remote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captured)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip_fileTree.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox_Captured;
        private System.Windows.Forms.Button button_SendCmd;
        private System.Windows.Forms.TextBox textBox_CaptureQuality;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView_RemoteFiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStrip_File_Refresh;
        private System.Windows.Forms.ToolStripLabel toolStrip_File_Root;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_fileTree;
        private System.Windows.Forms.ToolStripMenuItem 下载文件ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}