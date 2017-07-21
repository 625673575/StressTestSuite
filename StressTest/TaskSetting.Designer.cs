namespace StressTest
{
    partial class TaskSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_TaskCount = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_TaskMinDelay = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_TaskMaxDelay = new System.Windows.Forms.MaskedTextBox();
            this.button_ExeTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最小延迟";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "最大延迟";
            // 
            // maskedTextBox_TaskCount
            // 
            this.maskedTextBox_TaskCount.Location = new System.Drawing.Point(95, 19);
            this.maskedTextBox_TaskCount.Mask = "99999";
            this.maskedTextBox_TaskCount.Name = "maskedTextBox_TaskCount";
            this.maskedTextBox_TaskCount.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox_TaskCount.TabIndex = 3;
            this.maskedTextBox_TaskCount.Text = "10";
            this.maskedTextBox_TaskCount.ValidatingType = typeof(int);
            // 
            // maskedTextBox_TaskMinDelay
            // 
            this.maskedTextBox_TaskMinDelay.Location = new System.Drawing.Point(95, 43);
            this.maskedTextBox_TaskMinDelay.Mask = "9999";
            this.maskedTextBox_TaskMinDelay.Name = "maskedTextBox_TaskMinDelay";
            this.maskedTextBox_TaskMinDelay.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox_TaskMinDelay.TabIndex = 4;
            this.maskedTextBox_TaskMinDelay.Text = "0";
            this.maskedTextBox_TaskMinDelay.ValidatingType = typeof(int);
            // 
            // maskedTextBox_TaskMaxDelay
            // 
            this.maskedTextBox_TaskMaxDelay.Location = new System.Drawing.Point(95, 71);
            this.maskedTextBox_TaskMaxDelay.Mask = "9999";
            this.maskedTextBox_TaskMaxDelay.Name = "maskedTextBox_TaskMaxDelay";
            this.maskedTextBox_TaskMaxDelay.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox_TaskMaxDelay.TabIndex = 5;
            this.maskedTextBox_TaskMaxDelay.Text = "1";
            this.maskedTextBox_TaskMaxDelay.ValidatingType = typeof(int);
            // 
            // button_ExeTask
            // 
            this.button_ExeTask.Location = new System.Drawing.Point(64, 140);
            this.button_ExeTask.Name = "button_ExeTask";
            this.button_ExeTask.Size = new System.Drawing.Size(75, 23);
            this.button_ExeTask.TabIndex = 6;
            this.button_ExeTask.Text = "执行";
            this.button_ExeTask.UseVisualStyleBackColor = true;
            this.button_ExeTask.Click += new System.EventHandler(this.button_ExeTask_Click);
            // 
            // TaskSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 175);
            this.Controls.Add(this.button_ExeTask);
            this.Controls.Add(this.maskedTextBox_TaskMaxDelay);
            this.Controls.Add(this.maskedTextBox_TaskMinDelay);
            this.Controls.Add(this.maskedTextBox_TaskCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskSetting";
            this.Text = "TaskSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TaskCount;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TaskMinDelay;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TaskMaxDelay;
        private System.Windows.Forms.Button button_ExeTask;
    }
}