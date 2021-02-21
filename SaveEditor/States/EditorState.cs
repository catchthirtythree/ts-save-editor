using System;
using System.Collections.Generic;
using System.Text;
using TitanSouls.Save;

namespace TitanSouls.Forms {
    public class EditorState {
        public FileSlot Id { get; }
        public string Name { get; }

        public EditorState(FileSlot id, string name) {
            this.Id = id;
            this.Name = name;
        }
    }
}
