//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TitanSouls.Save {
//    public enum Slot {
//        One = 0,
//        Two = 1,
//        Three = 2,
//        Four = 3
//    }

//    public class RawSaveData {
//        public string Xml { get; }
//        public string Hash { get; }

//        public RawSaveData(string xml, string hash) {
//            this.Xml = xml;
//            this.Hash = hash;
//        }
//    }

//    public class SaveState {
//        public string Path { get; }
//        public Slot Slot { get; }

//        private SaveData Data { get; set; }
//        private RawSaveData RawData { get; set; }

//        private readonly string SALT = Environment.NewLine + @"buTT&f4rt5_LoLz";

//        public SaveState(string path, Slot slot) {
//            this.Path = path;
//            this.Slot = slot;

//            var lines = this.ReadSaveFile();

//            var raw_data = string.Join(Environment.NewLine, lines.SkipLast(1));
//            var hash = TSMD5.Generate(raw_data + this.SALT);

//            this.RawData = new RawSaveData(raw_data, hash);
//        }

//        public SaveData GetData() {
//            if (this.Data == null) {
//                this.Data = SaveData.CreateFromData(this.RawData.Xml);
//            }

//            return this.Data.Clone();
//        }

//        public string GetFilePath() {
//            return String.Format(@"{0}{1}.txt", this.Path, ((int)this.Slot).ToString());
//        }

//        public IEnumerable<string> ReadSaveFile() {
//            var path = this.GetFilePath();
//            var lines = System.IO.File.ReadLines(path);
//            return lines;
//        }

//        public void SetData(SaveData data) {
//            this.Data = data;
//        }
//    }

//    public class SaveStates {
//        private string SaveFolderPath => @"\data\SAVE\";

//        public string GamePath { get; }
//        public List<SaveState> States { get; }

//        public SaveStates() {

//        }

//        public SaveStates(string game_path) {
//            this.GamePath = game_path;
//        }
//    }
//}
