using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class Time {
        [XmlAttribute("val")]
        public long Value {
            get;
            set;
        }
    }
}
