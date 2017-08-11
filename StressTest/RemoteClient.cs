using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;
using System.IO;
using Remote;
using pb = global::Google.Protobuf;

namespace StressTest
{
    public class RemoteClient
    {
        public bool PauseCapture;
        AsyncUnaryCall<ImageData> receiveImageCall;
        RemoteService.RemoteServiceClient service;
        static Dictionary<string, RemoteClient> clients = new Dictionary<string, RemoteClient>();
        public System.Action<Stream> OnReceiveImageStream;
        public static RemoteClient CreateService(string serviceName, string remoteIP)
        {
            RemoteClient client = new RemoteClient();
            Channel channel = new Channel(remoteIP, ChannelCredentials.Insecure);
            client.service = new RemoteService.RemoteServiceClient(channel);
            client.PauseCapture = false;
            clients.Add(serviceName, client);
            return client;
        }

        public void StartCapture(int quality, bool fullScreen = true)
        {
            var param = new CaptureParams();
            param.Quality = quality;
            param.FullScreen = true;
            receiveImageCall = service.CaptureScreenAsync(param);
            receiveImageCall.GetAwaiter().OnCompleted(() =>
            {
                if (receiveImageCall.GetStatus().StatusCode != StatusCode.OK)
                    return;
                var bs = receiveImageCall.ResponseAsync.Result.Data.ToByteArray();
                OnReceiveImageStream?.Invoke(new System.IO.MemoryStream(bs));
                if (!PauseCapture)
                    StartCapture(quality, fullScreen);
            }
            );
        }

        public void StopCapture()
        {
            if (receiveImageCall != null)
            {
                PauseCapture = true;
                receiveImageCall.Dispose();
            }
        }

        public string SendCommand(string cmd, string[] args, out Log[] logs)
        {
            CmdRequest request = new CmdRequest();
            request.Cmd = cmd;
            foreach (var arg in args)
                request.Args.Add(arg);
            var log = service.ExecCmd(request);
            Log[] ret = new Log[1];
            log.Logs.CopyTo(ret, 0);
            logs = ret;
            return log.Logs.ToString();
        }
        #region 鼠标键盘操作
        public MousePosition GetMousePos()
        {
            var request = new Nil();
            return service.GetMousePosition(request);
        }

        public void TapKey(string[] key, float delay)
        {
            KeyTapRequest r = new KeyTapRequest();
            r.KeyCode.AddRange(key);
            r.Delay = delay;
        }
        public bool TapManyKey(string[][] keys, float[] delays)
        {
            int l1 = keys.Length;
            int l2 = delays.Length;
            if (l1 != l2)
            {
                return false;
            }
            KeyListTapRequest r = new KeyListTapRequest();
            for (int i = 0; i < l1; i++)
            {
                KeyTapRequest ele = new KeyTapRequest();
                ele.KeyCode.AddRange(keys[i]);
                ele.Delay = delays[i];
                service.KeyTap(ele);
            }
            service.KeyListTap(r);
            return true;
        }

        public Log MouseClick(int x, int y, bool doubleClick, System.Windows.Forms.MouseButtons button)
        {
            var request = new MouseClickRequest();
            request.DoubleClick = doubleClick;
            request.X = x;
            request.Y = y;
            request.Button = (Remote.MouseButtons)(button);
            Log ret = service.MouseClick(request);
            return ret;
        }
        #endregion

        #region  文件操作
        public string[] GetRemoteDiskPartion()
        {
            var request = new Nil();
            Log ret = service.ListDisk(request);
            string[] s = ret.Content.Split();
            return s;
        }
        public FileEntrys GetRemoteDir(string parentDir)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = parentDir;
            return service.ListDir(req);
        }
        public Log ReadTextFile(string fileUrl)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = fileUrl;
            return service.ReadText(req);
        }
        public byte[] ReadFile(string fileUrl)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = fileUrl;
            return service.ReadFile(req).Data.ToByteArray();
        }
        public Log RenameFile(string oldName, string newName)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = oldName;
            req.Args.Add(newName);
            return service.Rename(req);
        }
        public Log CreateTextFile(string fileName, string content)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = fileName;
            req.Args.Add(content);
            return service.CreateText(req);
        }
        public Log CreateFile(string fileName, byte[] data)
        {
            FileData req = new FileData();
            req.Data = pb.ByteString.CopyFrom(data);
            req.FullName = fileName;
            return service.CreateFile(req);
        }
        public Log CreateFile(string fileName, Stream data)
        {
            FileData req = new FileData();
            req.Data = pb.ByteString.FromStream(data);
            req.FullName = fileName;
            return service.CreateFile(req);
        }
        public Log DeleteFile(string fileName)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = fileName;
            return service.DeleteFile(req);
        }
        public Log DeleteFolder(string folderName)
        {
            CmdRequest req = new CmdRequest();
            req.Cmd = folderName;
            return service.DeleteFolder(req);
        }
        #endregion

    }
}
