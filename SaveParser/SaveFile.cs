using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public class SaveFile {
        public static string SALT = Environment.NewLine + @"buTT&f4rt5_LoLz";

        public FileSlot Slot { get; }
        public string Hash { get; private set; }

        private SaveData SaveData { get; set; }

        public event PropertyChangedEventHandler FileChanged;

        public SaveFile(SaveReader reader, FileSlot slot) 
            : this(reader, slot, (object o, PropertyChangedEventArgs e) => { }) { 
        }

        public SaveFile(SaveReader reader, FileSlot slot, Action<object, PropertyChangedEventArgs> action) {
            this.Slot = slot;
            this.FileChanged += new PropertyChangedEventHandler(action);

            // @TODO
            // Do not love this.
            // I'd rather not have thing event handler fire immediately after instantiation.
            // This file should also know if the save file is available and valid.
            // It would be nice to be able to show those things.
            this.ParseFile(reader, slot);
        }

        public SaveData GetSaveData() {
            return this.SaveData.Clone<SaveData>();
        }

        private void ParseFile(SaveReader reader, FileSlot slot) {
            var lines = reader.GetSaveFileLines(slot);

            var data = string.Join(Environment.NewLine, lines.SkipLast(1));
            var save_data = SaveData.CreateFromData(data);

            this.SetSaveData(save_data);
        }

        public void Save(SaveReader reader) {
            var file_path = reader.GetFilePath(this.Slot);

            var data = this.SaveData.AsString();
            var data_with_hash = data + Environment.NewLine + this.Hash;

            File.WriteAllText(file_path, data_with_hash);
        }

        public void SetSaveData(SaveData data) {
            this.SaveData = data;
            this.Hash = TSMD5.Generate(data.AsString() + SALT);

            this.FileChanged.Invoke(this, new PropertyChangedEventArgs("Hash"));
        }

        public static bool ValidateHash(SaveReader reader, FileSlot slot) {
            var lines = reader.GetSaveFileLines(slot);

            var hash = lines.Last();

            var data = string.Join(Environment.NewLine, lines.SkipLast(1));
            var generated_hash = TSMD5.Generate(data + SALT);

            return hash.Equals(generated_hash);
        }
    }
}
