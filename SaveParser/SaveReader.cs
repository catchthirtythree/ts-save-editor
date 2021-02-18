using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace TitanSouls.Save {
    public enum FileSlot {
        First = 0,
        Second = 1,
        Third = 2,
        Fourth = 3
    }

    public class SaveReader {
        public string GamePath { get; }
        private string SaveFolderPath => @"\data\SAVE\";

        // @TODO
        // I'd like for this class to hold state for all of the currently available save files.
        public SaveReader(string game_path) {
            this.GamePath = game_path;
        }

        public string GetFilePath(FileSlot slot) {
            var name = ((int) slot).ToString();
            return String.Format(@"{0}{1}{2}.txt", this.GamePath, this.SaveFolderPath, name);
        }

        public IEnumerable<string> GetSaveFileLines(FileSlot slot) {
            var path = this.GetFilePath(slot);
            var lines = System.IO.File.ReadLines(path);
            return lines;
        }
    }
}
