using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanSouls.Save {
    public class SaveFiles {
        public string GamePath { get; }

        private IDictionary<FileSlot, SaveFile> Files { get; }

        public SaveFiles(string game_path) {
            this.GamePath = game_path;
            this.Files = this.CreateSaveFiles(game_path);
        }

        private IDictionary<FileSlot, SaveFile> CreateSaveFiles(string path) {
            var slots = (IEnumerable<FileSlot>)Enum.GetValues(typeof(FileSlot));

            return slots.ToDictionary(
                slot => slot,
                slot => new SaveFile(path, slot)
            );
        }

        public SaveFile GetSaveFile(FileSlot slot) {
            return this.Files[slot];
        }

        public void SetSaveFile(FileSlot slot, SaveData data) {
            this.Files[slot].SetData(data);
        }
    }
}
