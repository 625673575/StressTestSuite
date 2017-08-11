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
    public partial class Form_Text : Form
    {
        public Form_Text()
        {
            InitializeComponent();
        }
        public Form_Text(string content)
        {
            InitializeComponent();
            textBox1.Text = content;
        }

        private void Form_Text_Load(object sender, EventArgs e)
        {

            textBox1.Select(0, 0);
        }
    }
}
