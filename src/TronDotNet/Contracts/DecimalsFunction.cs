using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TronDotNet.ABI.FunctionEncoding.Attributes;

namespace TronDotNet.Contracts
{
    [Function("decimals", "uint8")]
    public class DecimalsFunction : FunctionMessage
    {
    }
}
