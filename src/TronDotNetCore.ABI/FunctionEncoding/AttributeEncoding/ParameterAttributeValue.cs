using System.Reflection;
using TronDotNetCore.ABI.FunctionEncoding.Attributes;

namespace TronDotNetCore.ABI.FunctionEncoding.AttributeEncoding
{
    public class ParameterAttributeValue
    {
        public ParameterAttribute ParameterAttribute { get; set; }
        public object Value { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
    }
}