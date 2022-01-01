using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TronDotNetCore;
using TronDotNetCore.Contracts;
using WebApplication_Host.Models;

namespace WebApplication_Host.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITronClient _tron;
        private readonly IWalletClient _wallet;
        private readonly IContractClientFactory _contract;
        public HomeController(ILogger<HomeController> logger, IWalletClient wallet, IContractClientFactory contract, ITronClient tron)
        {
            _logger = logger;
            _wallet = wallet;
            _contract = contract;
            _tron = tron;
        }

        public IActionResult Index()
        {
            var key = TronECKey.GenerateKey(TronNetwork.MainNet);

            var address = key.GetPublicAddress();

            var privatekey = key.GetPrivateKey();

            var publickey = key.GetPublicAddress();
            ViewData["address"] = address;
            ViewData["privatekey"] = privatekey;
            ViewData["publickey"] = publickey;

            #region If you want to get the balance of trc-20 tokens, write your code below
            var account = _wallet.GetAccount(privatekey);
            //USDT TOKEN
            var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
            var contractClient = _contract.CreateClient(ContractProtocol.TRC20);
            //USDT Balance
            var balance = contractClient.BalanceOfAsync(contractAddress, account).Result;

            ViewData["balance"] = balance;
            #endregion


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
