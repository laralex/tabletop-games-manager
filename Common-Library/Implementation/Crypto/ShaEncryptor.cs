using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using CommonLibrary.Model.Crypto;
using System.Data.Linq;

namespace CommonLibrary.Implementation.Crypto
{
    public static class ShaEncryptor : IEncryptor
    {
        static public byte[] Encrypt(string str)
        {
            return Encrypt(Encoding.UTF8.GetBytes(str));   
        }

        static public byte[] Encrypt(byte[] data)
        {
            using (var sha = SHA512.Create())
            {
                return sha.ComputeHash(data);
            }
        }

        static public bool IsHashOfString(byte[] hash, string sample)
        {
            if (hash == null || sample == null)
            {
                return false;
            }
            byte[] hashed_sample = Encrypt(sample);
            return new Binary(hash).Equals(new Binary(hashed_sample));
        }

    }
}
