using TronDotNet.ABI.Decoders;
using TronDotNet.ABI.Encoders;

namespace TronDotNet.ABI
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