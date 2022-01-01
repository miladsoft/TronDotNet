using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNetCore.Accounts;
using TronDotNetCore.Protocol;

namespace TronDotNetCore
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
