using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronDotNet
{
    public static class ArrayExtension
    {
        public static T[] SubArray<T>(this T[] array, int offset, int length)
        {
            return array.Skip(offset)
                        .Take(length)
                        .ToArray();
        }
    }
}
