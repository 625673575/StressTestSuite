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
            this.button1 = new System.Windows.Forms.Button();
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_Captured = new System.Windows.Forms.PictureBox();
            this.button_Click = new System.Windows.Forms.Button();
            this.textBox_CaptureQuality = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captured)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接服务器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // visualStudioToolStripExtender1
            // 
            this.visualStudioToolStripExtender1.DefaultRenderer = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "192.168.1.220:50051";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "捕捉屏幕";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_CaptureClick);
            // 
            // pictureBox_Captured
            // 
            this.pictureBox_Captured.Location = new System.Drawing.Point(423, 21);
            this.pictureBox_Captured.Name = "pictureBox_Captured";
            this.pictureBox_Captured.Size = new System.Drawing.Size(284, 193);
            this.pictureBox_Captured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Captured.TabIndex = 10;
            this.pictureBox_Captured.TabStop = false;
            this.pictureBox_Captured.Click += new System.EventHandler(this.pictureBox_Captured_Click);
            this.pictureBox_Captured.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Captured_MouseClick);
            this.pictureBox_Captured.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Captured_MouseDoubleClick);
            // 
            // button_Click
            // 
            this.button_Click.Location = new System.Drawing.Point(13, 104);
            this.button_Click.Name = "button_Click";
            this.button_Click.Size = new System.Drawing.Size(75, 23);
            this.button_Click.TabIndex = 11;
            this.button_Click.Text = "当前位置";
            this.button_Click.UseVisualStyleBackColor = true;
            this.button_Click.Click += new System.EventHandler(this.button_Click_Click);
            // 
            // textBox_CaptureQuality
            // 
            this.textBox_CaptureQuality.Location = new System.Drawing.Point(13, 42);
            this.textBox_CaptureQuality.Name = "textBox_CaptureQuality";
            this.textBox_CaptureQuality.Size = new System.Drawing.Size(100, 21);
            this.textBox_CaptureQuality.TabIndex = 12;
            this.textBox_CaptureQuality.Text = "100";
            // 
            // RemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 376);
            this.Controls.Add(this.textBox_CaptureQuality);
            this.Controls.Add(this.button_Click);
            this.Controls.Add(this.pictureBox_Captured);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "RemoteForm";
            this.Text = "Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Remote_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox_Captured;
        private System.Windows.Forms.Button button_Click;
        private System.Windows.Forms.TextBox textBox_CaptureQuality;
    }
}