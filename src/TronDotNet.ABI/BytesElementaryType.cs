using TronDotNet.ABI.Decoders;
using TronDotNet.ABI.Encoders;

namespace TronDotNet.ABI
{
    public class BytesElementaryType : ABIType
    {
        public BytesElementaryType(string name, int size) : base(name)
        {
            Decoder = new BytesElementaryTypeDecoder(size);
            Encoder = new BytesElementaryTypeEncoder(size);
        }
    }
}