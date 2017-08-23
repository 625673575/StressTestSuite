using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Grpc.Core;
using System.IO;
using Remote;
using pb = global::Google.Protobuf;
namespace StressTest
{
    public partial class RemoteForm : Form
    {
        RemoteClient client;
        public bool PauseCapture;
        public RemoteForm(RemoteClient remoteClient)
        {
            InitializeComponent();
            this.client = remoteClient;
            Text = client.RemoteTarget;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }
        private void button_CaptureClick(object sender, EventArgs e)
        {
            int quality = 50;
            int.TryParse(textBox_CaptureQuality.Text, out quality);
            client.StartCapture(quality);
            client.OnReceiveImageStream = (data) => pictureBox_Captured.Image = System.Drawing.Image.FromStream(data);
        }


        private void button_Click_Click(object sender, EventArgs e)
        {
            string[] s = textBox_cmd.Text.Split(' ');
            if (s.Length < 0 || s[0].Length == 0)
            {
                MessageBox.Show("请输入命令");
                return;
            }
            else
            {
                List<string> args = new List<string>();
                for (int i = 1; i < s.Length; i++)
                {
                    args.Add(s[i]);
                }
                var log = new Log[0];
                string logStr = client.SendCommand(s[0], args.ToArray(), out log);
                MessageBox.Show(logStr);
            }

        }

        private void Remote_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.StopCapture();
        }

        private void pictureBox_Captured_MouseClick(object sender, MouseEventArgs e)
        {
            Log ret = client.MouseClick(e.X, e.Y, false, e.Button);
        }

        private void pictureBox_Captured_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Log ret = client.MouseClick(e.X, e.Y, false, e.Button);
        }

        private void pictureBox_Captured_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_File_Refresh_Click(object sender, EventArgs e)
        {
        }
        string currentRemoteFolder;
        private void toolStrip_File_Root_Click(object sender, EventArgs e)
        {
            SetRootView();
        }
        private void SetRootView()
        {
            string[] disks = client.GetRemoteDiskPartion();
            currentRemoteFolder = string.Empty;
            SetDiskPartionView(disks);
        }
        private void treeView_RemoteFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FileEntry entry = e.Node.Tag as FileEntry;
            if (entry == null || entry.IsDir)
            {
                currentRemoteFolder = System.IO.Path.Combine(currentRemoteFolder, e.Node.Text);
                FileEntrys entrys = client.GetRemoteDir(currentRemoteFolder);
                SetDirectoryView(currentRemoteFolder, entrys);
            }
            else
            {
                string fileName = System.IO.Path.Combine(currentRemoteFolder, e.Node.Text);
                Log log = client.ReadTextFile(fileName);
                if (log.LogType == LOG_TYPE.Debug)
                {
                    Form_Text f = new Form_Text(log.Content);
                    f.Show();
                }
                else
                {
                    MessageBox.Show(log.Content, log.LogType.ToString());
                }
            }
        }

        private void SetDiskPartionView(string[] partitions)
        {
            treeView_RemoteFiles.Nodes.Clear();
            currentRemoteFolder = "...";
            TreeNode root = treeView_RemoteFiles.Nodes.Add(currentRemoteFolder);
            foreach (var x in partitions)
            {
                root.Nodes.Add(string.Format("{0}:\\", x));
            }
            treeView_RemoteFiles.ExpandAll();
        }

        private void SetDirectoryView(string parentFolder, FileEntrys fileEntrys)
        {
            int pLen = parentFolder.Length;
            treeView_RemoteFiles.Nodes.Clear();
            TreeNode root = treeView_RemoteFiles.Nodes.Add(parentFolder);
            foreach (var x in fileEntrys.Entrys)
            {
                string treeName = x.FullName;
                TreeNode node = root.Nodes.Add(string.Format("{0}", treeName));
                node.Tag = x;
            }
            treeView_RemoteFiles.ExpandAll();
        }
        #region Test
        private void TestTapManyKey()
        {
            string[][] s = new string[][] { new string[] { "a", "shift" }, new string[] { "b" }, new string[] { "e" } };
            float[] delay = new float[] { 1.0f, 2.0f, 5.0f };
            client.TapManyKey(s, delay);
        }
        #endregion

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (currentRemoteFolder == null || currentRemoteFolder == "...")
                return;
            currentRemoteFolder = System.IO.Path.GetDirectoryName(currentRemoteFolder);
            if (currentRemoteFolder == null)
            {
                SetRootView();
            }
            else
            {
                FileEntrys entrys = client.GetRemoteDir(currentRemoteFolder);
                SetDirectoryView(currentRemoteFolder, entrys);
            }
        }

        private void 下载文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = treeView_RemoteFiles.SelectedNode.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = System.IO.Path.Combine(currentRemoteFolder, treeView_RemoteFiles.SelectedNode.Text); ;
                byte[] data = client.ReadFile(fileName);
                if (data.Length > 0)
                    File.WriteAllBytes(saveFileDialog1.FileName, data);
                else
                {
                    MessageBox.Show("无效的文件");
                }
            }
        }

        private void treeView_RemoteFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Right)
                return;
            TreeNode node = treeView_RemoteFiles.GetNodeAt(e.Location);
            if (node != null)
            {
                treeView_RemoteFiles.SelectedNode = node;
                FileEntry entry = treeView_RemoteFiles.SelectedNode.Tag as FileEntry;
                if (entry==null || entry.IsDir)
                {
                    contextMenuStrip_fileTree.Items[0].Enabled = false;
                }
                else {
                    contextMenuStrip_fileTree.Items[0].Enabled = true ;
                }
            }
        }
    }
}
