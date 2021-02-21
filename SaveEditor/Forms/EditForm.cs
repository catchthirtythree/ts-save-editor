using System;
using System.Windows.Forms;

namespace TitanSouls.Forms {
    public partial class EditForm : Form {
        public EditForm() {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e) {
            sc_select_save.Subscribe(ec_edit_save);
        }
    }
}
