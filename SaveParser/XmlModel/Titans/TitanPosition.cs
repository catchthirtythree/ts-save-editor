using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class TitanPosition {
        [XmlAttribute("x")]
        public string X {
            get;
            set;
        }
        [XmlAttribute("y")]
        public string Y {
            get;
            set;
        }
        [XmlAttribute("z")]
        public string Z {
            get;
            set;
        }
    }
}
