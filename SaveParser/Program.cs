using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace TitanSouls.Save {
    public class Program {
        public static void Main(string[] args) {
            var game_path = @"C:\Program Files (x86)\Steam\steamapps\common\Titan Souls";
            var save_reader = new SaveReader(game_path);
            var save_file = new SaveFile(save_reader, FileSlot.First, Program.FileChangedHandler);

            var save_data = save_file.GetSaveData();
            var contents = save_data.AsString() + SaveFile.SALT;

            Console.WriteLine(contents);
            Console.WriteLine(save_file.Hash);

            //save_file.Save(save_reader);

            //var states = new SaveStates();

            //Console.WriteLine(states.GamePath);
        }

        public static void FileChangedHandler(object obj, PropertyChangedEventArgs args) {
            Console.WriteLine(@"{0} => {1}", obj.ToString(), args.PropertyName.ToString());
        }
    }
}
