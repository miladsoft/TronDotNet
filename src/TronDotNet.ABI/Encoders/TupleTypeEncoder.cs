using System;
using TronDotNet.ABI.Encoders;
using TronDotNet.ABI.FunctionEncoding;
using TronDotNet.ABI.Model;

namespace TronDotNet.ABI
{
    public class TupleTypeEncoder : ITypeEncoder
    {
        private readonly ParametersEncoder parametersEncoder;

        public TupleTypeEncoder()
        {
            parametersEncoder = new ParametersEncoder();
        }

        public Parameter[] Components { get; set; }

        public byte[] Encode(object value)
        {
            if (!(value == null || value is object[]))
                return parametersEncoder.EncodeParametersFromTypeAttributes(value.GetType(), value);

            var input = value as object[];
            return parametersEncoder.EncodeParameters(Components, input);
        }

        public byte[] EncodePacked(object value)
        {
            throw new NotImplementedException();
        }
    }
}