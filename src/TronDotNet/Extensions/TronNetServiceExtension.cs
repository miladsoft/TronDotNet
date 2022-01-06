using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace TronDotNet
{
    public static class TronDotNetServiceExtension
    {
        //public static StowayNet.IStowayNetBuilder AddTronDotNet(StowayNet.IStowayNetBuilder builder, Action<TronDotNetOptions> setupAction)
        //{
        //    builder.Services.AddTronDotNet(setupAction);

        //    return builder;
        //}

        public static IServiceCollection AddTronDotNet(this IServiceCollection services, Action<TronDotNetOptions> setupAction)
        {
            var options = new TronDotNetOptions();

            setupAction(options);

            services.AddTransient<ITransactionClient, TransactionClient>();
            services.AddTransient<IGrpcChannelClient, GrpcChannelClient>();
            services.AddTransient<ITronClient, TronClient>();
            services.AddTransient<IWalletClient, WalletClient>();
            services.AddSingleton<Contracts.IContractClientFactory, Contracts.ContractClientFactory>();
            services.AddTransient<Contracts.TRC20ContractClient>();
            services.Configure(setupAction);

            return services;
        }
    }
}
