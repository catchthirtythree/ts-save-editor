using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

//<?xml version="1.0"?>
//<data>
//  <Map id="MAPS/floor2/ruins.tmx" />
//  <SavePoint id="graveyard_spawn" />
//  <Position x="3992" y="3463" />
//  <Deaths count="6" />
//  <Kills count="6" />
//  <Keys>
//    <Key id="gamestarted" />
//    <Key id="tut_switch" />
//    <Key id="start_eyedoor" />
//    <Key id="tutorial_door" />
//    <Key id="sludge_door" />
//    <Key id="sludgeheart_dead" />
//    <Key id="eyecube_door" />
//    <Key id="eyecube_dead" />
//    <Key id="brain_door" />
//    <Key id="brainfreeze_dead" />
//    <Key id="colossus_dead" />
//    <Key id="colossus_door" />
//    <Key id="floor1_door_open" />
//    <Key id="mushroom_dead" />
//    <Key id="plant_dead" />
//  </Keys>
//  <Titan id="sludgeheart">
//    <pos x="545" y="316" z="0" />
//  </Titan>
//  <Titan id="eyecube">
//    <pos x="480" y="496" z="0" />
//    <angle>0.000000</angle>
//    <angle>1.570796</angle>
//    <angle>0.000000</angle>
//  </Titan>
//  <Titan id="brainfreeze">
//    <pos x="481" y="625" z="0" />
//    <angle>359.694550</angle>
//  </Titan>
//  <Titan id="colossus">
//    <pos x="808" y="888" z="0" />
//    <pos x="791" y="822" z="0" />
//    <pos x="801" y="937" z="0" />
//  </Titan>
//  <Titan id="mushroom">
//    <pos x="472" y="629" z="0" />
//    <angle>-67.475723</angle>
//  </Titan>
//  <Titan id="plant">
//    <angle>-1.969926</angle>
//  </Titan>
//  <hard val="0" />
//  <iron val="0" />
//  <truth val="0" />
//  <rolls val="0" />
//  <trespawn val="0" />
//  <time val="60747" />
//</data>

namespace TitanSouls.Save {
    [Serializable]
    [XmlRoot("data")]
    public class SaveData {
        #region XmlElements

        [XmlElement("Map")]
        public Map Map { get; set; }

        [XmlElement("SavePoint")]
        public RespawnPoint RespawnPoint { get; set; }

        [XmlElement("Position")]
        public PlayerPosition PlayerPosition { get; set; }

        [XmlElement("Deaths")]
        public Deaths PlayerDeaths { get; set; }

        [XmlElement("Kills")]
        public Kills TitanKills { get; set; }

        [XmlArray("Keys")]
        [XmlArrayItem("Key")]
        public List<Key> Keys { get; set; }

        [XmlElement("Titan")]
        public List<Titan> TitanRemnants { get; set; }

        [XmlElement("hard")]
        public HardMode HardMode { get; set; }

        [XmlElement("iron")]
        public IronMode IronMode { get; set; }

        [XmlElement("truth")]
        public TruthMode TruthMode { get; set; }

        [XmlElement("rolls")]
        public NoRollMode NoRollMode { get; set; }

        [XmlElement("trespawn")]
        public TitanRespawn TitanRespawn { get; set; }

        [XmlElement("time")]
        public Time Time { get; set; }

        #endregion

        #region Static Get Functions

        public static SaveData CreateFromData(string data) {
            var serializer = new XmlSerializer(typeof(SaveData));

            using (var string_reader = new StringReader(data)) {
                return (SaveData)serializer.Deserialize(string_reader);
            }
        }

        public static SaveData CreateEmptyData() {
            return new SaveData() {
                Map = new Map() { Id = "" },
                RespawnPoint = new RespawnPoint() { Id = "" },
                PlayerPosition = new PlayerPosition() { X = "-1", Y = "-1" },
                PlayerDeaths = new Deaths() { Count = "0" },
                TitanKills = new Kills() { Count = "0" },
                Keys = new List<Key>(),
                TitanRemnants = new List<Titan>(),
                HardMode = new HardMode() { Value = 0 },
                IronMode = new IronMode() { Value = 0 },
                TruthMode = new TruthMode() { Value = 0 },
                NoRollMode = new NoRollMode() { Value = 0 },
                TitanRespawn = new TitanRespawn() { Value = 0 },
                Time = new Time() { Value = 0 }
            };
        }

        #endregion Static Get Functions

        public string AsString() {
            var serializer = new XmlSerializer(this.GetType());

            var sb = new StringBuilder();
            var settings = new XmlWriterSettings() {
                Indent = true,
                IndentChars = "    ",
                // Remove declaration because the encoding ruins the md5 generation.
                // <?xml version="1.0" encoding="utf-16"?>
                OmitXmlDeclaration = true
            };

            var xml_namespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            using (var writer = XmlWriter.Create(sb, settings)) {
                serializer.Serialize(writer, this, xml_namespaces);
            }

            // Add the declaration as it's expected.
            // <?xml version="1.0"?>
            var xml_declaration = @"<?xml version=""1.0"" ?>" + Environment.NewLine;
            sb = sb.Insert(0, xml_declaration);

            return sb.ToString();
        }

        public void ToggleKey(KeyId id, bool state) {
            if (state) {
                this.AddKey(id);
            } else {
                this.RemoveKey(id);
            }
        }

        private void AddKey(KeyId id) {
            var hasKey = this.Keys.Exists(key => key.Id == id);
            if (!hasKey) {
                this.Keys.Add(new Key() {
                    Id = id
                });
            }
        }

        public bool HasKey(KeyId id) {
            return this.Keys.Exists(key => key.Id == id);
        }

        private void RemoveKey(KeyId id) {
            this.Keys.RemoveAll(key => key.Id == id);
        }
    }
}
