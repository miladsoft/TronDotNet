using TronDotNetCore.ABI.Decoders;
using TronDotNetCore.ABI.Encoders;

namespace TronDotNetCore.ABI
{
    public class BoolType : ABIType
    {
        public BoolType() : base("bool")
        {
            Decoder = new BoolTypeDecoder();
            Encoder = new BoolTypeEncoder();
        }
    }
}