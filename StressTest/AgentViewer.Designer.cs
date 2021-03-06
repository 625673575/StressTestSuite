﻿namespace StressTest
{
    partial class AgentViewer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBoxAgentGroup = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefreshAgentGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRenameList = new System.Windows.Forms.ToolStripButton();
            this.listBoxAgentThread = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_AgentThread = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_ApplyAllAgent = new System.Windows.Forms.CheckBox();
            this.button_Operation = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox_Operation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_autoRefreshReflection = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_ShowValue = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_Property = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制全部信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_IsThreadStart = new System.Windows.Forms.CheckBox();
            this.textBox_BTName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_autoRefreshReflection = new System.Windows.Forms.Timer(this.components);
            this.listBox_ShowProp = new System.Windows.Forms.ListBox();
            this.textBox_PropertyValue = new System.Windows.Forms.TextBox();
            this.button_ModifyProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip_AgentThread.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip_Property.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 781);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBoxAgentGroup);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxAgentThread);
            this.splitContainer2.Size = new System.Drawing.Size(189, 781);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.TabIndex = 3;
            // 
            // listBoxAgentGroup
            // 
            this.listBoxAgentGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAgentGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxAgentGroup.FormattingEnabled = true;
            this.listBoxAgentGroup.ItemHeight = 16;
            this.listBoxAgentGroup.Location = new System.Drawing.Point(0, 25);
            this.listBoxAgentGroup.Name = "listBoxAgentGroup";
            this.listBoxAgentGroup.Size = new System.Drawing.Size(189, 365);
            this.listBoxAgentGroup.TabIndex = 3;
            this.listBoxAgentGroup.SelectedIndexChanged += new System.EventHandler(this.listBoxAgentGroup_SelectedIndexChanged);
            this.listBoxAgentGroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAgentGroup_MouseDoubleClick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefreshAgentGroup,
            this.toolStripSeparator2,
            this.toolStripButtonRenameList});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(189, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonRefreshAgentGroup
            // 
            this.toolStripButtonRefreshAgentGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefreshAgentGroup.Image = global::StressTest.Properties.Resources.ICON__0007_39;
            this.toolStripButtonRefreshAgentGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshAgentGroup.Name = "toolStripButtonRefreshAgentGroup";
            this.toolStripButtonRefreshAgentGroup.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefreshAgentGroup.Text = "toolStripButton3";
            this.toolStripButtonRefreshAgentGroup.Click += new System.EventHandler(this.toolStripButtonRefreshAgentGroup_Click);
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
            this.toolStripButtonRenameList.Text = "toolStripButton3";
            // 
            // listBoxAgentThread
            // 
            this.listBoxAgentThread.ContextMenuStrip = this.contextMenuStrip_AgentThread;
            this.listBoxAgentThread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAgentThread.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxAgentThread.FormattingEnabled = true;
            this.listBoxAgentThread.ItemHeight = 16;
            this.listBoxAgentThread.Location = new System.Drawing.Point(0, 0);
            this.listBoxAgentThread.Name = "listBoxAgentThread";
            this.listBoxAgentThread.Size = new System.Drawing.Size(189, 387);
            this.listBoxAgentThread.TabIndex = 4;
            this.listBoxAgentThread.SelectedIndexChanged += new System.EventHandler(this.listBoxAgentThread_SelectedIndexChanged);
            // 
            // contextMenuStrip_AgentThread
            // 
            this.contextMenuStrip_AgentThread.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip_AgentThread.Name = "contextMenuStrip_Property";
            this.contextMenuStrip_AgentThread.Size = new System.Drawing.Size(125, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "显示所有";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_ModifyProperty);
            this.groupBox6.Controls.Add(this.textBox_PropertyValue);
            this.groupBox6.Location = new System.Drawing.Point(431, 413);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(451, 365);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "行为树属性修改";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox_ShowProp);
            this.groupBox5.Location = new System.Drawing.Point(431, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 394);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "行为树属性信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.comboBox_Operation);
            this.groupBox4.Location = new System.Drawing.Point(16, 494);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 284);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "执行方法";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_ApplyAllAgent);
            this.groupBox2.Controls.Add(this.button_Operation);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请选择";
            // 
            // checkBox_ApplyAllAgent
            // 
            this.checkBox_ApplyAllAgent.AutoSize = true;
            this.checkBox_ApplyAllAgent.Location = new System.Drawing.Point(93, 205);
            this.checkBox_ApplyAllAgent.Name = "checkBox_ApplyAllAgent";
            this.checkBox_ApplyAllAgent.Size = new System.Drawing.Size(84, 16);
            this.checkBox_ApplyAllAgent.TabIndex = 2;
            this.checkBox_ApplyAllAgent.Text = "应用到所有";
            this.checkBox_ApplyAllAgent.UseVisualStyleBackColor = true;
            // 
            // button_Operation
            // 
            this.button_Operation.Location = new System.Drawing.Point(231, 201);
            this.button_Operation.Name = "button_Operation";
            this.button_Operation.Size = new System.Drawing.Size(75, 23);
            this.button_Operation.TabIndex = 1;
            this.button_Operation.Text = "执行函数";
            this.button_Operation.UseVisualStyleBackColor = true;
            this.button_Operation.Click += new System.EventHandler(this.button_Operation_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 175);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // comboBox_Operation
            // 
            this.comboBox_Operation.FormattingEnabled = true;
            this.comboBox_Operation.Location = new System.Drawing.Point(9, 21);
            this.comboBox_Operation.Name = "comboBox_Operation";
            this.comboBox_Operation.Size = new System.Drawing.Size(366, 20);
            this.comboBox_Operation.TabIndex = 6;
            this.comboBox_Operation.Text = "请选择方法";
            this.comboBox_Operation.SelectedIndexChanged += new System.EventHandler(this.comboBox_Operation_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.checkBox_autoRefreshReflection);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox_ShowValue);
            this.groupBox3.Location = new System.Drawing.Point(16, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 421);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "属性信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "刷新频率";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(317, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 21);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox_autoRefreshReflection
            // 
            this.checkBox_autoRefreshReflection.AutoSize = true;
            this.checkBox_autoRefreshReflection.Location = new System.Drawing.Point(146, 18);
            this.checkBox_autoRefreshReflection.Name = "checkBox_autoRefreshReflection";
            this.checkBox_autoRefreshReflection.Size = new System.Drawing.Size(72, 16);
            this.checkBox_autoRefreshReflection.TabIndex = 6;
            this.checkBox_autoRefreshReflection.Text = "自动刷新";
            this.checkBox_autoRefreshReflection.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_ShowValue
            // 
            this.listBox_ShowValue.ContextMenuStrip = this.contextMenuStrip_Property;
            this.listBox_ShowValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_ShowValue.FormattingEnabled = true;
            this.listBox_ShowValue.ItemHeight = 16;
            this.listBox_ShowValue.Location = new System.Drawing.Point(6, 43);
            this.listBox_ShowValue.Name = "listBox_ShowValue";
            this.listBox_ShowValue.Size = new System.Drawing.Size(375, 372);
            this.listBox_ShowValue.TabIndex = 4;
            this.listBox_ShowValue.SelectedIndexChanged += new System.EventHandler(this.listBox_ShowValue_SelectedIndexChanged);
            this.listBox_ShowValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_ShowValue_MouseDoubleClick);
            // 
            // contextMenuStrip_Property
            // 
            this.contextMenuStrip_Property.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.复制信息ToolStripMenuItem,
            this.复制全部信息ToolStripMenuItem});
            this.contextMenuStrip_Property.Name = "contextMenuStrip_Property";
            this.contextMenuStrip_Property.Size = new System.Drawing.Size(149, 70);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 复制信息ToolStripMenuItem
            // 
            this.复制信息ToolStripMenuItem.Name = "复制信息ToolStripMenuItem";
            this.复制信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制信息ToolStripMenuItem.Text = "复制信息";
            this.复制信息ToolStripMenuItem.Click += new System.EventHandler(this.复制信息ToolStripMenuItem_Click);
            // 
            // 复制全部信息ToolStripMenuItem
            // 
            this.复制全部信息ToolStripMenuItem.Name = "复制全部信息ToolStripMenuItem";
            this.复制全部信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制全部信息ToolStripMenuItem.Text = "复制全部信息";
            this.复制全部信息ToolStripMenuItem.Click += new System.EventHandler(this.复制全部信息ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_IsThreadStart);
            this.groupBox1.Controls.Add(this.textBox_BTName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态";
            // 
            // checkBox_IsThreadStart
            // 
            this.checkBox_IsThreadStart.AutoSize = true;
            this.checkBox_IsThreadStart.Location = new System.Drawing.Point(225, 21);
            this.checkBox_IsThreadStart.Name = "checkBox_IsThreadStart";
            this.checkBox_IsThreadStart.Size = new System.Drawing.Size(72, 16);
            this.checkBox_IsThreadStart.TabIndex = 3;
            this.checkBox_IsThreadStart.Text = "是否登陆";
            this.checkBox_IsThreadStart.UseVisualStyleBackColor = true;
            // 
            // textBox_BTName
            // 
            this.textBox_BTName.Location = new System.Drawing.Point(102, 18);
            this.textBox_BTName.Name = "textBox_BTName";
            this.textBox_BTName.Size = new System.Drawing.Size(100, 21);
            this.textBox_BTName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行为树名称";
            // 
            // timer_autoRefreshReflection
            // 
            this.timer_autoRefreshReflection.Enabled = true;
            this.timer_autoRefreshReflection.Tick += new System.EventHandler(this.timer_autoRefreshReflection_Tick);
            // 
            // listBox_ShowProp
            // 
            this.listBox_ShowProp.ContextMenuStrip = this.contextMenuStrip_Property;
            this.listBox_ShowProp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_ShowProp.FormattingEnabled = true;
            this.listBox_ShowProp.ItemHeight = 16;
            this.listBox_ShowProp.Location = new System.Drawing.Point(6, 22);
            this.listBox_ShowProp.Name = "listBox_ShowProp";
            this.listBox_ShowProp.Size = new System.Drawing.Size(439, 356);
            this.listBox_ShowProp.TabIndex = 5;
            // 
            // textBox_PropertyValue
            // 
            this.textBox_PropertyValue.Location = new System.Drawing.Point(16, 21);
            this.textBox_PropertyValue.Name = "textBox_PropertyValue";
            this.textBox_PropertyValue.Size = new System.Drawing.Size(327, 21);
            this.textBox_PropertyValue.TabIndex = 0;
            // 
            // button_ModifyProperty
            // 
            this.button_ModifyProperty.Location = new System.Drawing.Point(368, 21);
            this.button_ModifyProperty.Name = "button_ModifyProperty";
            this.button_ModifyProperty.Size = new System.Drawing.Size(75, 23);
            this.button_ModifyProperty.TabIndex = 1;
            this.button_ModifyProperty.Text = "修改";
            this.button_ModifyProperty.UseVisualStyleBackColor = true;
            this.button_ModifyProperty.Click += new System.EventHandler(this.button_ModifyProperty_Click);
            // 
            // AgentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 781);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AgentViewer";
            this.Text = "AgentViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentViewer_FormClosing);
            this.Load += new System.EventHandler(this.AgentViewer_Load);
            this.VisibleChanged += new System.EventHandler(this.AgentViewer_VisibleChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip_AgentThread.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip_Property.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefreshAgentGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenameList;
        private System.Windows.Forms.ListBox listBoxAgentGroup;
        private System.Windows.Forms.ListBox listBoxAgentThread;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BTName;
        private System.Windows.Forms.CheckBox checkBox_IsThreadStart;
        private System.Windows.Forms.ListBox listBox_ShowValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Operation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Operation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Property;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制全部信息ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox_autoRefreshReflection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_autoRefreshReflection;
        private System.Windows.Forms.CheckBox checkBox_ApplyAllAgent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_AgentThread;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox_ShowProp;
        private System.Windows.Forms.Button button_ModifyProperty;
        private System.Windows.Forms.TextBox textBox_PropertyValue;
    }
}