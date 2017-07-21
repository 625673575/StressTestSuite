using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StressTest
{

    public enum NodeIcon { FolderOpen, FolderClosed, Behavior };

    public enum NodeTagType { Behavior, BehaviorFolder };
    public class Plugin
    {
        public const string BehaviorExported = "../../exported";
        public const string TreeViewAlias = "../../alias.txt";
        public readonly static Dictionary<string, string> AliasName = new Dictionary<string, string>();
        public static void LoadAlias()
        {
            AliasName.Clear();
            CheckFileExist();
            string[] x = File.ReadAllLines(TreeViewAlias);
            foreach (string ax in x)
            {
                string[] l = ax.Split('=');
                if (l.Length == 2)
                {
                    AliasName.Add(l[0], l[1]);
                }
            }
        }
        public static void CheckFileExist()
        {
            if (!File.Exists(TreeViewAlias))
            {
                File.Create(TreeViewAlias);
            }
        }
        public static void OpenAliasFile()
        {
            CheckFileExist();
            System.Diagnostics.Process.Start(Path.GetFullPath(TreeViewAlias));
        }
        public static string ListToString(IEnumerable<object> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var s in list)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// The NodeTag is used to identify nodes in the explorer. Each TreeViewItem.Tag is a NodeTag.
    /// It is only used for displaying the nodes in the explorer and to handle drag & drop actions.
    /// </summary>
    public class NodeTag
    {
        protected NodeTagType _type;

        /// <summary>
        /// The type of the node in the node explorer.
        /// </summary>
        public NodeTagType Type
        {
            get
            {
                return _type;
            }
        }

        protected Type _nodetype;

        /// <summary>
        /// The type of the node which will be created in the graph.
        /// </summary>
        public Type NodeType
        {
            get
            {
                return _nodetype;
            }
        }

        protected string _filename;
        protected string _showText;
        /// <summary>
        /// The filename of the behaviour which will be loaded when we double-click it.
        /// </summary>
        public string Filename
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
            }
        }
        public string ShowText
        {
            get
            {
                return _showText;
            }
            set
            {
                _showText = value;
            }
        }


        /// <summary>
        /// Creates a new NodeTag and an instance of the node for the defaults.
        /// </summary>
        /// <param name="type">The type of the node in the node explorer.</param>
        /// <param name="nodetype">The type of the node which will be added to the behaviour tree.</param>
        /// <param name="filename">The filename of the behaviour we want to load. Use string.Empty if the node is not a behaviour.</param>
        public NodeTag(NodeTagType type, Type nodetype, string filename, string showName)
        {
            _type = type;
            _nodetype = nodetype;

            Filename = filename;
            ShowText = showName;
        }
    }

}
