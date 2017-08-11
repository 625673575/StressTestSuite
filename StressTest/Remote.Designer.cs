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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox_Captured = new System.Windows.Forms.PictureBox();
            this.button_SendCmd = new System.Windows.Forms.Button();
            this.textBox_CaptureQuality = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接服务器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "127.0.0.1:50051";
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_Captured);
            this.splitContainer1.Size = new System.Drawing.Size(821, 490);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 13;
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Location = new System.Drawing.Point(6, 65);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(135, 21);
            this.textBox_cmd.TabIndex = 13;
            this.textBox_cmd.Text = "getMousePos";
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
            // RemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RemoteForm";
            this.Text = "Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Remote_FormClosing);
            this.Load += new System.EventHandler(this.RemoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Captured)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox_Captured;
        private System.Windows.Forms.Button button_SendCmd;
        private System.Windows.Forms.TextBox textBox_CaptureQuality;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}