using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
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
            using (MemoryStream memory = new MemoryStream(data))
            {
                return (E)_formatter.Deserialize(memory);
            }
        }
        private static BinaryFormatter _formatter;
    }
}
