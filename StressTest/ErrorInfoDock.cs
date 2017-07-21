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
    public partial class ErrorInfoDock : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private static ErrorInfoDock _dock = null;
        private static bool _shouldScroll = true;

        internal static void Inspect()
        {
            if (_dock == null)
            {
                _dock = new ErrorInfoDock();

                _dock.Show(MainWindow.Instance.DockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);

            }
            else
            {
                _dock.Show();
            }
        }

        internal static void CloseAll()
        {
            if (_dock != null)
            {
                _dock.Close();
            }
        }
        internal static void Clear()
        {
            if (_dock != null)
            {
                _dock.errorListBox.Items.Clear();
            }
        }
        internal static void WriteLineWithTime(string log)
        {
            string dt = DateTime.Now.ToString();
            string msg = string.Format("[{0}] {1}", dt, log);
            WriteLine(msg);
        }

        internal static void WriteLine(string log)
        {
            if (_dock != null && log != null)
            {
                _dock.errorListBox.BeginUpdate();

                string[] lines = log.Split('\n');

                foreach (string line in lines)
                {
                    _dock.errorListBox.Items.Add(line);
                }

                if (_shouldScroll)
                {
                    scrollToEnd();
                }

                _dock.errorListBox.EndUpdate();
            }
        }

        private static void scrollToEnd()
        {
            //_dock.errorListBox.SelectedIndex = _dock.errorListBox.Items.Count - 1;
            _dock.errorListBox.TopIndex = _dock.errorListBox.Items.Count - 1;
            _shouldScroll = true;
        }

        public ErrorInfoDock()
        {
            if (_dock == null)
            {
                _dock = this;
            }

            InitializeComponent();

            this.TabText = "Console";

            behaviac.Debug.OnLogEvent += FrameStatePool_AddLogHandler;
        }

        protected override void OnClosed(EventArgs e)
        {
            _dock = null;

            behaviac.Debug.OnLogEvent -= FrameStatePool_AddLogHandler;

            base.OnClosed(e);
        }

        private void FrameStatePool_AddLogHandler(string log)
        {
            errorListBox.Items.Add(log);

            if (_shouldScroll)
            {
                scrollToEnd();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (errorListBox.SelectedIndices.Count > 0)
            {
                string log = string.Empty;

                foreach (int index in errorListBox.SelectedIndices)
                {
                    log += errorListBox.Items[index];
                }

                if (!string.IsNullOrEmpty(log))
                {
                    Clipboard.SetText(log);
                }
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void errorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _shouldScroll = (errorListBox.SelectedIndex == errorListBox.Items.Count - 1);
        }

        private void errorListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                _shouldScroll = true;

            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                errorListBox.BeginUpdate();
                SelectionMode selectionMode = errorListBox.SelectionMode;
                errorListBox.SelectionMode = SelectionMode.MultiSimple;

                errorListBox.SelectedIndices.Clear();

                for (int i = 0; i < errorListBox.Items.Count; ++i)
                {
                    errorListBox.SelectedIndices.Add(i);
                }

                errorListBox.SelectionMode = selectionMode;
                errorListBox.EndUpdate();
            }
        }

        private void ErrorInfoDock_Load(object sender, EventArgs e)
        {

        }
    }
}
