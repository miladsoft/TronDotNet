using System;
using TronDotNet.ABI.Model;

namespace TronDotNet.ABI.FunctionEncoding
{
    public class ParameterOutput
    {
        public Parameter Parameter { get; set; }
        public int DataIndexStart { get; set; }
        public object Result { get; set; }
        
    }
}