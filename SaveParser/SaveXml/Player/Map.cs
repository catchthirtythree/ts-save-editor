using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public enum MapId {
        no_map,

        floor1_avarice,
        floor1_bomb,
        floor1_brainfreeze,
        floor1_chamber,
        floor1_colossus,
        floor1_eyecube,
        floor1_eyecube2,
        floor1_floor1,
        floor1_ghost,
        floor1_JAM,
        floor1_knight,
        floor1_mushroom,
        floor1_onyx,
        floor1_plant,
        floor1_plant12,
        floor1_roller,
        floor1_ruinsinterior1,
        floor1_ruinsinterior2,
        floor1_sludgeheart,
        floor1_truth,
        floor1_yeti,

        floor2_bridge1,
        floor2_bridge2,
        floor2_bridge3,
        floor2_chamber2,
        floor2_eldercave,
        floor2_elevatormagma,
        floor2_elevatorsnow,
        floor2_magma,
        floor2_magmacave,
        floor2_ruins,
        floor2_snow,
        floor2_snowcave,
        floor2_snowmural,
        floor2_statue,
        floor2_tower,

        floor2_woods_a,
        floor2_woods_b,
        floor2_woods_d,
        floor2_woods_e,
        floor2_woods_f,
        floor2_woods_frogentrance,
        floor2_woods_g,
        floor2_woods_h,
        floor2_woods_plantentrance,
        floor2_woods_plantentrance12,
        floor2_woods_shroomentrance,
        floor2_woods_title
    }

    [Serializable]
    public class Map {
        public static IDictionary<string, MapId> Mappings = new Dictionary<string, MapId>() {
            { "", MapId.no_map },

            { "maps/avarice.tmx", MapId.floor1_avarice },
            { "maps/bomb.tmx", MapId.floor1_bomb },
            { "maps/brainfreeze.tmx", MapId.floor1_brainfreeze },
            { "maps/chamber.tmx", MapId.floor1_chamber },
            { "maps/colossus.tmx", MapId.floor1_colossus },
            { "maps/eyecube.tmx", MapId.floor1_eyecube },
            { "maps/eyecube2.tmx", MapId.floor1_eyecube2 },
            { "maps/floor1.tmx", MapId.floor1_floor1 },
            { "maps/ghost.tmx", MapId.floor1_ghost },
            { "maps/jam.tmx", MapId.floor1_JAM },
            { "maps/knight.tmx", MapId.floor1_knight },
            { "maps/mushroom.tmx", MapId.floor1_mushroom },
            { "maps/onyx.tmx", MapId.floor1_onyx },
            { "maps/plant.tmx", MapId.floor1_plant },
            { "maps/plant12.tmx", MapId.floor1_plant12 },
            { "maps/roller.tmx", MapId.floor1_roller },
            { "maps/ruinsinterior1.tmx", MapId.floor1_ruinsinterior1 },
            { "maps/ruinsinterior2.tmx", MapId.floor1_ruinsinterior2 },
            { "maps/sludgeheart.tmx", MapId.floor1_sludgeheart },
            { "maps/truth.tmx", MapId.floor1_truth },
            { "maps/yeti.tmx", MapId.floor1_yeti },

            { "maps/floor2/bridge1.tmx", MapId.floor2_bridge1 },
            { "maps/floor2/bridge2.tmx", MapId.floor2_bridge2 },
            { "maps/floor2/bridge3.tmx", MapId.floor2_bridge3 },
            { "maps/floor2/chamber2.tmx", MapId.floor2_chamber2 },
            { "maps/floor2/eldercave.tmx", MapId.floor2_eldercave },
            { "maps/floor2/elevatormagma.tmx", MapId.floor2_elevatormagma },
            { "maps/floor2/elevatorsnow.tmx", MapId.floor2_elevatorsnow },
            { "maps/floor2/magma.tmx", MapId.floor2_magma },
            { "maps/floor2/magmacave.tmx", MapId.floor2_magmacave },
            { "maps/floor2/ruins.tmx", MapId.floor2_ruins },
            { "maps/floor2/snow.tmx", MapId.floor2_snow },
            { "maps/floor2/snowcave.tmx", MapId.floor2_snowcave },
            { "maps/floor2/snowmural.tmx", MapId.floor2_snowmural },
            { "maps/floor2/statue.tmx", MapId.floor2_statue },
            { "maps/floor2/tower.tmx", MapId.floor2_tower },

            { "maps/floor2/woods/a.tmx", MapId.floor2_woods_a },
            { "maps/floor2/woods/b.tmx", MapId.floor2_woods_b },
            { "maps/floor2/woods/d.tmx", MapId.floor2_woods_d },
            { "maps/floor2/woods/e.tmx", MapId.floor2_woods_e },
            { "maps/floor2/woods/f.tmx", MapId.floor2_woods_f },
            { "maps/floor2/woods/frogentrance.tmx", MapId.floor2_woods_frogentrance },
            { "maps/floor2/woods/g.tmx", MapId.floor2_woods_g },
            { "maps/floor2/woods/h.tmx", MapId.floor2_woods_h },
            { "maps/floor2/woods/plantentrance.tmx", MapId.floor2_woods_plantentrance },
            { "maps/floor2/woods/plantentrance12.tmx", MapId.floor2_woods_plantentrance12 },
            { "maps/floor2/woods/shroomentrance.tmx", MapId.floor2_woods_shroomentrance },
            { "maps/floor2/woods/title.tmx", MapId.floor2_woods_title },
        };

        // This is necessary because when Titan Souls saves a MapId it doesn't seem to case about case.
        // Sometimes MAPS, sometimes maps. Sometimes FLOOR2, sometimes floor2.
        private string LowerCaseId {
            get;
            set;
        }

        [XmlAttribute("id")]
        public string Id {
            get {
                return this.LowerCaseId;
            }

            set {
                this.LowerCaseId = value.ToLowerInvariant();
            }
        }
    }
}
