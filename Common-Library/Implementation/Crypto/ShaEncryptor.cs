using System.Text;
using System.Security.Cryptography;

using System.Data.Linq;

namespace CommonLibrary.Implementation.Crypto
{
    // With this encryptor we send and store users' passwords
    // It's weak secutity hash, but better than plain text 
    public sealed class ShaEncryptor : BaseEncryptor
    {
        static new public byte[] Encrypt(string str)
        {
            return Encrypt(Encoding.UTF8.GetBytes(str));   
        }

        static new public byte[] Encrypt(byte[] data)
        {
            using (var sha = SHA512.Create())
            {
                return sha.ComputeHash(data);
            }
        }

        static new public bool IsHashOfString(byte[] hash, string sample)
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
