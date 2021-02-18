using System;
using System.Security.Cryptography;
using System.Text;

namespace TitanSouls.Save {
    public class TSMD5 {
        public static string Generate(string input) {
            using var md5 = MD5.Create();

            var cleaned_input = input.Replace("\r", "");
            var input_bytes = Encoding.Default.GetBytes(cleaned_input);
            var hash_bytes = md5.ComputeHash(input_bytes);
            var delimited_hash_string = BitConverter.ToString(hash_bytes);
            var hash_string = delimited_hash_string.Replace("-", "");

            return hash_string.ToLowerInvariant();
        }
    }
}
