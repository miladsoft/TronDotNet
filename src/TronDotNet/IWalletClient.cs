using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNet.Accounts;
using TronDotNet.Protocol;

namespace TronDotNet
{
    public interface IWalletClient
    {
        Wallet.WalletClient GetProtocol();
        WalletSolidity.WalletSolidityClient GetSolidityProtocol();
        ITronAccount GenerateAccount();
        ITronAccount GetAccount(string privateKey);
        ByteString ParseAddress(string address);

        Metadata GetHeaders();
    }
}
