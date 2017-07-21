using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressTest
{
    public partial class LabelInput : UserControl
    {
        public LabelInput(string label, string input = "")
        {
            InitializeComponent();
            label1.Text = label;
            textBox1.Text = input;
        }
        public LabelInput()
        {
            InitializeComponent();
        }
        public new string Text
        {
            get { return textBox1.Text; }
        }
    }
}