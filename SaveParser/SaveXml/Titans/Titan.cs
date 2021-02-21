using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public enum TitanId {
        [XmlEnum("sludgeheart")] sludgeheart,
        [XmlEnum("eyecube")] eyecube,
        [XmlEnum("EyeCube2")] EyeCube2,
        [XmlEnum("brainfreeze")] brainfreeze,
        [XmlEnum("colossus")] colossus,
        [XmlEnum("mushroom")] mushroom,
        [XmlEnum("plant")] plant,
        [XmlEnum("plant12")] plant12,
        [XmlEnum("knight")] knight,
        [XmlEnum("avarice")] avarice,
        [XmlEnum("ghost")] ghost,
        [XmlEnum("bomber")] bomber,
        [XmlEnum("ironknuckle")] ironknuckle,
        [XmlEnum("roller")] roller,
        [XmlEnum("yeti")] yeti,
        [XmlEnum("onyx")] onyx,
        [XmlEnum("guardian")] guardian,
        [XmlEnum("thesoul")] thesoul,
        [XmlEnum("truth")] truth
    }

    [Serializable]
    public class Titan {
        [XmlAttribute("id")]
        public TitanId Id {
            get;
            set;
        }

        [XmlElement("pos")]
        public List<TitanPosition> Position {
            get;
            set;
        }

        [XmlElement("angle")]
        public List<TitanAngle> Angle {
            get;
            set;
        }
    }
}
