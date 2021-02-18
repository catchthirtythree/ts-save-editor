using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
