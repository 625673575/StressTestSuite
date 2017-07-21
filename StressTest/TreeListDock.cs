using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressTest
{
    public partial class TreeListDock :  WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public const string DEFAULT_WORKSPACE_PATH = "../../exported";
        public TreeListDock()
        {
            InitializeComponent();
            this.TabText = this.Text;

        }
        public WorkspaceTreeList workspaceList
        {
            get
            {
                return workspaceTreeList1;
            }
        }

        private void nodeTreeList_Load(object sender, EventArgs e)
        {

        }

        private void TreeListDock_Load(object sender, EventArgs e)
        {
            workspaceList.InitWorkSpace(DEFAULT_WORKSPACE_PATH);
        }
    }
}
