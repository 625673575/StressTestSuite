using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace StressTest
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
    public class ShowValueAttribute : Attribute
    {
        public string Format
        {
            get
            {
                return _format;
            }
        }
        private string _format;
        public ShowValueAttribute(string format)
        {
            _format = format;
        }
    }
    [AttributeUsage(AttributeTargets.Method)]
    public class OperationAttribute : Attribute
    {
        public string OperationName { private set; get; }
        public string[] ParamLabels { private set; get; }
        public object[] DefaultValues { private set; get; }
        
        public OperationAttribute(string name, string[] param,params object[]  defaultValue)
        {
            ParamLabels = param;
            OperationName = name;
            DefaultValues = defaultValue;
        }
    }
    public class OperationStruct
    {
        public string OperationName;
        public string OperationMethodName { get { return Method.Name; } }
        public MethodInfo Method;
        public string[] ParamsLabels;
        public object[] DefaultValues;
        public OperationStruct(string name, string[] paramLabels,object[] defaultValues, MethodInfo methodInfo)
        {
            OperationName = name;
            ParamsLabels = paramLabels;
            DefaultValues = defaultValues;
            Method = methodInfo;
        }
        public override string ToString()
        {
            return OperationName;
        }
    }

    public class ShowValuePairStruct
    {
        public List<string> Format { get; private set; }
        public List<string> Values { get; private set; }
        public int Count
        {
            get { return Format.Count; }
        }
        public ShowValuePairStruct()
        {
            Format = new List<string>();
            Values = new List<string>();
        }
        public void Add(string format, object values)
        {
            Format.Add(format);
            Values.Add(values.ToString());
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < Count; ++i)
            {
                sb.AppendFormat(Format[i], Values[i]);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
