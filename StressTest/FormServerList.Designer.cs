namespace StressTest
{
    partial class FormServerList
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
            this.comboBox_serverList = new System.Windows.Forms.ComboBox();
            this.listBox_activeServer = new System.Windows.Forms.ListBox();
            this.button_Conn = new System.Windows.Forms.Button();
            this.button_DisConn = new System.Windows.Forms.Button();
            this.button_CheckState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_serverList
            // 
            this.comboBox_serverList.FormattingEnabled = true;
            this.comboBox_serverList.Location = new System.Drawing.Point(12, 12);
            this.comboBox_serverList.Name = "comboBox_serverList";
            this.comboBox_serverList.Size = new System.Drawing.Size(262, 20);
            this.comboBox_serverList.TabIndex = 0;
            // 
            // listBox_activeServer
            // 
            this.listBox_activeServer.FormattingEnabled = true;
            this.listBox_activeServer.ItemHeight = 12;
            this.listBox_activeServer.Location = new System.Drawing.Point(12, 78);
            this.listBox_activeServer.Name = "listBox_activeServer";
            this.listBox_activeServer.Size = new System.Drawing.Size(262, 364);
            this.listBox_activeServer.TabIndex = 1;
            // 
            // button_Conn
            // 
            this.button_Conn.Location = new System.Drawing.Point(12, 42);
            this.button_Conn.Name = "button_Conn";
            this.button_Conn.Size = new System.Drawing.Size(75, 23);
            this.button_Conn.TabIndex = 2;
            this.button_Conn.Text = "连接";
            this.button_Conn.UseVisualStyleBackColor = true;
            this.button_Conn.Click += new System.EventHandler(this.button_Conn_Click);
            // 
            // button_DisConn
            // 
            this.button_DisConn.Location = new System.Drawing.Point(104, 42);
            this.button_DisConn.Name = "button_DisConn";
            this.button_DisConn.Size = new System.Drawing.Size(75, 23);
            this.button_DisConn.TabIndex = 3;
            this.button_DisConn.Text = "断开";
            this.button_DisConn.UseVisualStyleBackColor = true;
            // 
            // button_CheckState
            // 
            this.button_CheckState.Location = new System.Drawing.Point(199, 42);
            this.button_CheckState.Name = "button_CheckState";
            this.button_CheckState.Size = new System.Drawing.Size(75, 23);
            this.button_CheckState.TabIndex = 4;
            this.button_CheckState.Text = "查看状态";
            this.button_CheckState.UseVisualStyleBackColor = true;
            // 
            // FormServerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 453);
            this.Controls.Add(this.button_CheckState);
            this.Controls.Add(this.button_DisConn);
            this.Controls.Add(this.button_Conn);
            this.Controls.Add(this.listBox_activeServer);
            this.Controls.Add(this.comboBox_serverList);
            this.Name = "FormServerList";
            this.Text = "FormServerList";
            this.Load += new System.EventHandler(this.FormServerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_serverList;
        private System.Windows.Forms.ListBox listBox_activeServer;
        private System.Windows.Forms.Button button_Conn;
        private System.Windows.Forms.Button button_DisConn;
        private System.Windows.Forms.Button button_CheckState;
    }
}