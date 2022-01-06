using System.Collections.Generic;
using System.Reflection;

namespace TronDotNet.ABI.FunctionEncoding.AttributeEncoding
{
    public class ParameterOutputProperty : ParameterOutput
    {
        public PropertyInfo PropertyInfo { get; set; }

        public List<ParameterOutputProperty> ChildrenProperties { get; set; }
    }
}