using System;
using System.Collections.Generic;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

using behaviac;
namespace StressTest
{
    public class BehaviorThreadManager
    {
        public static Dictionary<string, BehaviorGroup> ThreadGroups { private set; get; } = new Dictionary<string, BehaviorGroup>();
        public static void CreateBehaviorThread(ListBox logListBox, string btName, int count)
        {
            BehaviorGroup group = new BehaviorGroup(logListBox, btName);
            group.CreateBehaviorThread(count);
            ThreadGroups.Add(group.BehaviorName, group);
        }
        public static void Start(string btName, int minDelay, int maxDelay)
        {
            ThreadGroups[btName].Start(minDelay, maxDelay);
        }
        public static void Update()
        {
            foreach (var v in ThreadGroups)
            {
                v.Value.Update();
            }
        }
        public static void End(string btName)
        {
            if (ThreadGroups.ContainsKey(btName))
            {

                ThreadGroups[btName].End();
                ThreadGroups.Remove(btName);
            }
        }
    }

    public class BehaviorGroup
    {
        public static Random rand = new Random(DateTime.Now.Second);
        ListBox logListBox;
        public string BehaviorName { private set; get; }
        public List<BehaviorThread> BehaviorThreads { private set; get; }
        public bool Enable { private set; get; }
        public static List<KeyValuePair<int, BehaviorThread>> BTQueue = new List<KeyValuePair<int, BehaviorThread>>();

        public int Count
        {
            get { return BehaviorThreads.Count; }
        }
        public BehaviorThread this[int index]
        {
            get
            {
                return BehaviorThreads[index];
            }
        }
        public BehaviorGroup(ListBox listbox, string BtName)
        {
            Enable = false;
            BehaviorName = BtName;
            BehaviorThreads = new List<StressTest.BehaviorThread>();
            logListBox = listbox;
        }
        public void Start(int minDelay = 0, int maxDelay = 0)
        {
            Enable = true;
            int targetFrame = Workspace.Instance.FrameSinceStartup;
            foreach (BehaviorThread th in BehaviorThreads)
            {
                if (maxDelay == 0)
                {
                    th.Start();
                }
                else
                {
                    maxDelay = maxDelay - minDelay > 0 ? maxDelay : minDelay;
                    int delay = rand.Next(minDelay, maxDelay);
                    targetFrame += delay;
                    BTQueue.Add(new KeyValuePair<int, BehaviorThread>(targetFrame, th));
                }
            }
        }
        public void Update()
        {
            List<KeyValuePair<int, BehaviorThread>> usedQueue = new List<KeyValuePair<int, BehaviorThread>>();
            foreach (var bt in BTQueue)
            {
                if (bt.Key == Workspace.Instance.FrameSinceStartup)
                {
                    bt.Value.Start();
                    usedQueue.Add(bt);
                }
            }
            foreach (var i in usedQueue)
            {
                BTQueue.Remove(i);
            }
            if (Enable)
            {
                foreach (BehaviorThread thread in BehaviorThreads)
                {
                    if (thread != null)
                        thread.Update();
                }
            }
        }

        public void End()
        {
            foreach (BehaviorThread th in BehaviorThreads)
            {
                th.End();
            }
            Enable = false;
        }

        public void CreateBehaviorThread()
        {
            BehaviorThread thread = new StressTest.BehaviorThread(BehaviorName, Count);
            thread.OnAgentLogCallback += (s) => { if (RobotAgent.IsShowLogMessage) logListBox.Items.Add(string.Format("{0}:{1}", logListBox.Items.Count, s)); };

            BehaviorThreads.Add(thread);
        }

        public void CreateBehaviorThread(int Count)
        {
            for (int i = 0; i < Count; ++i)
            {
                CreateBehaviorThread();
            }
        }
    }
    public class BehaviorThread
    {
        RobotAgent _agent;
        public RobotAgent Agent
        {
            get
            {
                return _agent;
            }
        }
        public event Action<string> OnAgentLogCallback;
        public string BTName { private set; get; }
        public bool IsStart { private set; get; }
        public bool IsValid { private set; get; }

        public BehaviorThread(string btName, int id)
        {
            IsValid = false;
            IsStart = false;
            BTName = btName;
            _agent = new RobotAgent(BTName + "_" + id);

            IsValid = _agent.btload(BTName);
            Debug.Check(IsValid);
            _agent.btsetcurrent(BTName);
        }
        public bool Start()
        {
            if (IsValid)
            {
                IsStart = true;

                //添加Log回调
                _agent.OnAgentLogCallback += (s) => { if (RobotAgent.IsShowLogMessage && OnAgentLogCallback != null) OnAgentLogCallback(s); };
            }

            return IsStart;
        }

        public void Update()
        {
            if (!IsValid || !IsStart)
                return;

            //if (_agent.Net != null)
            //{
            //    _agent.Net.Update0();
            //    _agent.Net.Update1();
            //    ViAsynExecer.UpdateAll(50);
            //}

            if (_agent._status == behaviac.EBTStatus.BT_RUNNING)
            {
                // Console.WriteLine(" frame {0} name {1}", ++_agent.Frame, _agent.GetName());
                if (behaviac.Config.IsSocketBlocking)
                    behaviac.Workspace.Instance.DebugUpdate();
                _agent._status = _agent.btexec();
            }
        }
        public void End()
        {
            IsStart = false;
            RobotAgent.RemoveAgent(_agent.GetName());
            _agent = null;
        }

    }
}
