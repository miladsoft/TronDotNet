using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNetCore.Contracts;

namespace TronDotNetCore
{
    public interface ITronClient
    {
        TronNetwork TronNetwork { get; }
        IGrpcChannelClient GetChannel();
        IWalletClient GetWallet();
        ITransactionClient GetTransaction();
        IContractClient GetContract();
    }
}
