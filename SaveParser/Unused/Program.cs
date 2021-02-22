using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public class Program {
        public static void Main(string[] args) {
            SaveFile.FileChanged += Program.OnFileChanged;

            var save_path = @"C:\Program Files (x86)\Steam\steamapps\common\Titan Souls\data\SAVE\";

            var slot = FileSlot.One;
            var files = new SaveFiles(save_path);
            var file1 = files.GetSaveFile(slot);

            Console.WriteLine(file1.GetHash());

            var data1 = file1.GetData();

            data1.ToggleKey(KeyId.eyecube_door, false);
            data1.ToggleKey(KeyId.king_started, false);
            data1.ToggleKey(KeyId.start_eyedoor, false);
            data1.ToggleKey(KeyId.tutorial_door, false);

            files.SetSaveFile(slot, data1);

            Console.WriteLine(data1.Time.ToReadableTime());
        }

        public static void OnFileChanged(SaveFile file) {
            Console.WriteLine(file.GetData().AsString());
        }
    }
}
