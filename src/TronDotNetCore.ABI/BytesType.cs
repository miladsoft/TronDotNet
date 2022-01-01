using TronDotNetCore.ABI.Decoders;
using TronDotNetCore.ABI.Encoders;

namespace TronDotNetCore.ABI
{
    public class BytesType : ABIType
    {
        public BytesType() : base("bytes")
        {
            Decoder = new BytesTypeDecoder();
            Encoder = new BytesTypeEncoder();
        }

        public override int FixedSize => -1;
    }
}