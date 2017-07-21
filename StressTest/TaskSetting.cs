using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressTest
{
    public partial class TaskSetting : Form
    {
        public TaskSetting()
        {
            InitializeComponent();
                button_ExeTask.DialogResult = DialogResult.OK;
        }
        public int TaskCount;
        public int TaskMinDelay;
        public int TaskMaxDelay;
        private void button_ExeTask_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox_TaskCount.Text, out TaskCount) &&
                 int.TryParse(maskedTextBox_TaskMinDelay.Text, out TaskMinDelay) &&
                 int.TryParse(maskedTextBox_TaskMaxDelay.Text, out TaskMaxDelay))
            {
            }
            else
            {
                MessageBox.Show("请输入有效的数字");
            }
        }

    }
}
