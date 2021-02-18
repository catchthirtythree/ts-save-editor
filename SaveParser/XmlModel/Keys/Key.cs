using System;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public enum KeyId {
        [XmlEnum("gamestarted")] gamestarted,
        [XmlEnum("tut_switch")] tut_switch,
        [XmlEnum("start_eyedoor")] start_eyedoor,
        [XmlEnum("tutorial_door")] tutorial_door,
        [XmlEnum("sludge_door")] sludge_door,
        [XmlEnum("sludgeheart_dead")] sludgeheart_dead,
        [XmlEnum("eyecube_door")] eyecube_door,
        [XmlEnum("eyecube_dead")] eyecube_dead,
        [XmlEnum("brain_door")] brain_door,
        [XmlEnum("brainfreeze_dead")] brainfreeze_dead,
        [XmlEnum("colossus_dead")] colossus_dead,
        [XmlEnum("colossus_door")] colossus_door,
        [XmlEnum("floor1_door_open")] floor1_door_open,
        [XmlEnum("mushroom_dead")] mushroom_dead,
        [XmlEnum("plant_dead")] plant_dead,
        [XmlEnum("knight_dead")] knight_dead,
        [XmlEnum("avarice_switch")] avarice_switch,
        [XmlEnum("avarice_dead")] avarice_dead,
        [XmlEnum("ghost_dead")] ghost_dead,
        [XmlEnum("elder_dead")] elder_dead,
        [XmlEnum("bomber_dead")] bomber_dead,
        [XmlEnum("ironknuckle_dead")] ironknuckle_dead,
        [XmlEnum("roller_dead")] roller_dead,
        [XmlEnum("yeti_dead")] yeti_dead,
        [XmlEnum("icedoor")] icedoor,
        [XmlEnum("onyx_dead")] onyx_dead,
        [XmlEnum("snowface_dead")] snowface_dead,
        [XmlEnum("floor2_door_open")] floor2_door_open,
        [XmlEnum("guardian_dead")] guardian_dead,
        [XmlEnum("king_started")] king_started,
        [XmlEnum("kingtitan")] kingtitan,
        [XmlEnum("thesoul_dead")] thesoul_dead,
        [XmlEnum("truthdoorlook")] truthdoorlook,
        [XmlEnum("titan")] titan,
        [XmlEnum("truth_dead")] truth_dead
    }

    [Serializable]
    public class Key {
        [XmlAttribute("id")]
        public KeyId Id {
            get;
            set;
        }
    }
}
