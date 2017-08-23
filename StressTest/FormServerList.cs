using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace StressTest
{
    public partial class FormServerList : Form
    {
        public const string CONFIG_SERVER_LIST = "./Config/serverList.txt";
        public FormServerList()
        {
            InitializeComponent();
        }
        Dictionary<string, RemoteClient> serverDir = new Dictionary<string, RemoteClient>();

        private void FormServerList_Load(object sender, EventArgs e)
        {
            comboBox_serverList.Items.Clear();
            foreach (string t in File.ReadAllLines(CONFIG_SERVER_LIST))
            {
                comboBox_serverList.Items.Add(t);
            }
            if (comboBox_serverList.Items.Count > 0)
            {
                comboBox_serverList.SelectedIndex = 0;
            }
        }

        private void button_Conn_Click(object sender, EventArgs e)
        {
            if (isValidServerAddress())
            {
                var lst = comboBox_serverList.SelectedItem.ToString().Split('|');
                var ipAddr = lst[1];
                var machineName = lst[0];
                var client = RemoteClient.CreateService(machineName, ipAddr);

                serverDir.Add(ipAddr, client);
                RemoteForm form = new RemoteForm(client);
                form.Show();
            }
        }

        private bool isValidServerAddress()
        {
            comboBox_serverList.SelectedItem.ToString();
            return true;
        }
    }
}
