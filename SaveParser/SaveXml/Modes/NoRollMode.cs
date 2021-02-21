using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class NoRollMode {
        [XmlAttribute("val")]
        public int Value {
            get;
            set;
        }
    }
}
