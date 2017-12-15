using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class _4AdventCoins
    {
        public int GetHashNumber(string secretKey, int numOfZeroes, int startPoint = 1)
        {
            var counter = startPoint;
            var prefix = new string('0', numOfZeroes);

            while (true)
            {
                var key = secretKey + counter;
                var md5 = MD5.Create();
                var hexString = ByteArrayToString(md5.ComputeHash(Encoding.UTF8.GetBytes(key)));

                if (hexString.StartsWith(prefix))
                {
                    return counter;
                }

                counter++;
            }
        }

        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
