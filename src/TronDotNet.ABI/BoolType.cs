using TronDotNet.ABI.Decoders;
using TronDotNet.ABI.Encoders;

namespace TronDotNet.ABI
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