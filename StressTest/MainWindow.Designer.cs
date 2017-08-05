namespace StressTest
{
    partial class MainWindow
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
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_debugMode = new System.Windows.Forms.ToolStripMenuItem();
            this.showDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceLogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计数据toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多少个登录成功ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多少个尝试过登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看活动AgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改用例名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel.DefaultFloatWindowSize = new System.Drawing.Size(300, 600);
            this.dockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dockPanel.Location = new System.Drawing.Point(0, 25);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.ShowDocumentIcon = true;
            this.dockPanel.Size = new System.Drawing.Size(851, 525);
            this.dockPanel.TabIndex = 1;
            this.dockPanel.ActiveContentChanged += new System.EventHandler(this.dockPanel_ActiveContentChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.命令ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkspaceToolStripMenuItem,
            this.openWorkspaceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // newWorkspaceToolStripMenuItem
            // 
            this.newWorkspaceToolStripMenuItem.Name = "newWorkspaceToolStripMenuItem";
            this.newWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newWorkspaceToolStripMenuItem.Text = "New Workspace";
            this.newWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.newWorkspaceToolStripMenuItem_Click);
            // 
            // openWorkspaceToolStripMenuItem
            // 
            this.openWorkspaceToolStripMenuItem.Name = "openWorkspaceToolStripMenuItem";
            this.openWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openWorkspaceToolStripMenuItem.Text = "Open Workspace";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_debugMode,
            this.showDebugToolStripMenuItem,
            this.forceLogOutToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // toolStripMenuItem_debugMode
            // 
            this.toolStripMenuItem_debugMode.Name = "toolStripMenuItem_debugMode";
            this.toolStripMenuItem_debugMode.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_debugMode.Text = "DebugMode";
            this.toolStripMenuItem_debugMode.Click += new System.EventHandler(this.toolStripMenuItem_debugMode_Click);
            // 
            // showDebugToolStripMenuItem
            // 
            this.showDebugToolStripMenuItem.Checked = true;
            this.showDebugToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDebugToolStripMenuItem.Name = "showDebugToolStripMenuItem";
            this.showDebugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showDebugToolStripMenuItem.Text = "ShowDebug";
            this.showDebugToolStripMenuItem.Click += new System.EventHandler(this.showDebugToolStripMenuItem_Click);
            // 
            // forceLogOutToolStripMenuItem
            // 
            this.forceLogOutToolStripMenuItem.Name = "forceLogOutToolStripMenuItem";
            this.forceLogOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forceLogOutToolStripMenuItem.Text = "ForceLogOut";
            this.forceLogOutToolStripMenuItem.Click += new System.EventHandler(this.forceLogOutToolStripMenuItem_Click);
            // 
            // 命令ToolStripMenuItem
            // 
            this.命令ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.统计数据toolStripMenuItem,
            this.查看活动AgentToolStripMenuItem});
            this.命令ToolStripMenuItem.Name = "命令ToolStripMenuItem";
            this.命令ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.命令ToolStripMenuItem.Text = "命令";
            // 
            // 统计数据toolStripMenuItem
            // 
            this.统计数据toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.多少个登录成功ToolStripMenuItem,
            this.多少个尝试过登录ToolStripMenuItem});
            this.统计数据toolStripMenuItem.Name = "统计数据toolStripMenuItem";
            this.统计数据toolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.统计数据toolStripMenuItem.Text = "统计数据";
            // 
            // 多少个登录成功ToolStripMenuItem
            // 
            this.多少个登录成功ToolStripMenuItem.Name = "多少个登录成功ToolStripMenuItem";
            this.多少个登录成功ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.多少个登录成功ToolStripMenuItem.Text = "多少个登录成功";
            this.多少个登录成功ToolStripMenuItem.Click += new System.EventHandler(this.多少个登录成功ToolStripMenuItem_Click_1);
            // 
            // 多少个尝试过登录ToolStripMenuItem
            // 
            this.多少个尝试过登录ToolStripMenuItem.Name = "多少个尝试过登录ToolStripMenuItem";
            this.多少个尝试过登录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.多少个尝试过登录ToolStripMenuItem.Text = "多少个尝试过登录";
            this.多少个尝试过登录ToolStripMenuItem.Click += new System.EventHandler(this.多少个尝试过登录ToolStripMenuItem_Click_1);
            // 
            // 查看活动AgentToolStripMenuItem
            // 
            this.查看活动AgentToolStripMenuItem.Name = "查看活动AgentToolStripMenuItem";
            this.查看活动AgentToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.查看活动AgentToolStripMenuItem.Text = "查看活动Agent";
            this.查看活动AgentToolStripMenuItem.Click += new System.EventHandler(this.查看活动AgentToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改用例名称ToolStripMenuItem,
            this.远程控制ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 更改用例名称ToolStripMenuItem
            // 
            this.更改用例名称ToolStripMenuItem.Name = "更改用例名称ToolStripMenuItem";
            this.更改用例名称ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更改用例名称ToolStripMenuItem.Text = "更改用例名称";
            // 
            // 远程控制ToolStripMenuItem
            // 
            this.远程控制ToolStripMenuItem.Name = "远程控制ToolStripMenuItem";
            this.远程控制ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.远程控制ToolStripMenuItem.Text = "远程控制";
            this.远程控制ToolStripMenuItem.Click += new System.EventHandler(this.远程控制ToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 550);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "StressTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 命令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceLogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改用例名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计数据toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多少个登录成功ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多少个尝试过登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看活动AgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_debugMode;
        private System.Windows.Forms.ToolStripMenuItem 远程控制ToolStripMenuItem;
    }
}

