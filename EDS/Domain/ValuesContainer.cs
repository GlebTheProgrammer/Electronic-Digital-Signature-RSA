using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EDS.Domain
{
    internal static class ValuesContainer
    {
        public static BigInteger p { get; set; } = 0;
        public static BigInteger q { get; set; } = 0;
        public static BigInteger r { get; set; } = 0;
        public static BigInteger Fr { get; set; } = 0;
        public static BigInteger e { get; set; } = 0;
        public static BigInteger d { get; set; } = 0;
        public static BigInteger MssgHash { get; set; } = 0;
        public static BigInteger EDS { get; set; } = 0;
    }
}
