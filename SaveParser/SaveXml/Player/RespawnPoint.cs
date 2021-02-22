using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public enum RespawnPointId {
        no_spawn,
        tutorial_spawn,
        hub_elevator,
        forest_spawn,
        ruins_spawn,
        graveyard_spawn,
        magma_spawn,
        snow_spawn,
        bridge_elevator,
        guardian_spawn,
        king_spawn
    }

    [Serializable]
    public class RespawnPoint {
        public static IDictionary<string, RespawnPointId> Mappings = new Dictionary<string, RespawnPointId>() {
            { "", RespawnPointId.no_spawn },
            { "tutorial_spawn", RespawnPointId.tutorial_spawn },
            { "hub_elevator", RespawnPointId.hub_elevator },
            { "forest_spawn", RespawnPointId.forest_spawn },
            { "ruins_spawn", RespawnPointId.ruins_spawn },
            { "graveyard_spawn", RespawnPointId.graveyard_spawn },
            { "magma_spawn", RespawnPointId.magma_spawn },
            { "snow_spawn", RespawnPointId.snow_spawn },
            { "bridge_elevator", RespawnPointId.bridge_elevator },
            { "guardian_spawn", RespawnPointId.guardian_spawn },
            { "king_spawn", RespawnPointId.king_spawn }
        };

        [XmlAttribute("id")]
        public string Id {
            get;
            set;
        }
    }
}