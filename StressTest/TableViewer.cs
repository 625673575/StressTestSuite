using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressTest
{
    public partial class TableViewer : Form
    {
        public BehaviorGroup Group;
        public TableViewer()
        {
            InitializeComponent();
        }
        public void SetData(BehaviorGroup group)
        {
            Group = group;
        }
        private void TableViewer_Load(object sender, EventArgs e)
        {
            AddColumn(Group[0]);
            for (int i = 0; i < Group.Count; i++)
            {
                int index = dataGridView.Rows.Add();
                GetRowData(Group[i], i);

            }
        }
        private object GetRowData(BehaviorThread thread, int index)
        {
            int i = 0;
            if (thread == null || thread.Agent == null)
                return null;
            dataGridView.Rows[index].Cells[i].Value = thread.Agent.GetName();
            ++i;
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
                        dataGridView.Rows[index].Cells[i].Value = info.Invoke(agent, new object[] { });
                        ++i;
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
                        dataGridView.Rows[index].Cells[i].Value = info.GetValue(agent);
                        ++i;
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
                        dataGridView.Rows[index].Cells[i].Value = info.GetValue(agent);
                        ++i;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// 通过标签提取有用的信息用于显示
        /// </summary>
        /// <param name="thread"></param>
        private void AddColumn(BehaviorThread thread)
        {
            if (thread == null || thread.Agent == null)
                return;
            dataGridView.Columns.Add(thread.BTName, "实例名称");

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
                        dataGridView.Columns.Add(att.Format, att.Format);
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
                        dataGridView.Columns.Add(att.Format, att.Format);
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
                        dataGridView.Columns.Add(att.Format, att.Format);
                    }
                }
            }
        }
        public struct Element
        {
            public int Count;
            public List<int> Indexs;
            public Element(int i)
            {
                Count = 1;
                Indexs = new List<int>();
                Indexs.Add(i);
            }
            public void AddElement(int index)
            {
                Indexs.Add(index);
                ++Count;
            }
        }
        public bool invalidCheckDiffType(object value)
        {
            var t = value.GetType();
            if (t.IsArray || t.IsClass || t.IsGenericType)
                return true;
            return false;
        }
        public static readonly Color[] BackColorTable = new Color[] { Color.White, Color.Gold, Color.Gray, Color.Aquamarine, Color.Azure, Color.GreenYellow, Color.Indigo, Color.Lavender, Color.LightBlue, Color.MediumOrchid, Color.MediumSeaGreen, Color.Olive, Color.PaleVioletRed, Color.SeaGreen, Color.Tomato, Color.Tan };
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (dataGridView.ColumnCount < 1 || dataGridView.RowCount < 1)
                return;

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                if (invalidCheckDiffType(dataGridView[i, 0].Value))
                    continue;
                Dictionary<object, Element> kv = new Dictionary<object, Element>();
                for (int j = 0; j < dataGridView.RowCount - 1; j++)
                {
                    var k = dataGridView[i, j].Value;
                    if (kv.ContainsKey(k))
                    {
                        kv[k].AddElement(j);
                    }
                    else
                    {
                        kv.Add(k, new Element(j));
                    }
                }

                if (kv.Count > 1)
                {
                    for (int x = 0; x < kv.Count; x++)
                    {
                        var ele = kv.Values.ToList()[x];
                        foreach (var iindex in ele.Indexs)
                        {
                            var colIndex = x % BackColorTable.Length;
                            dataGridView[i, iindex].Style.BackColor = BackColorTable[colIndex];
                        }
                    }
                }
            }
        }
    }
}
