using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class IronMode {
        [XmlAttribute("val")]
        public int Value { 
            get; 
            set;
        }
    }
}
