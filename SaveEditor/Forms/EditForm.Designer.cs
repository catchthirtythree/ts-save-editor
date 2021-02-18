
namespace TitanSouls.Forms {
    partial class EditForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sc_select_save = new TitanSouls.Forms.SaveControl();
            this.ec_edit_save = new TitanSouls.Forms.EditorControl();
            this.SuspendLayout();
            // 
            // sc_select_save
            // 
            this.sc_select_save.Location = new System.Drawing.Point(15, 15);
            this.sc_select_save.Name = "sc_select_save";
            this.sc_select_save.Size = new System.Drawing.Size(306, 38);
            this.sc_select_save.TabIndex = 0;
            // 
            // ec_edit_save
            // 
            this.ec_edit_save.Location = new System.Drawing.Point(15, 70);
            this.ec_edit_save.Name = "ec_edit_save";
            this.ec_edit_save.Size = new System.Drawing.Size(909, 702);
            this.ec_edit_save.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(930, 784);
            this.Controls.Add(this.ec_edit_save);
            this.Controls.Add(this.sc_select_save);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titan Souls Save Modifier";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SaveControl sc_select_save;
        private EditorControl ec_edit_save;
    }
}

