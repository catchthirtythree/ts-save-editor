using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class TruthMode {
        [XmlAttribute("val")]
        public int Value {
            get;
            set;
        }
    }
}
