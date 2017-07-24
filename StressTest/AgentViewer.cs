using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace StressTest
{
    public partial class AgentViewer : Form
    {
        public AgentViewer()
        {
            InitializeComponent();
            numericUpDown1_ValueChanged(null, null);
        }
        public BehaviorGroup SelectGroup
        {
            private set; get;
        }
        public BehaviorThread SelectThread
        {
            private set; get;
        }
        public RobotAgent CurrentAgent
        {
            get { return SelectThread.Agent; }
        }
        public void BuildAgentGroupView()
        {
            listBoxAgentGroup.Items.Clear();
            listBoxAgentGroup.Items.AddRange(BehaviorThreadManager.ThreadGroups.Keys.ToArray());
            listBoxAgentThread.Items.Clear();
            listBox_ShowValue.Items.Clear();
            flowLayoutPanel1.Controls.Clear();
            operation = null;
            LabelInputCollection.Clear();
        }
        /// <summary>
        /// 点击某个类型的Agent之后刷新所有其他显示的物件
        /// </summary>
        /// <param name="name"></param>
        private void BuildAgentThreadViewer(string name)
        {
            BehaviorGroup group;
            if (BehaviorThreadManager.ThreadGroups.TryGetValue(name, out group))
            {
                listBoxAgentThread.Items.Clear();
                foreach (var t in group.BehaviorThreads)
                {
                   listBoxAgentThread.Items.Add(t.Agent.GetName());
                }
            }
            SelectGroup = group;
        }

        /// <summary>
        /// 通过标签提取有用的信息用于显示
        /// </summary>
        /// <param name="thread"></param>
        private void ReflectAgentValue(BehaviorThread thread)
        {
            if (thread == null || thread.Agent == null)
                return;

            listBox_ShowValue.Items.Clear();
            textBox_BTName.Text = thread.BTName;
            checkBox_IsThreadStart.Checked = thread.Agent.IsLogin;

            RobotAgent agent = thread.Agent;
            //if (agent.Player == null || agent.Player.Property == null)
            //    return;
            //方法Attribute提取
            MethodInfo[] methodInfos = agent.GetType().GetMethods();
            foreach (var info in methodInfos)
            {
                object[] attributesOnMethod = info.GetCustomAttributes(false);
                foreach (var am in attributesOnMethod)
                {
                    if (am is ShowValueAttribute)
                    {
                        ShowValueAttribute att = am as ShowValueAttribute;
                        string retValue = info.Invoke(agent, new object[] { }).ToString();
                        listBox_ShowValue.Items.Add(string.Format(att.Format, retValue));
                    }
                }
            }
            //属性Attribute提取
            PropertyInfo[] propertyInfos = agent.GetType().GetProperties();
            foreach (var info in propertyInfos)
            {
                object[] attributesOnMethod = info.GetCustomAttributes(false);
                foreach (var am in attributesOnMethod)
                {
                    if (am is ShowValueAttribute)
                    {
                        ShowValueAttribute att = am as ShowValueAttribute;
                        string retValue = info.GetValue(agent).ToString();
                        listBox_ShowValue.Items.Add(string.Format(att.Format, retValue));
                    }
                }
            }
            //变量Attribute提取
            FieldInfo[] fieldInfos = agent.GetType().GetFields();
            foreach (var info in fieldInfos)
            {
                object[] attributesOnMethod = info.GetCustomAttributes(false);
                foreach (var am in attributesOnMethod)
                {
                    if (am is ShowValueAttribute)
                    {
                        ShowValueAttribute att = am as ShowValueAttribute;
                        string retValue = info.GetValue(agent).ToString();
                        listBox_ShowValue.Items.Add(string.Format(att.Format, retValue));
                    }
                }
            }
        }

        private void ReflectAgentOperation(BehaviorThread thread)
        {
            comboBox_Operation.Items.Clear();
            RobotAgent agent = thread.Agent;
            MethodInfo[] methodInfos = agent.GetType().GetMethods();
            foreach (var info in methodInfos)
            {
                object[] attributesOnMethod = info.GetCustomAttributes(false);
                foreach (var am in attributesOnMethod)
                {
                    if (am is OperationAttribute)
                    {
                        OperationAttribute att = am as OperationAttribute;
                        string comboxText = string.Format("({0})    {1}", info.ReturnType.Name, att.OperationName);
                        OperationStruct operation = new OperationStruct(comboxText, att.ParamLabels, att.DefaultValues, info);

                        comboBox_Operation.Items.Add(operation);
                    }
                }
            }
        }

        private OperationStruct operation;
        private List<string> OperationMessageList = new List<string>();
        private List<LabelInput> LabelInputCollection = new List<LabelInput>();
        private void BuildOperationView(OperationStruct operation)
        {
            flowLayoutPanel1.Controls.Clear();
            LabelInputCollection.Clear();
            groupBox2.Text = operation.OperationMethodName;
            int paramLabelsCount = operation.ParamsLabels.Length;
            ParameterInfo[] paramInfos = operation.Method.GetParameters();
            if (paramLabelsCount != paramInfos.Length)
                throw new Exception("函数" + operation.OperationMethodName + "参数列表数目不匹配");
            for (int i = 0; i < paramLabelsCount; ++i)
            {
                string defaultInput = paramInfos[i].ParameterType.IsValueType ? "0" : null;
                if (operation.DefaultValues.Length > i)
                {
                    defaultInput = operation.DefaultValues[i].ToString();
                }
                LabelInput control = new LabelInput(operation.ParamsLabels[i], defaultInput);
                this.flowLayoutPanel1.Controls.Add(control);
                LabelInputCollection.Add(control);
                this.flowLayoutPanel1.ResumeLayout(false);
            }

        }
        public void SelectAgentGroup(string catalogy)
        {
            for (int i = 0; i < listBoxAgentGroup.Items.Count; ++i)
            {
                if (listBoxAgentGroup.Items[i].ToString() == catalogy)
                {
                    listBoxAgentGroup.SelectedIndex = i;
                }
            }
        }
        private void listBoxAgentGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string name = listBoxAgentGroup.SelectedItem.ToString();
            BuildAgentThreadViewer(name);
        }

        private void listBoxAgentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAgentGroup.SelectedIndex < 0)
                return;
            if (listBoxAgentThread.Items.Count > 0)
                listBoxAgentThread.SelectedIndex = 0;
            string name = listBoxAgentGroup.SelectedItem.ToString();
            BuildAgentThreadViewer(name);
        }

        private void AgentViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void listBoxAgentThread_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxAgentThread.SelectedIndex;
            if (index < 0)
                return;
            if (SelectGroup != null && SelectGroup.Count > index)
            {
                SelectThread = SelectGroup[index];
                ReflectAgentValue(SelectThread);
                ReflectAgentOperation(SelectThread);
            }
        }

        private void toolStripButtonRefreshAgentGroup_Click(object sender, EventArgs e)
        {
            BuildAgentGroupView();
        }

        private void AgentViewer_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                BuildAgentGroupView();
        }

        private void comboBox_Operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Operation.SelectedIndex < 0)
                return;
            operation = comboBox_Operation.SelectedItem as OperationStruct;
            if (operation != null)
            {
                BuildOperationView(operation);
            }
        }
        private void button_Operation_Click(object sender, EventArgs e)
        {
            OperationMessageList.Clear();
            if (operation == null || SelectGroup == null || SelectThread == null)
                return;
            try
            {
                List<object> parameters = new List<object>();
                ParameterInfo[] paramInfos = operation.Method.GetParameters();
                for (int i = 0; i < LabelInputCollection.Count; ++i)
                {
                    object x = null;
                    if (paramInfos[i].ParameterType.Equals(typeof(int)))
                    {
                        x = int.Parse(LabelInputCollection[i].Text);
                    }
                    else if (paramInfos[i].ParameterType.Equals(typeof(uint)))
                    {
                        x = uint.Parse(LabelInputCollection[i].Text);
                    }
                    else if (paramInfos[i].ParameterType.Equals(typeof(long)))
                    {
                        x = long.Parse(LabelInputCollection[i].Text);
                    }
                    else if (paramInfos[i].ParameterType.Equals(typeof(ulong)))
                    {
                        x = ulong.Parse(LabelInputCollection[i].Text);
                    }
                    else if (paramInfos[i].ParameterType.Equals(typeof(short)))
                    {
                        x = short.Parse(LabelInputCollection[i].Text);
                    }
                    else if (paramInfos[i].ParameterType.Equals(typeof(ushort)))
                    {
                        x = ushort.Parse(LabelInputCollection[i].Text);
                    }
                    else if (paramInfos[i].ParameterType.Equals(typeof(sbyte)))
                    {
                        x = sbyte.Parse(LabelInputCollection[i].Text);
                    }
                    else
                    {
                        x = LabelInputCollection[i].Text;
                    }
                    parameters.Add(x);
                }
                if (checkBox_ApplyAllAgent.Checked)
                {
                    int failCount = 0;
                    for (int i = 0; i < SelectGroup.Count; ++i)
                    {
                        if (SelectGroup[i].Agent != null && SelectGroup[i].IsStart)
                            InvokeOperationMethod(SelectGroup[i].Agent, operation.Method, parameters.ToArray());
                        else
                            ++failCount;
                    }
                    if (failCount > 0)
                    {
                        MessageBox.Show(string.Format("{0}个实例函数执行失败", failCount));
                    }
                }
                else
                {
                    InvokeOperationMethod(CurrentAgent, operation.Method, parameters.ToArray());
                }
                if (OperationMessageList.Count > 0)
                {
                    string content = Plugin.ListToString(OperationMessageList);
                    Form_Text text = new Form_Text(content);
                    text.ShowDialog();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void InvokeOperationMethod(RobotAgent obj, MethodInfo method, object[] parameters)
        {

            if (method.ReturnType.Equals(typeof(void)))
            {
                method.Invoke(obj, parameters.ToArray());
                OperationMessageList.Add(obj.GetName() + "执行" + method.Name + "成功");
                return;
            }
            if (method.ReturnType.IsArray)
            {
                StringBuilder sb = new StringBuilder("[");

                System.Array returnValue = method.Invoke(obj, parameters.ToArray()) as System.Array;

                foreach (object o in returnValue)
                {
                    sb.Append(o.ToString());
                    sb.Append(",");
                }

                sb.Remove(sb.Length - 1, 1);
                sb.Append("]");
                OperationMessageList.Add(obj.GetName() + "执行" + method.Name + "成功，返回值为:" + sb.ToString());
                return;
            }
            if (method.ReturnType.IsGenericType)
            {
                StringBuilder sb = new StringBuilder("[");

                System.Collections.ICollection returnValue = method.Invoke(obj, parameters.ToArray()) as System.Collections.ICollection;

                foreach (object o in returnValue)
                {
                    sb.Append(o.ToString());
                    sb.Append(",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append("]");
                OperationMessageList.Add(obj.GetName() + "执行" + method.Name + "成功，返回值为:" + sb.ToString());
            }
            else
            {
                object returnValue = method.Invoke(obj, parameters.ToArray());
                OperationMessageList.Add(obj.GetName() + "执行" + method.Name + "成功，返回值为:" + returnValue.ToString());
                return;
            }
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReflectAgentValue(SelectThread);
        }

        private void 复制信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_ShowValue.SelectedIndex < 0)
            {
                return;
            }
            string info = listBox_ShowValue.SelectedItem.ToString();
            Clipboard.SetText(info);
        }

        private void 复制全部信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var o in listBox_ShowValue.Items)
            {
                sb.AppendLine(o.ToString());
            }
            Clipboard.SetText(sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReflectAgentValue(SelectThread);
        }

        private void timer_autoRefreshReflection_Tick(object sender, EventArgs e)
        {
            if (!checkBox_autoRefreshReflection.Checked)
                return;
            ReflectAgentValue(SelectThread);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer_autoRefreshReflection.Interval = (int)(numericUpDown1.Value * 1000);
        }

        private void listBox_ShowValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_ShowValue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_ShowValue.SelectedIndex < 0)
                return;
            Form_Text textForm = new Form_Text(listBox_ShowValue.SelectedItem.ToString());
            textForm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TableViewer view = new TableViewer();
            view.SetData(SelectGroup);
            view.Show();
        }
    }
}
