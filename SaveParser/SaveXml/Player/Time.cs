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

        public string ToReadableTime() {
            var total_seconds = this.Value / 60;

            var hours = (int)(total_seconds / 3600);
            var minutes = (int)((total_seconds % 3600) / 60);
            var seconds = (int)((total_seconds % 3600) % 60);

            return new TimeSpan(hours, minutes, seconds).ToString();
        }
    }
}
