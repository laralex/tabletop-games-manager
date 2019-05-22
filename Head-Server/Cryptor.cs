using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HeadServer
{
    static class Cryptor
    {
        static byte[] EncryptSha2(string str)
        {
            using (var sha = SHA512.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(str));
            }
        }

        static bool IsHashedSha2(string test_data, byte[] hashed_sample)
        {
            byte[] hashed_data = EncryptSha2(test_data);
            if (hashed_data.Length == hashed_sample.Length)
            {
                for (int i = 0; i < hashed_sample.Length; ++i)
                {
                    if (hashed_sample[i] != hashed_data[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

    }
}
