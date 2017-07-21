namespace StressTest
{
    partial class WorkspaceTreeList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkspaceTreeList));
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenu_rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripButtonRefreshWorkspace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRenameList = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.contextMenu_rightClick.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.ContextMenuStrip = this.contextMenu_rightClick;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeView.FullRowSelect = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(0, 25);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(381, 646);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_BeforeLabelEdit);
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
            // 
            // contextMenu_rightClick
            // 
            this.contextMenu_rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem});
            this.contextMenu_rightClick.Name = "contextMenu_rightClick";
            this.contextMenu_rightClick.Size = new System.Drawing.Size(113, 26);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Folder-Open.png");
            this.imageList.Images.SetKeyName(1, "folder_new.png");
            this.imageList.Images.SetKeyName(2, "prefab.ico");
            // 
            // toolStripButtonRefreshWorkspace
            // 
            this.toolStripButtonRefreshWorkspace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshWorkspace.Image = global::StressTest.Properties.Resources.ICON__0007_39;
            this.toolStripButtonRefreshWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshWorkspace.Name = "toolStripButtonRefreshWorkspace";
            this.toolStripButtonRefreshWorkspace.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefreshWorkspace.Text = "刷新";
            this.toolStripButtonRefreshWorkspace.Click += new System.EventHandler(this.toolStripButtonRefreshWorkspace_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRenameList
            // 
            this.toolStripButtonRenameList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRenameList.Image = global::StressTest.Properties.Resources.method;
            this.toolStripButtonRenameList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRenameList.Name = "toolStripButtonRenameList";
            this.toolStripButtonRenameList.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRenameList.Text = "修改用例名称";
            this.toolStripButtonRenameList.Click += new System.EventHandler(this.toolStripButtonRenameList_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefreshWorkspace,
            this.toolStripSeparator2,
            this.toolStripButtonRenameList});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(381, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // WorkspaceTreeList
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.toolStrip);
            this.Name = "WorkspaceTreeList";
            this.Size = new System.Drawing.Size(381, 671);
            this.contextMenu_rightClick.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenu_rightClick;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefreshWorkspace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenameList;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}
