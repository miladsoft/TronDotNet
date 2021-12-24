using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace TronDotNetCore
{
    public static class TronDotNetCoreServiceExtension
    {
        //public static StowayNet.IStowayNetBuilder AddTronDotNetCore(StowayNet.IStowayNetBuilder builder, Action<TronDotNetCoreOptions> setupAction)
        //{
        //    builder.Services.AddTronDotNetCore(setupAction);

        //    return builder;
        //}

        public static IServiceCollection AddTronDotNetCore(this IServiceCollection services, Action<TronDotNetCoreOptions> setupAction)
        {
            var options = new TronDotNetCoreOptions();

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
