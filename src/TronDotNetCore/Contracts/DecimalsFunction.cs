using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNetCore.ABI.FunctionEncoding.Attributes;

namespace TronDotNetCore.Contracts
{
    [Function("decimals", "uint8")]
    public class DecimalsFunction : FunctionMessage
    {
    }
}
