namespace CommonLibrary.Implementation.Crypto
{
    // ! Interface cannot have static members
    public abstract class BaseEncryptor
    {
        public static byte[] Encrypt(string str)
        {
            return null;
        }
        public static byte[] Encrypt(byte[] data)
        {
            return null;
        }
        public static bool IsHashOfString(byte[] hash, string sample)
        {
            return false;
        }
    }
}
