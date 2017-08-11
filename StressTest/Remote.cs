using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Grpc.Core;
using Remote;
using pb = global::Google.Protobuf;
namespace StressTest
{
    public partial class RemoteForm : Form
    {
        public RemoteForm()
        {
            InitializeComponent();
        }
        public bool PauseCapture;
        AsyncUnaryCall<ImageData> receiveImageCall;
        RemoteService.RemoteServiceClient client;
        private void button1_Click(object sender, EventArgs e)
        {
            Channel channel = new Channel(textBox1.Text, ChannelCredentials.Insecure);

            client = new RemoteService.RemoteServiceClient(channel);
            PauseCapture = false;
            groupBox1.Enabled = true;
        }

        private void button_CaptureClick(object sender, EventArgs e)
        {
            var param = new CaptureParams();
            int quality = 50;
            if (int.TryParse(textBox_CaptureQuality.Text, out quality))
                param.Quality = quality;
            else
                param.Quality = 50;
            param.FullScreen = true;
            receiveImageCall = client.CaptureScreenAsync(param);
            receiveImageCall.GetAwaiter().OnCompleted(() =>
            {
                if (receiveImageCall.GetStatus().StatusCode != StatusCode.OK)
                    return;
                var bs = receiveImageCall.ResponseAsync.Result.Data.ToByteArray();
                pictureBox_Captured.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(bs));
                if (!PauseCapture)
                    button_CaptureClick(sender, e);
            }
            );
        }
        public void GetMousePos()
        {
            var request = new Nil();
            MousePosition ret = client.GetMousePosition(request);
            MessageBox.Show(ret.X + " " + ret.Y);
        }
        public void TapKey(string[] key, float delay)
        {
            textBox_CaptureQuality.Focus();
            KeyTapRequest r = new KeyTapRequest();
            r.KeyCode.AddRange(key);
            r.Delay = delay;
            client.KeyTap(r);
        }
        public void TapManyKey(string[][] keys, float[] delays)
        {
            int l1 = keys.Length;
            int l2 = delays.Length;
            if (l1 != l2)
            {
                MessageBox.Show("参数有误");
                return;
            }
            textBox_CaptureQuality.Focus();
            KeyListTapRequest r = new KeyListTapRequest();
            for (int i = 0; i < l1; i++)
            {
                KeyTapRequest ele = new KeyTapRequest();
                ele.KeyCode.AddRange(keys[i]);
                ele.Delay = delays[i];
                client.KeyTap(ele);
            }
            client.KeyListTap(r);
        }

        private void TestTapManyKey()
        {
            string[][] s = new string[][] { new string[] { "a", "shift" }, new string[] { "b" }, new string[] { "e" } };
            float[] delay = new float[] { 1.0f, 2.0f, 5.0f };
            TapManyKey(s, delay);
        }
        public void SendCmd(string cmd, string[] args)
        {
            CmdRequest request = new CmdRequest();
            request.Cmd = cmd;
            foreach (var arg in args)
                request.Args.Add(arg);
            var log = client.ExecCmd(request);
            MessageBox.Show(log.Logs.ToString());
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
                SendCmd(s[0], args.ToArray());
            }

        }

        private void Remote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiveImageCall != null)
            {
                PauseCapture = true;
                receiveImageCall.Dispose();
            }
        }

        private void pictureBox_Captured_MouseClick(object sender, MouseEventArgs e)
        {
            var request = new MouseClickRequest();
            request.DoubleClick = false;
            request.X = e.X;
            request.Y = e.Y;
            Log ret = client.MouseClick(request);
        }

        private void pictureBox_Captured_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var request = new MouseClickRequest();
            request.DoubleClick = true;
            request.X = e.X;
            request.Y = e.Y;
            request.Button = (Remote.MouseButtons)(e.Button);
            Log ret = client.MouseClick(request);
        }

        private void pictureBox_Captured_Click(object sender, EventArgs e)
        {

        }

        private void RemoteForm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }
    }
}
