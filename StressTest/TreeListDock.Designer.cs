namespace StressTest
{
    partial class TreeListDock
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
            this.workspaceTreeList1 = new StressTest.WorkspaceTreeList();
            this.SuspendLayout();
            // 
            // workspaceTreeList1
            // 
            this.workspaceTreeList1.AllowDrop = true;
            this.workspaceTreeList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.workspaceTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceTreeList1.Location = new System.Drawing.Point(0, 0);
            this.workspaceTreeList1.Name = "workspaceTreeList1";
            this.workspaceTreeList1.Size = new System.Drawing.Size(428, 586);
            this.workspaceTreeList1.TabIndex = 0;
            // 
            // TreeListDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 586);
            this.Controls.Add(this.workspaceTreeList1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "TreeListDock";
            this.Text = "TreeListDock";
            this.Load += new System.EventHandler(this.TreeListDock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WorkspaceTreeList workspaceTreeList1;
    }
}