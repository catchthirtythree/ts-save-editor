using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TitanSouls.Save.Utils;

namespace TitanSouls.Save {
    public class SaveFile {
        public string? Path { get; set; }
        public FileSlot? Slot { get; }

        private SaveData Data { get; set; }

        private readonly string SALT = Environment.NewLine + @"buTT&f4rt5_LoLz";

        public delegate void FileChangedEventHandler(SaveFile file);
        public static event FileChangedEventHandler FileChanged;
        
        public SaveFile() {
            this.Data = SaveData.CreateEmptyData();
        }

        public SaveFile(string path) {
            this.Path = path;

            this.Data = this.GetSaveData();
        }

        public SaveFile(string path, FileSlot slot) {
            this.Path = path;
            this.Slot = slot;

            this.Data = this.GetSaveData();
        }

        #region Private Functions

        private SaveData GetSaveData() {
            try {
                var lines = System.IO.File.ReadLines(this.GetFilePath());
                var data = string.Join(Environment.NewLine, lines.SkipLast(1));

                return SaveData.CreateFromData(data);
            } catch (Exception) {
                return SaveData.CreateEmptyData();
            }
        }

        #endregion Private Functions

        #region Public Get Functions

        public SaveData GetData() {
            return this.Data.Clone();
        }

        public string GetFilePath() {
            if (this.Path == null || this.Slot == null) {
                return this.Path;
            }

            return String.Format(@"{0}{1}.txt", this.Path, ((int)this.Slot).ToString());
        }

        public string GetHash() {
            var data = this.GetData();

            var raw_data = data.AsString();
            var hash = TSMD5.Generate(raw_data + this.SALT);

            return hash;
        }

        #endregion Public Get Functions

        #region Public Set Functions

        public void SetData(SaveData data) {
            this.Data = data;

            var raw_data = data.AsString();
            var hash = TSMD5.Generate(raw_data + this.SALT);

            FileChanged?.Invoke(this);
        }

        #endregion Public Set Functions

        public void Save() {
            var file_path = this.GetFilePath();

            var data = this.Data.AsString();
            var hash = this.GetHash();
            var data_with_hash = data + Environment.NewLine + hash;

            File.WriteAllText(file_path, data_with_hash);
        }

        public void Save(string path) {
            var data = this.Data.AsString();
            var hash = this.GetHash();
            var data_with_hash = data + Environment.NewLine + hash;

            File.WriteAllText(path, data_with_hash);

            this.Path = path;
        }
    }
}
