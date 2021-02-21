using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace TitanSouls.Save {
    public static class ObjectExtensions {
        public static T Clone<T>(this T source) {
            if (!typeof(T).IsSerializable) {
                throw new ArgumentException("The type must be serializable.", nameof(source));
            }

            if (source == null) {
                return default;
            }

            using (var stream = new MemoryStream()) {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
