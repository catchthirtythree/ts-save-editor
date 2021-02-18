using System;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class SavePoint {
        [XmlAttribute("id")]
        public string Id {
            get;
            set;
        }
    }
}