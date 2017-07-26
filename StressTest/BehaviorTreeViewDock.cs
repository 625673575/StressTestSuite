using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using behaviac;
using System.IO;

namespace StressTest
{
    public partial class BehaviorTreeViewDock : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public string RelativeFilePath { private set; get; }
        public int TaskCount { private set; get; }
        public int TaskMinDelay { private set; get; }
        public int TaskMaxDelay { private set; get; }

        public void StartBehavior(int taskCount, int mindelay, int maxdelay)
        {
            TaskCount = taskCount;
            TaskMinDelay = mindelay;
            TaskMaxDelay = maxdelay;
            BehaviorThreadManager.CreateBehaviorThread(listBox, RelativeFilePath, TaskCount);
            BehaviorThreadManager.Start(RelativeFilePath, TaskMinDelay, TaskMaxDelay);
        }
        public BehaviorTreeViewDock(NodeTag node)
        {
            InitializeComponent();
            this.TabPageContextMenuStrip = this.contextMenu;
            this._rootNode = node;
            __instances.Add(this);
            if (File.Exists(node.Filename))
            {
                if (Path.GetExtension(node.Filename) == ".xml")
                {
                    int rootPathLen = behaviac.Workspace.Instance.FilePath.Length;
                    RelativeFilePath = node.Filename.Substring(rootPathLen, node.Filename.Length - rootPathLen - 4);
                    if (RelativeFilePath.Contains('\\'))
                    {
                        RelativeFilePath = RelativeFilePath.Remove(0, 1);
                    }

                }
                this.Text =node.ShowText;
                this.textBox1.Text = File.ReadAllText(node.Filename);
            }
            else
            {
                Close();
            }
        }
        private static List<BehaviorTreeViewDock> __instances = new List<BehaviorTreeViewDock>();
        internal static IList<BehaviorTreeViewDock> Instances
        {
            get
            {
                return __instances.AsReadOnly();
            }
        }
        private static BehaviorTreeViewDock __lastFocusedInstance = null;
        internal static BehaviorTreeViewDock LastFocused
        {
            get
            {
                return __lastFocusedInstance;
            }
        }

        internal static BehaviorTreeViewDock GetBehaviorTreeViewDock(NodeTag node)
        {
            foreach (BehaviorTreeViewDock dock in __instances)
            {
                if (dock.RootNode == node)
                {
                    return dock;
                }
            }

            return null;
        }
        internal static void CloseAll()
        {
            try
            {
                BehaviorTreeViewDock[] behaviorTreeViewDocks = __instances.ToArray();

                foreach (BehaviorTreeViewDock dock in behaviorTreeViewDocks)
                {
                    dock.Close();
                }
            }
            catch
            {
            }

            __instances.Clear();
            __lastFocusedInstance = null;
        }

        internal static void CloseBehaviorTreeViewDock(NodeTag node)
        {
            try
            {
                foreach (BehaviorTreeViewDock dock in __instances)
                {
                    if (dock.RootNode == node)
                    {
                        dock.Hide();
                        dock.Close();

                        __instances.Remove(dock);

                        break;
                    }
                }
            }
            catch
            {
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            BehaviorThreadManager.End(RelativeFilePath);
            if (__lastFocusedInstance == this)
            {
                __lastFocusedInstance = null;
            }

            __instances.Remove(this);
            base.OnClosed(e);
            MainWindow.Instance.UpdateAssociatedWindows();
        }
        private NodeTag _rootNode;
        public NodeTag RootNode
        {
            get { return _rootNode; }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeAllButThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BehaviorTreeViewDock[] behaviorTreeViewDocks = __instances.ToArray();

            foreach (BehaviorTreeViewDock dock in behaviorTreeViewDocks)
            {
                if (dock != this)
                {
                    dock.Hide();
                    dock.Close();

                    __instances.Remove(dock);
                }
            }
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsFloat = true;
        }

        private void BehaviorTreeViewDock_Shown(object sender, EventArgs e)
        {

        }
        static DateTime _startTime;
        static Timer t = new Timer();

        static BehaviorTreeViewDock()
        {
            //Workspace.Instance.UseIntValue = true;
            Workspace.Instance.FrameSinceStartup=0;
            _startTime = DateTime.Now;
            Workspace.Instance.TimeSinceStartup = _startTime.Ticks/ 10000000.0;
            t.Interval = 50;
            t.Tick += Tick;
            t.Start();
        }

        private static void Tick(object sender, EventArgs e)
        {
            BehaviorThreadManager.Update();
            Workspace.Instance.IntValueSinceStartup = (long)(DateTime.Now - _startTime).TotalMilliseconds;
            Workspace.Instance.TimeSinceStartup = DateTime.Now.Ticks/ 10000000.0;
            ++Workspace.Instance.FrameSinceStartup;
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void BehaviorTreeViewDock_Load(object sender, EventArgs e)
        {
        }

        private void InfoViewer_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow.Instance.ShowAgentViewer(RelativeFilePath);
        }

        private void InfoContextMenu_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
