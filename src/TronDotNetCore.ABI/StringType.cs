using TronDotNetCore.ABI.Decoders;
using TronDotNetCore.ABI.Encoders;

namespace TronDotNetCore.ABI
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