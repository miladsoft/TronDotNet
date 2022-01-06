using System.Reflection;
using TronDotNet.ABI.FunctionEncoding.Attributes;

namespace TronDotNet.ABI.FunctionEncoding.AttributeEncoding
{
    public class ParameterAttributeValue
    {
        public ParameterAttribute ParameterAttribute { get; set; }
        public object Value { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
    }
}