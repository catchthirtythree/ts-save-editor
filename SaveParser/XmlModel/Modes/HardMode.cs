using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class HardMode {
        [XmlAttribute("val")]
        public int Value { 
            get; 
            set;
        }
    }
}
