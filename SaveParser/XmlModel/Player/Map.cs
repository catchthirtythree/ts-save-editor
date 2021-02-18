using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class Map {
        [XmlAttribute("id")]
        public string Id {
            get;
            set;
        }
    }
}
