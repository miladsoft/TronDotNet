using TronDotNet.ABI.Decoders;
using TronDotNet.ABI.Encoders;

namespace TronDotNet.ABI
{
    public class StringType : ABIType
    {
        public StringType() : base("string")
        {
            Decoder = new StringTypeDecoder();
            Encoder = new StringTypeEncoder();
        }

        public override int FixedSize => -1;
    }
}