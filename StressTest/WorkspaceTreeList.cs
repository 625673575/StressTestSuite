using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StressTest
{
    public partial class WorkspaceTreeList : UserControl
    {

        private string _behaviorFolder = string.Empty;
        public const string TEST_EXTENSION = "xml";


        public WorkspaceTreeList()
        {
            InitializeComponent();
        }
        public void InitWorkSpace(string path)
        {
            _behaviorFolder = path;
            BuildWorkspaceList(treeView.Nodes, _behaviorFolder);
        }
        private void BuildWorkspaceList(TreeNodeCollection treeList, string folder)
        {
            // search all subfolders of the current folder
            string[] subfolders = Directory.GetDirectories(folder);
            treeList.Clear();
            foreach (string subfolder in subfolders)
            {
                string lastFolder = Path.GetFileNameWithoutExtension(subfolder);

                // we skip hidden and system folders
                if ((File.GetAttributes(subfolder) & (FileAttributes.Hidden | FileAttributes.System)) != 0)
                {
                    continue;
                }

                // create a group node for the the current folder
                string nodeLabel = new DirectoryInfo(subfolder).Name;
                TreeNode groupNode = new TreeNode(nodeLabel, (int)NodeIcon.FolderOpen, (int)NodeIcon.FolderClosed);
                groupNode.Tag = new NodeTag(NodeTagType.BehaviorFolder, null, subfolder, groupNode.Text);
                treeList.Add(groupNode);

                BuildWorkspaceList(groupNode.Nodes, subfolder);
            }

            // search the files of the current folder
            string[] foundFiles = Directory.GetFiles(folder, "*." + TEST_EXTENSION, SearchOption.TopDirectoryOnly);

            foreach (string file in foundFiles)
            {
                // we skip hidden and system files
                if ((File.GetAttributes(file) & (FileAttributes.Hidden | FileAttributes.System)) != 0)
                {
                    continue;
                }

                // create a tree node for the file
                string nodeLabel = Path.GetFileNameWithoutExtension(file);
                TreeNode behaviorNode = new TreeNode(nodeLabel, (int)NodeIcon.Behavior, (int)NodeIcon.Behavior);
                string o;
                if (Plugin.AliasName.TryGetValue(behaviorNode.Text, out o) && !string.IsNullOrWhiteSpace(o))
                {
                    behaviorNode.Text = o;
                }

                behaviorNode.Tag = new NodeTag(NodeTagType.Behavior, typeof(int), file, behaviorNode.Text);

                treeList.Add(behaviorNode);
            }
        }

        internal void ReBuildWorkspaceList()
        {
            try
            {
                // check if we have a valid folder
                if (string.IsNullOrEmpty(_behaviorFolder))
                {
                    return;
                }

                // create the folder if it does not exist
                if (!Directory.Exists(_behaviorFolder))
                {
                    Directory.CreateDirectory(_behaviorFolder);
                }
                Plugin.LoadAlias();
                // build the behavior list
                BuildWorkspaceList(treeView.Nodes, _behaviorFolder);
            }
            catch { }
        }
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // check if the new label is valid and did change
            if (e.Label == null || e.Label == e.Node.Text || e.Label.Length < 1)
            {
                e.CancelEdit = true;
                return;
            }

            NodeTag nodetag = (NodeTag)e.Node.Tag;
            BehaviorRenamed(e.Node);

        }
        private void treeView_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            NodeTag nodetag = (NodeTag)e.Node.Tag;

            if (string.IsNullOrEmpty(nodetag.Filename) ||
                (nodetag.Type == NodeTagType.Behavior) &&
                !Path.IsPathRooted(nodetag.Filename))
            {
                e.CancelEdit = true;
            }
        }

        private void treeView_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void treeView_DragOver(object sender, DragEventArgs e)
        {

        }

        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }

        private void treeView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NodeTag tag = (NodeTag)e.Node.Tag;
            if (tag.Type == NodeTagType.Behavior)
                OpenBehavior(e.Node, true);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NodeTag tag = (NodeTag)treeView.SelectedNode.Tag;
            Console.WriteLine(tag.Filename);
        }
        public delegate void BehaviorRenamedEventDelegate(TreeNode node);

        public event BehaviorRenamedEventDelegate BehaviorRenamed;


        public delegate BehaviorTreeViewDock ShowBehaviorEventDelegate(NodeTag node, int taskCount, int mindelay, int maxdelay);

        /// <summary>
        /// This event is triggered when double-clicking a behavior in the node explorer.
        /// </summary>
        public event ShowBehaviorEventDelegate ShowBehavior;
        public void OpenBehavior(TreeNode treenode, bool bShow)
        {
            if (treenode == null)
            {
                return;
            }
            BehaviorTreeViewDock dock = BehaviorTreeViewDock.GetBehaviorTreeViewDock((NodeTag)treenode.Tag);
            if (dock != null)
            {
                dock.Focus();
                return;
            }
            TaskSetting setting = new TaskSetting();
            if (setting.ShowDialog() == DialogResult.OK)
            {
                ShowBehavior((NodeTag)treenode.Tag, setting.TaskCount, setting.TaskMinDelay, setting.TaskMaxDelay);
            }
        }

        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView.SelectedNode != null)
            {
                treeView.SelectedNode.BeginEdit();
            }
        }

        private void toolStripButtonRefreshWorkspace_Click(object sender, EventArgs e)
        {
            ReBuildWorkspaceList();
        }

        private void toolStripButtonRenameList_Click(object sender, EventArgs e)
        {
            Plugin.OpenAliasFile();
        }
    }
}
