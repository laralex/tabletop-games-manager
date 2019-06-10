using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Crypto
{
    public interface IEncryptor
    {
        byte[] Encrypt(string str);
        byte[] Encrypt(byte[] data);
        bool IsHashOfString(byte[] hash, string sample);
    }
}
