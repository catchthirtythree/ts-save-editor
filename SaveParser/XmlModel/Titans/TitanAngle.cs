using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    [Serializable]
    public class TitanAngle {
        [XmlText]
        public string AngleValue { 
            get; 
            set;
        }
    }
}
