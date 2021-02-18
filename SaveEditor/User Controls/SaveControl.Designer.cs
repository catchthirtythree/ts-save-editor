
namespace TitanSouls.Forms {
    partial class SaveControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_select_save = new System.Windows.Forms.Label();
            this.cb_select_save = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_select_save
            // 
            this.lbl_select_save.AutoSize = true;
            this.lbl_select_save.Location = new System.Drawing.Point(0, 8);
            this.lbl_select_save.Name = "lbl_select_save";
            this.lbl_select_save.Size = new System.Drawing.Size(99, 20);
            this.lbl_select_save.TabIndex = 0;
            this.lbl_select_save.Text = "Select a Save:";
            // 
            // cb_select_save
            // 
            this.cb_select_save.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select_save.FormattingEnabled = true;
            this.cb_select_save.Location = new System.Drawing.Point(119, 5);
            this.cb_select_save.Name = "cb_select_save";
            this.cb_select_save.Size = new System.Drawing.Size(180, 28);
            this.cb_select_save.TabIndex = 1;
            this.cb_select_save.SelectedIndexChanged += new System.EventHandler(this.cb_select_save_SelectedIndexChanged);
            // 
            // SaveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_select_save);
            this.Controls.Add(this.lbl_select_save);
            this.Name = "SaveControl";
            this.Size = new System.Drawing.Size(317, 39);
            this.Load += new System.EventHandler(this.SaveControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_select_save;
        private System.Windows.Forms.ComboBox cb_select_save;
    }
}
