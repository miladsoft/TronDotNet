using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNet.Contracts;

namespace TronDotNet
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
