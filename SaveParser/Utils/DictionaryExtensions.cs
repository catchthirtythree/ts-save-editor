using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanSouls.Save.Utils {
    public static class DictionaryExtensions {
        public static K GetKeyFromValue<K, V>(this IDictionary<K, V> dict, V val, K dflt) {
            var pair = dict.FirstOrDefault(x => x.Value.Equals(val));

            if (dflt.Equals(default(K))) {
                return dflt;
            }

            return pair.Key;
        }
    }
}
