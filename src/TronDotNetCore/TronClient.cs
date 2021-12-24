using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNetCore.Contracts;
using TronDotNetCore.Protocol;

namespace TronDotNetCore
{
    class TronClient : ITronClient
    {
        private readonly ILogger<TronClient> _logger;
        private readonly IOptions<TronDotNetCoreOptions> _options;
        private readonly IGrpcChannelClient _channelClient;
        private readonly IWalletClient _walletClient;
        private readonly ITransactionClient _transactionClient;

        public TronNetwork TronNetwork => _options.Value.Network;

        public TronClient(ILogger<TronClient> logger, IOptions<TronDotNetCoreOptions> options, IGrpcChannelClient channelClient, IWalletClient walletClient, ITransactionClient transactionClient)
        {
            _logger = logger;
            _options = options;
            _channelClient = channelClient;
            _walletClient = walletClient;
            _transactionClient = transactionClient;
        }
        public IGrpcChannelClient GetChannel()
        {
            return _channelClient; 
        }
        public IWalletClient GetWallet()
        {
            return _walletClient;
        }

        public ITransactionClient GetTransaction()
        {
            return _transactionClient;
        }

        public IContractClient GetContract()
        {
            return null;
        }
    }
}
