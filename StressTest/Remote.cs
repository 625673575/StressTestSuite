using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using Helloworld;
namespace StressTest
{
    public partial class Remote : Form
    {
        public Remote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Greeter.GreeterClient(channel);
            string user = "you"; 
            Int32[] x = new Int32[] { 1234, 232, 12, 23 };
            var reply = new AddReply();
            reply.Result.AddRange(x);
            AsyncUnaryCall < Int32Reply > ret=client.RemoteReduceSumAsync(reply);
            ret.GetAwaiter().OnCompleted(() => MessageBox.Show(" fjdksljfadsl "+ret.ResponseAsync.Result));
            Console.WriteLine("Greeting: " + ret);

           // channel.ShutdownAsync().Wait();
        }
    }
}
