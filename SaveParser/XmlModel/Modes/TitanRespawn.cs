using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class TitanRespawn {
        [XmlAttribute("val")]
        public int Value {
            get;
            set;
        }
    }
}
