
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Serializes and Deserializes some class E
    /// </summary>
    public static class BinaryMessageFactory
    {
        static BinaryMessageFactory()
        {
            _formatter = new BinaryFormatter();
        }

        public static byte[] Serialize(this object obj)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                _formatter.Serialize(memory, obj);
                memory.Flush();
                return memory.ToArray();
            }
        }

        public static E Deserialize<E>(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                return default(E);
            }
            using (MemoryStream memory = new MemoryStream(data))
            {
                return (E)_formatter.Deserialize(memory);
            }
        }
        private static BinaryFormatter _formatter;
    }
}
