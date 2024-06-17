using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System;
using System.Threading.Tasks;
using TronDotNet;
using TronDotNet.Contracts;
using WebApplication_Host.Models;

namespace WebApplication_Host.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWalletClient _wallet;
        private readonly IContractClientFactory _contract;

        public HomeController(ILogger<HomeController> logger, IWalletClient wallet, IContractClientFactory contract)
        {
            _logger = logger;
            _wallet = wallet;
            _contract = contract;
        }

        public async Task<IActionResult> Index()
        {
            var key = TronECKey.GenerateKey(TronNetwork.MainNet);

            var address = key.GetPublicAddress();
            var privatekey = key.GetPrivateKey();
            var publickey = key.GetPublicAddress();

            ViewData["address"] = address;
            ViewData["privatekey"] = privatekey;
            ViewData["publickey"] = publickey;

            var account = _wallet.GetAccount(privatekey);
            var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
            var contractClient = _contract.CreateClient(ContractProtocol.TRC20);
            var balance = await contractClient.BalanceOfAsync(contractAddress, account);

            ViewData["balance"] = balance;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GenerateAddress()
        {
            try
            {
                var key = TronECKey.GenerateKey(TronNetwork.MainNet);
                var address = key.GetPublicAddress();
                var privatekey = key.GetPrivateKey();
                var publickey = key.GetPublicAddress();

                var account = _wallet.GetAccount(privatekey);
                var contractAddress = "TR7NHqjeKQxGTCi8q8ZY4pL8otSzgjLj6t";
                var contractClient = _contract.CreateClient(ContractProtocol.TRC20);
                var balance = await contractClient.BalanceOfAsync(contractAddress, account);

                return Json(new { success = true, address, privatekey, publickey, balance });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating address and checking balance.");
                return Json(new { success = false });
            }
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
