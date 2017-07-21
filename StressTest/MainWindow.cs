using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace StressTest
{
    public partial class MainWindow : Form
    {
        private static MainWindow _instance;
        internal static MainWindow Instance
        {
            get
            {
                return _instance;
            }
        }
        internal WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel
        {
            get
            {
                return dockPanel;
            }
        }
        private ErrorInfoDock consoleDock;
        public ErrorInfoDock ConsoleDock { get { return consoleDock; } }

        static void StartNetwork()
        {
            //ViSerializer.Start();
            //ViSerializer<ViVector3>.AppendExec = ViVector3Serializer.Append;
            //ViSerializer<ViVector3>.ReadExec = ViVector3Serializer.Read;
            //ViSerializer<ViVector3>.ReadStringExec = ViVector3Serializer.Read;
            //ViSerializer<ViVector3>.AppendDictionaryStringExec = ViVector3Serializer.Append;
            //ViSerializer<ViVector3>.ReadDictionaryStringExec = ViVector3Serializer.Read;

            //GameDataManager.Instance.Start();
            //YXBXNormalDataEx.Start();
            //YXBXScript.Start();

        }
        static bool InitBehavic()
        {
            Console.WriteLine("InitBehavic");
            behaviac.Workspace.Instance.FilePath = Plugin.BehaviorExported;
            behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

            return true;
        }

        static void CleanupBehaviac()
        {
            behaviac.Workspace.Instance.Cleanup();
        }
        public static uint GetProcessCount()
        {
            string p = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcessesByName(p);
            return (uint)ps.Length;
        }
        public static uint ProcessID { private set; get; }
        public MainWindow()
        {
            InitializeComponent();
            _instance = this;
            TreeListDock btlDock = new TreeListDock();
            RegisterBehaviorTreeList(btlDock);
            btlDock.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);

            consoleDock = new ErrorInfoDock();
            consoleDock.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            Control.CheckForIllegalCrossThreadCalls = false;
            ProcessID = GetProcessCount();
            StressTest.MainWindow.Instance.Text += "_" + ProcessID;
            RobotAgent.IsShowLogMessage = showDebugToolStripMenuItem.Checked;
            Plugin.LoadAlias();
        }

        private TreeListDock workspaceTreeListDock = null;
        private WorkspaceTreeList workspaceTreeList = null;
        //private NodeTreeList nodeTreeList = null;
        private void RegisterBehaviorTreeList(TreeListDock dock)
        {
            workspaceTreeListDock = dock;
            workspaceTreeList = dock.workspaceList;
            RegisterDelegateHandlers();
        }

        private void RegisterDelegateHandlers()
        {
            workspaceTreeList.ShowBehavior -= behaviorTreeList_ShowBehavior;
            workspaceTreeList.ShowBehavior += behaviorTreeList_ShowBehavior;

            workspaceTreeList.BehaviorRenamed -= behaviorTreeList_BehaviorRenamed;
            workspaceTreeList.BehaviorRenamed += behaviorTreeList_BehaviorRenamed;
        }

        private void behaviorTreeList_BehaviorRenamed(TreeNode node)
        {
            NodeTag tag = (NodeTag)node.Tag;
            BehaviorTreeViewDock dock = BehaviorTreeViewDock.GetBehaviorTreeViewDock(tag);
            if (dock == null)
            {
                dock.TabText = node.Text;
            }
        }

        private void newWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ErrorInfoDock.WriteLineWithTime("Cao zuo");
            behaviac.Debug.Log("Cao Zuo");
            behaviac.Debug.LogError("Error");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dockPanel_ActiveContentChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 显示行为树
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private BehaviorTreeViewDock behaviorTreeList_ShowBehavior(NodeTag node, int taskCount, int mindelay, int maxdelay)
        {
            BehaviorTreeViewDock dock = BehaviorTreeViewDock.GetBehaviorTreeViewDock(node);
            if (dock == null)
            {
                dock = new BehaviorTreeViewDock(node);
                dock.Name = node.Filename;
                dock.Activated += new EventHandler(dock_Activated);
                dock.FormClosed += new FormClosedEventHandler(dock_FormClosed);
                dock.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);
                dock.ToolTipText = Path.GetFileNameWithoutExtension(node.Filename);
                dock.StartBehavior(taskCount, mindelay, maxdelay);
            }

            if (dock != null)
            {
                dock.Focus();
                // dock.MakeFocused();
            }
            return dock;
        }
        private void dock_Activated(object sender, EventArgs e)
        {
            BehaviorTreeViewDock dock = sender as BehaviorTreeViewDock;
            dock.Focus();
        }
        private void dock_FormClosed(object sender, FormClosedEventArgs e)
        {
            BehaviorTreeViewDock dock = sender as BehaviorTreeViewDock;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitBehavic();
            StartNetwork();
        }

        public void CloseBehavior(bool allBehaviors)
        {
            if (allBehaviors)
            {
                BehaviorTreeViewDock.CloseAll();

            }
            else if (BehaviorTreeViewDock.LastFocused != null)
            {
                BehaviorTreeViewDock.LastFocused.Close();
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (behaviac.Workspace.Instance.IsInited)
                behaviac.Workspace.Instance.Cleanup();
        }

        private void showDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDebugToolStripMenuItem.Checked = !showDebugToolStripMenuItem.Checked;
            RobotAgent.IsShowLogMessage = showDebugToolStripMenuItem.Checked;
        }

        private void forceLogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forceLogOutToolStripMenuItem.Checked = !forceLogOutToolStripMenuItem.Checked;
            RobotAgent.ForceLogout = showDebugToolStripMenuItem.Checked;
        }

        private void 多少个登录成功ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("有" + RobotAgent.GetLoginedUserCount() + "个玩家登录成功");
        }

        private void 多少个尝试过登录ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("有" + RobotAgent.GetNetAgentCount() + "个网络玩家尝试过登录");
        }

        AgentViewer _agentView;
        public AgentViewer AgentViewer
        {
            get
            {
                return _agentView;
            }
        }
        public void ShowAgentViewer()
        {
            if (_agentView == null)
                _agentView = new AgentViewer();
            if (!_agentView.Visible)
            {
                _agentView.Show();
            }
            else
            {
                _agentView.Focus();
            }
            _agentView.BuildAgentGroupView();
        }
        public void UpdateAssociatedWindows()
        {
            if (_agentView != null)
                _agentView.BuildAgentGroupView();
        }
        public void ShowAgentViewer(string catalogy)
        {
            ShowAgentViewer();
            _agentView.SelectAgentGroup(catalogy);
        }
        private void 查看活动AgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAgentViewer();
        }
    }
}
