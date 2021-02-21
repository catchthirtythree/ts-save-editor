using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class Deaths {
        [XmlAttribute("count")]
        public string Count { 
            get; 
            set;
        }
    }
}
