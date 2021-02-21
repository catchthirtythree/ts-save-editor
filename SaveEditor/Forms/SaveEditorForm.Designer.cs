
namespace TitanSouls.Forms {
    partial class SaveEditorForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.tc_save_file = new System.Windows.Forms.TabControl();
            this.tp_general = new System.Windows.Forms.TabPage();
            this.btn_clear_player_position = new System.Windows.Forms.Button();
            this.lbl_player_position_tt = new System.Windows.Forms.Label();
            this.lbl_respawn_point_tt = new System.Windows.Forms.Label();
            this.lbl_map_tt = new System.Windows.Forms.Label();
            this.num_player_position_y = new System.Windows.Forms.NumericUpDown();
            this.num_player_position_x = new System.Windows.Forms.NumericUpDown();
            this.lbl_deaths = new System.Windows.Forms.Label();
            this.lbl_kills = new System.Windows.Forms.Label();
            this.lbl_respawn_point = new System.Windows.Forms.Label();
            this.lbl_player_position_y = new System.Windows.Forms.Label();
            this.lbl_player_position_x = new System.Windows.Forms.Label();
            this.lbl_player_position = new System.Windows.Forms.Label();
            this.lbl_map = new System.Windows.Forms.Label();
            this.cb_respawn_point = new System.Windows.Forms.ComboBox();
            this.cb_map = new System.Windows.Forms.ComboBox();
            this.chk_trespawn = new System.Windows.Forms.CheckBox();
            this.chk_noroll = new System.Windows.Forms.CheckBox();
            this.chk_truth = new System.Windows.Forms.CheckBox();
            this.chk_iron = new System.Windows.Forms.CheckBox();
            this.chk_hard = new System.Windows.Forms.CheckBox();
            this.num_kills = new System.Windows.Forms.NumericUpDown();
            this.num_deaths = new System.Windows.Forms.NumericUpDown();
            this.tp_titans = new System.Windows.Forms.TabPage();
            this.chk_eyecube2_dead = new System.Windows.Forms.CheckBox();
            this.chk_plant12_dead = new System.Windows.Forms.CheckBox();
            this.chk_truth_dead = new System.Windows.Forms.CheckBox();
            this.chk_elder_dead = new System.Windows.Forms.CheckBox();
            this.chk_ghost_dead = new System.Windows.Forms.CheckBox();
            this.chk_thesoul_dead = new System.Windows.Forms.CheckBox();
            this.chk_guardian_dead = new System.Windows.Forms.CheckBox();
            this.chk_snowface_dead = new System.Windows.Forms.CheckBox();
            this.chk_onyx_dead = new System.Windows.Forms.CheckBox();
            this.chk_yeti_dead = new System.Windows.Forms.CheckBox();
            this.chk_roller_dead = new System.Windows.Forms.CheckBox();
            this.chk_ironknuckle_dead = new System.Windows.Forms.CheckBox();
            this.chk_bomber_dead = new System.Windows.Forms.CheckBox();
            this.chk_avarice_dead = new System.Windows.Forms.CheckBox();
            this.chk_knight_dead = new System.Windows.Forms.CheckBox();
            this.chk_plant_dead = new System.Windows.Forms.CheckBox();
            this.chk_mushroom_dead = new System.Windows.Forms.CheckBox();
            this.chk_colossus_dead = new System.Windows.Forms.CheckBox();
            this.chk_brainfreeze_dead = new System.Windows.Forms.CheckBox();
            this.chk_eyecube_dead = new System.Windows.Forms.CheckBox();
            this.chk_sludgeheart_dead = new System.Windows.Forms.CheckBox();
            this.tp_misc = new System.Windows.Forms.TabPage();
            this.chk_titan = new System.Windows.Forms.CheckBox();
            this.chk_truthdoorlook = new System.Windows.Forms.CheckBox();
            this.chk_kingtitan = new System.Windows.Forms.CheckBox();
            this.chk_king_started = new System.Windows.Forms.CheckBox();
            this.chk_floor2_door_open = new System.Windows.Forms.CheckBox();
            this.chk_icedoor = new System.Windows.Forms.CheckBox();
            this.chk_avarice_switch = new System.Windows.Forms.CheckBox();
            this.chk_floor1_door_open = new System.Windows.Forms.CheckBox();
            this.chk_colossus_door = new System.Windows.Forms.CheckBox();
            this.chk_brain_door = new System.Windows.Forms.CheckBox();
            this.chk_eyecube_door = new System.Windows.Forms.CheckBox();
            this.chk_sludge_door = new System.Windows.Forms.CheckBox();
            this.chk_tutorial_door = new System.Windows.Forms.CheckBox();
            this.chk_start_eyedoor = new System.Windows.Forms.CheckBox();
            this.chk_tut_switch = new System.Windows.Forms.CheckBox();
            this.chk_gamestarted = new System.Windows.Forms.CheckBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_hash = new System.Windows.Forms.TextBox();
            this.lbl_hash = new System.Windows.Forms.Label();
            this.gb_file = new System.Windows.Forms.GroupBox();
            this.lbl_current_file = new System.Windows.Forms.Label();
            this.lbl_file_saved = new System.Windows.Forms.Label();
            this.btn_discard = new System.Windows.Forms.Button();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.nav_menu_strip = new System.Windows.Forms.MenuStrip();
            this.menu_nav_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nav_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nav_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nav_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nav_file_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
            this.tt_respawn_point = new System.Windows.Forms.ToolTip(this.components);
            this.tt_map = new System.Windows.Forms.ToolTip(this.components);
            this.tt_player_position = new System.Windows.Forms.ToolTip(this.components);
            this.tt_titan_respawn_mode = new System.Windows.Forms.ToolTip(this.components);
            this.timer_lbl_file_changed = new System.Windows.Forms.Timer(this.components);
            this.tc_save_file.SuspendLayout();
            this.tp_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_player_position_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_player_position_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_deaths)).BeginInit();
            this.tp_titans.SuspendLayout();
            this.tp_misc.SuspendLayout();
            this.gb_file.SuspendLayout();
            this.nav_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.DefaultExt = "txt";
            this.open_file_dialog.Filter = "Text documents (.txt)|*.txt";
            this.open_file_dialog.RestoreDirectory = true;
            this.open_file_dialog.Title = "Open Save File...";
            // 
            // tc_save_file
            // 
            this.tc_save_file.Controls.Add(this.tp_general);
            this.tc_save_file.Controls.Add(this.tp_titans);
            this.tc_save_file.Controls.Add(this.tp_misc);
            this.tc_save_file.Location = new System.Drawing.Point(16, 89);
            this.tc_save_file.Name = "tc_save_file";
            this.tc_save_file.SelectedIndex = 0;
            this.tc_save_file.Size = new System.Drawing.Size(754, 407);
            this.tc_save_file.TabIndex = 2;
            // 
            // tp_general
            // 
            this.tp_general.Controls.Add(this.btn_clear_player_position);
            this.tp_general.Controls.Add(this.lbl_player_position_tt);
            this.tp_general.Controls.Add(this.lbl_respawn_point_tt);
            this.tp_general.Controls.Add(this.lbl_map_tt);
            this.tp_general.Controls.Add(this.num_player_position_y);
            this.tp_general.Controls.Add(this.num_player_position_x);
            this.tp_general.Controls.Add(this.lbl_deaths);
            this.tp_general.Controls.Add(this.lbl_kills);
            this.tp_general.Controls.Add(this.lbl_respawn_point);
            this.tp_general.Controls.Add(this.lbl_player_position_y);
            this.tp_general.Controls.Add(this.lbl_player_position_x);
            this.tp_general.Controls.Add(this.lbl_player_position);
            this.tp_general.Controls.Add(this.lbl_map);
            this.tp_general.Controls.Add(this.cb_respawn_point);
            this.tp_general.Controls.Add(this.cb_map);
            this.tp_general.Controls.Add(this.chk_trespawn);
            this.tp_general.Controls.Add(this.chk_noroll);
            this.tp_general.Controls.Add(this.chk_truth);
            this.tp_general.Controls.Add(this.chk_iron);
            this.tp_general.Controls.Add(this.chk_hard);
            this.tp_general.Controls.Add(this.num_kills);
            this.tp_general.Controls.Add(this.num_deaths);
            this.tp_general.Location = new System.Drawing.Point(4, 29);
            this.tp_general.Name = "tp_general";
            this.tp_general.Padding = new System.Windows.Forms.Padding(3);
            this.tp_general.Size = new System.Drawing.Size(746, 374);
            this.tp_general.TabIndex = 0;
            this.tp_general.Text = "General";
            this.tp_general.UseVisualStyleBackColor = true;
            // 
            // btn_clear_player_position
            // 
            this.btn_clear_player_position.Location = new System.Drawing.Point(444, 45);
            this.btn_clear_player_position.Name = "btn_clear_player_position";
            this.btn_clear_player_position.Size = new System.Drawing.Size(116, 29);
            this.btn_clear_player_position.TabIndex = 79;
            this.btn_clear_player_position.Text = "Clear Position";
            this.btn_clear_player_position.UseVisualStyleBackColor = true;
            this.btn_clear_player_position.Click += new System.EventHandler(this.btn_clear_player_position_Click);
            // 
            // lbl_player_position_tt
            // 
            this.lbl_player_position_tt.AutoSize = true;
            this.lbl_player_position_tt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_player_position_tt.Location = new System.Drawing.Point(293, 49);
            this.lbl_player_position_tt.Name = "lbl_player_position_tt";
            this.lbl_player_position_tt.Size = new System.Drawing.Size(26, 20);
            this.lbl_player_position_tt.TabIndex = 78;
            this.lbl_player_position_tt.Text = "(?)";
            // 
            // lbl_respawn_point_tt
            // 
            this.lbl_respawn_point_tt.AutoSize = true;
            this.lbl_respawn_point_tt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_respawn_point_tt.Location = new System.Drawing.Point(293, 116);
            this.lbl_respawn_point_tt.Name = "lbl_respawn_point_tt";
            this.lbl_respawn_point_tt.Size = new System.Drawing.Size(26, 20);
            this.lbl_respawn_point_tt.TabIndex = 77;
            this.lbl_respawn_point_tt.Text = "(?)";
            // 
            // lbl_map_tt
            // 
            this.lbl_map_tt.AutoSize = true;
            this.lbl_map_tt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_map_tt.Location = new System.Drawing.Point(226, 16);
            this.lbl_map_tt.Name = "lbl_map_tt";
            this.lbl_map_tt.Size = new System.Drawing.Size(26, 20);
            this.lbl_map_tt.TabIndex = 76;
            this.lbl_map_tt.Text = "(?)";
            // 
            // num_player_position_y
            // 
            this.num_player_position_y.Location = new System.Drawing.Point(354, 80);
            this.num_player_position_y.Name = "num_player_position_y";
            this.num_player_position_y.Size = new System.Drawing.Size(83, 27);
            this.num_player_position_y.TabIndex = 75;
            this.num_player_position_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_player_position_x
            // 
            this.num_player_position_x.Location = new System.Drawing.Point(354, 47);
            this.num_player_position_x.Name = "num_player_position_x";
            this.num_player_position_x.Size = new System.Drawing.Size(83, 27);
            this.num_player_position_x.TabIndex = 74;
            this.num_player_position_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_deaths
            // 
            this.lbl_deaths.AutoSize = true;
            this.lbl_deaths.Location = new System.Drawing.Point(188, 182);
            this.lbl_deaths.Name = "lbl_deaths";
            this.lbl_deaths.Size = new System.Drawing.Size(99, 20);
            this.lbl_deaths.TabIndex = 73;
            this.lbl_deaths.Text = "Player Deaths";
            // 
            // lbl_kills
            // 
            this.lbl_kills.AutoSize = true;
            this.lbl_kills.Location = new System.Drawing.Point(188, 149);
            this.lbl_kills.Name = "lbl_kills";
            this.lbl_kills.Size = new System.Drawing.Size(73, 20);
            this.lbl_kills.TabIndex = 72;
            this.lbl_kills.Text = "Titan Kills";
            // 
            // lbl_respawn_point
            // 
            this.lbl_respawn_point.AutoSize = true;
            this.lbl_respawn_point.Location = new System.Drawing.Point(188, 116);
            this.lbl_respawn_point.Name = "lbl_respawn_point";
            this.lbl_respawn_point.Size = new System.Drawing.Size(105, 20);
            this.lbl_respawn_point.TabIndex = 71;
            this.lbl_respawn_point.Text = "Respawn Point";
            // 
            // lbl_player_position_y
            // 
            this.lbl_player_position_y.AutoSize = true;
            this.lbl_player_position_y.Location = new System.Drawing.Point(331, 83);
            this.lbl_player_position_y.Name = "lbl_player_position_y";
            this.lbl_player_position_y.Size = new System.Drawing.Size(17, 20);
            this.lbl_player_position_y.TabIndex = 70;
            this.lbl_player_position_y.Text = "Y";
            // 
            // lbl_player_position_x
            // 
            this.lbl_player_position_x.AutoSize = true;
            this.lbl_player_position_x.Location = new System.Drawing.Point(330, 50);
            this.lbl_player_position_x.Name = "lbl_player_position_x";
            this.lbl_player_position_x.Size = new System.Drawing.Size(18, 20);
            this.lbl_player_position_x.TabIndex = 68;
            this.lbl_player_position_x.Text = "X";
            // 
            // lbl_player_position
            // 
            this.lbl_player_position.AutoSize = true;
            this.lbl_player_position.Location = new System.Drawing.Point(188, 50);
            this.lbl_player_position.Name = "lbl_player_position";
            this.lbl_player_position.Size = new System.Drawing.Size(105, 20);
            this.lbl_player_position.TabIndex = 67;
            this.lbl_player_position.Text = "Player Position";
            // 
            // lbl_map
            // 
            this.lbl_map.AutoSize = true;
            this.lbl_map.Location = new System.Drawing.Point(188, 16);
            this.lbl_map.Name = "lbl_map";
            this.lbl_map.Size = new System.Drawing.Size(39, 20);
            this.lbl_map.TabIndex = 66;
            this.lbl_map.Text = "Map";
            // 
            // cb_respawn_point
            // 
            this.cb_respawn_point.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_respawn_point.FormattingEnabled = true;
            this.cb_respawn_point.Location = new System.Drawing.Point(330, 113);
            this.cb_respawn_point.Name = "cb_respawn_point";
            this.cb_respawn_point.Size = new System.Drawing.Size(229, 28);
            this.cb_respawn_point.TabIndex = 65;
            // 
            // cb_map
            // 
            this.cb_map.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_map.FormattingEnabled = true;
            this.cb_map.Location = new System.Drawing.Point(330, 13);
            this.cb_map.Name = "cb_map";
            this.cb_map.Size = new System.Drawing.Size(229, 28);
            this.cb_map.TabIndex = 64;
            // 
            // chk_trespawn
            // 
            this.chk_trespawn.AutoSize = true;
            this.chk_trespawn.Location = new System.Drawing.Point(330, 333);
            this.chk_trespawn.Name = "chk_trespawn";
            this.chk_trespawn.Size = new System.Drawing.Size(170, 24);
            this.chk_trespawn.TabIndex = 62;
            this.chk_trespawn.Text = "Titan Respawn Mode";
            this.chk_trespawn.UseVisualStyleBackColor = true;
            // 
            // chk_noroll
            // 
            this.chk_noroll.AutoSize = true;
            this.chk_noroll.Location = new System.Drawing.Point(330, 273);
            this.chk_noroll.Name = "chk_noroll";
            this.chk_noroll.Size = new System.Drawing.Size(124, 24);
            this.chk_noroll.TabIndex = 61;
            this.chk_noroll.Text = "No Roll Mode";
            this.chk_noroll.UseVisualStyleBackColor = true;
            // 
            // chk_truth
            // 
            this.chk_truth.AutoSize = true;
            this.chk_truth.Location = new System.Drawing.Point(330, 303);
            this.chk_truth.Name = "chk_truth";
            this.chk_truth.Size = new System.Drawing.Size(107, 24);
            this.chk_truth.TabIndex = 60;
            this.chk_truth.Text = "Truth Mode";
            this.chk_truth.UseVisualStyleBackColor = true;
            // 
            // chk_iron
            // 
            this.chk_iron.AutoSize = true;
            this.chk_iron.Location = new System.Drawing.Point(330, 243);
            this.chk_iron.Name = "chk_iron";
            this.chk_iron.Size = new System.Drawing.Size(100, 24);
            this.chk_iron.TabIndex = 59;
            this.chk_iron.Text = "Iron Mode";
            this.chk_iron.UseVisualStyleBackColor = true;
            // 
            // chk_hard
            // 
            this.chk_hard.AutoSize = true;
            this.chk_hard.Location = new System.Drawing.Point(330, 213);
            this.chk_hard.Name = "chk_hard";
            this.chk_hard.Size = new System.Drawing.Size(107, 24);
            this.chk_hard.TabIndex = 58;
            this.chk_hard.Text = "Hard Mode";
            this.chk_hard.UseVisualStyleBackColor = true;
            // 
            // num_kills
            // 
            this.num_kills.Location = new System.Drawing.Point(330, 147);
            this.num_kills.Name = "num_kills";
            this.num_kills.Size = new System.Drawing.Size(150, 27);
            this.num_kills.TabIndex = 57;
            this.num_kills.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_deaths
            // 
            this.num_deaths.Location = new System.Drawing.Point(330, 180);
            this.num_deaths.Name = "num_deaths";
            this.num_deaths.Size = new System.Drawing.Size(150, 27);
            this.num_deaths.TabIndex = 56;
            this.num_deaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tp_titans
            // 
            this.tp_titans.Controls.Add(this.chk_eyecube2_dead);
            this.tp_titans.Controls.Add(this.chk_plant12_dead);
            this.tp_titans.Controls.Add(this.chk_truth_dead);
            this.tp_titans.Controls.Add(this.chk_elder_dead);
            this.tp_titans.Controls.Add(this.chk_ghost_dead);
            this.tp_titans.Controls.Add(this.chk_thesoul_dead);
            this.tp_titans.Controls.Add(this.chk_guardian_dead);
            this.tp_titans.Controls.Add(this.chk_snowface_dead);
            this.tp_titans.Controls.Add(this.chk_onyx_dead);
            this.tp_titans.Controls.Add(this.chk_yeti_dead);
            this.tp_titans.Controls.Add(this.chk_roller_dead);
            this.tp_titans.Controls.Add(this.chk_ironknuckle_dead);
            this.tp_titans.Controls.Add(this.chk_bomber_dead);
            this.tp_titans.Controls.Add(this.chk_avarice_dead);
            this.tp_titans.Controls.Add(this.chk_knight_dead);
            this.tp_titans.Controls.Add(this.chk_plant_dead);
            this.tp_titans.Controls.Add(this.chk_mushroom_dead);
            this.tp_titans.Controls.Add(this.chk_colossus_dead);
            this.tp_titans.Controls.Add(this.chk_brainfreeze_dead);
            this.tp_titans.Controls.Add(this.chk_eyecube_dead);
            this.tp_titans.Controls.Add(this.chk_sludgeheart_dead);
            this.tp_titans.Location = new System.Drawing.Point(4, 29);
            this.tp_titans.Name = "tp_titans";
            this.tp_titans.Padding = new System.Windows.Forms.Padding(3);
            this.tp_titans.Size = new System.Drawing.Size(746, 374);
            this.tp_titans.TabIndex = 1;
            this.tp_titans.Text = "Titans";
            this.tp_titans.UseVisualStyleBackColor = true;
            // 
            // chk_eyecube2_dead
            // 
            this.chk_eyecube2_dead.AutoSize = true;
            this.chk_eyecube2_dead.Location = new System.Drawing.Point(182, 76);
            this.chk_eyecube2_dead.Name = "chk_eyecube2_dead";
            this.chk_eyecube2_dead.Size = new System.Drawing.Size(134, 24);
            this.chk_eyecube2_dead.TabIndex = 74;
            this.chk_eyecube2_dead.Text = "Eyecube2 Dead";
            this.chk_eyecube2_dead.UseVisualStyleBackColor = true;
            // 
            // chk_plant12_dead
            // 
            this.chk_plant12_dead.AutoSize = true;
            this.chk_plant12_dead.Location = new System.Drawing.Point(182, 226);
            this.chk_plant12_dead.Name = "chk_plant12_dead";
            this.chk_plant12_dead.Size = new System.Drawing.Size(120, 24);
            this.chk_plant12_dead.TabIndex = 73;
            this.chk_plant12_dead.Text = "Plant12 Dead";
            this.chk_plant12_dead.UseVisualStyleBackColor = true;
            // 
            // chk_truth_dead
            // 
            this.chk_truth_dead.AutoSize = true;
            this.chk_truth_dead.Location = new System.Drawing.Point(419, 286);
            this.chk_truth_dead.Name = "chk_truth_dead";
            this.chk_truth_dead.Size = new System.Drawing.Size(104, 24);
            this.chk_truth_dead.TabIndex = 72;
            this.chk_truth_dead.Text = "Truth Dead";
            this.chk_truth_dead.UseVisualStyleBackColor = true;
            // 
            // chk_elder_dead
            // 
            this.chk_elder_dead.AutoSize = true;
            this.chk_elder_dead.Location = new System.Drawing.Point(419, 16);
            this.chk_elder_dead.Name = "chk_elder_dead";
            this.chk_elder_dead.Size = new System.Drawing.Size(105, 24);
            this.chk_elder_dead.TabIndex = 71;
            this.chk_elder_dead.Text = "Elder Dead";
            this.chk_elder_dead.UseVisualStyleBackColor = true;
            // 
            // chk_ghost_dead
            // 
            this.chk_ghost_dead.AutoSize = true;
            this.chk_ghost_dead.Location = new System.Drawing.Point(182, 316);
            this.chk_ghost_dead.Name = "chk_ghost_dead";
            this.chk_ghost_dead.Size = new System.Drawing.Size(109, 24);
            this.chk_ghost_dead.TabIndex = 70;
            this.chk_ghost_dead.Text = "Ghost Dead";
            this.chk_ghost_dead.UseVisualStyleBackColor = true;
            // 
            // chk_thesoul_dead
            // 
            this.chk_thesoul_dead.AutoSize = true;
            this.chk_thesoul_dead.Location = new System.Drawing.Point(419, 256);
            this.chk_thesoul_dead.Name = "chk_thesoul_dead";
            this.chk_thesoul_dead.Size = new System.Drawing.Size(128, 24);
            this.chk_thesoul_dead.TabIndex = 69;
            this.chk_thesoul_dead.Text = "The Soul Dead";
            this.chk_thesoul_dead.UseVisualStyleBackColor = true;
            // 
            // chk_guardian_dead
            // 
            this.chk_guardian_dead.AutoSize = true;
            this.chk_guardian_dead.Location = new System.Drawing.Point(419, 226);
            this.chk_guardian_dead.Name = "chk_guardian_dead";
            this.chk_guardian_dead.Size = new System.Drawing.Size(131, 24);
            this.chk_guardian_dead.TabIndex = 68;
            this.chk_guardian_dead.Text = "Guardian Dead";
            this.chk_guardian_dead.UseVisualStyleBackColor = true;
            // 
            // chk_snowface_dead
            // 
            this.chk_snowface_dead.AutoSize = true;
            this.chk_snowface_dead.Location = new System.Drawing.Point(419, 196);
            this.chk_snowface_dead.Name = "chk_snowface_dead";
            this.chk_snowface_dead.Size = new System.Drawing.Size(135, 24);
            this.chk_snowface_dead.TabIndex = 67;
            this.chk_snowface_dead.Text = "Snowface Dead";
            this.chk_snowface_dead.UseVisualStyleBackColor = true;
            // 
            // chk_onyx_dead
            // 
            this.chk_onyx_dead.AutoSize = true;
            this.chk_onyx_dead.Location = new System.Drawing.Point(419, 166);
            this.chk_onyx_dead.Name = "chk_onyx_dead";
            this.chk_onyx_dead.Size = new System.Drawing.Size(104, 24);
            this.chk_onyx_dead.TabIndex = 66;
            this.chk_onyx_dead.Text = "Onyx Dead";
            this.chk_onyx_dead.UseVisualStyleBackColor = true;
            // 
            // chk_yeti_dead
            // 
            this.chk_yeti_dead.AutoSize = true;
            this.chk_yeti_dead.Location = new System.Drawing.Point(419, 136);
            this.chk_yeti_dead.Name = "chk_yeti_dead";
            this.chk_yeti_dead.Size = new System.Drawing.Size(95, 24);
            this.chk_yeti_dead.TabIndex = 65;
            this.chk_yeti_dead.Text = "Yeti Dead";
            this.chk_yeti_dead.UseVisualStyleBackColor = true;
            // 
            // chk_roller_dead
            // 
            this.chk_roller_dead.AutoSize = true;
            this.chk_roller_dead.Location = new System.Drawing.Point(419, 106);
            this.chk_roller_dead.Name = "chk_roller_dead";
            this.chk_roller_dead.Size = new System.Drawing.Size(110, 24);
            this.chk_roller_dead.TabIndex = 64;
            this.chk_roller_dead.Text = "Roller Dead";
            this.chk_roller_dead.UseVisualStyleBackColor = true;
            // 
            // chk_ironknuckle_dead
            // 
            this.chk_ironknuckle_dead.AutoSize = true;
            this.chk_ironknuckle_dead.Location = new System.Drawing.Point(419, 76);
            this.chk_ironknuckle_dead.Name = "chk_ironknuckle_dead";
            this.chk_ironknuckle_dead.Size = new System.Drawing.Size(146, 24);
            this.chk_ironknuckle_dead.TabIndex = 63;
            this.chk_ironknuckle_dead.Text = "Ironknuckle Dead";
            this.chk_ironknuckle_dead.UseVisualStyleBackColor = true;
            // 
            // chk_bomber_dead
            // 
            this.chk_bomber_dead.AutoSize = true;
            this.chk_bomber_dead.Location = new System.Drawing.Point(419, 46);
            this.chk_bomber_dead.Name = "chk_bomber_dead";
            this.chk_bomber_dead.Size = new System.Drawing.Size(124, 24);
            this.chk_bomber_dead.TabIndex = 62;
            this.chk_bomber_dead.Text = "Bomber Dead";
            this.chk_bomber_dead.UseVisualStyleBackColor = true;
            // 
            // chk_avarice_dead
            // 
            this.chk_avarice_dead.AutoSize = true;
            this.chk_avarice_dead.Location = new System.Drawing.Point(182, 286);
            this.chk_avarice_dead.Name = "chk_avarice_dead";
            this.chk_avarice_dead.Size = new System.Drawing.Size(120, 24);
            this.chk_avarice_dead.TabIndex = 61;
            this.chk_avarice_dead.Text = "Avarice Dead";
            this.chk_avarice_dead.UseVisualStyleBackColor = true;
            // 
            // chk_knight_dead
            // 
            this.chk_knight_dead.AutoSize = true;
            this.chk_knight_dead.Location = new System.Drawing.Point(182, 256);
            this.chk_knight_dead.Name = "chk_knight_dead";
            this.chk_knight_dead.Size = new System.Drawing.Size(114, 24);
            this.chk_knight_dead.TabIndex = 60;
            this.chk_knight_dead.Text = "Knight Dead";
            this.chk_knight_dead.UseVisualStyleBackColor = true;
            // 
            // chk_plant_dead
            // 
            this.chk_plant_dead.AutoSize = true;
            this.chk_plant_dead.Location = new System.Drawing.Point(182, 196);
            this.chk_plant_dead.Name = "chk_plant_dead";
            this.chk_plant_dead.Size = new System.Drawing.Size(104, 24);
            this.chk_plant_dead.TabIndex = 59;
            this.chk_plant_dead.Text = "Plant Dead";
            this.chk_plant_dead.UseVisualStyleBackColor = true;
            // 
            // chk_mushroom_dead
            // 
            this.chk_mushroom_dead.AutoSize = true;
            this.chk_mushroom_dead.Location = new System.Drawing.Point(182, 166);
            this.chk_mushroom_dead.Name = "chk_mushroom_dead";
            this.chk_mushroom_dead.Size = new System.Drawing.Size(142, 24);
            this.chk_mushroom_dead.TabIndex = 58;
            this.chk_mushroom_dead.Text = "Mushroom Dead";
            this.chk_mushroom_dead.UseVisualStyleBackColor = true;
            // 
            // chk_colossus_dead
            // 
            this.chk_colossus_dead.AutoSize = true;
            this.chk_colossus_dead.Location = new System.Drawing.Point(182, 136);
            this.chk_colossus_dead.Name = "chk_colossus_dead";
            this.chk_colossus_dead.Size = new System.Drawing.Size(128, 24);
            this.chk_colossus_dead.TabIndex = 57;
            this.chk_colossus_dead.Text = "Colossus Dead";
            this.chk_colossus_dead.UseVisualStyleBackColor = true;
            // 
            // chk_brainfreeze_dead
            // 
            this.chk_brainfreeze_dead.AutoSize = true;
            this.chk_brainfreeze_dead.Location = new System.Drawing.Point(182, 106);
            this.chk_brainfreeze_dead.Name = "chk_brainfreeze_dead";
            this.chk_brainfreeze_dead.Size = new System.Drawing.Size(146, 24);
            this.chk_brainfreeze_dead.TabIndex = 56;
            this.chk_brainfreeze_dead.Text = "Brainfreeze Dead";
            this.chk_brainfreeze_dead.UseVisualStyleBackColor = true;
            // 
            // chk_eyecube_dead
            // 
            this.chk_eyecube_dead.AutoSize = true;
            this.chk_eyecube_dead.Location = new System.Drawing.Point(182, 46);
            this.chk_eyecube_dead.Name = "chk_eyecube_dead";
            this.chk_eyecube_dead.Size = new System.Drawing.Size(126, 24);
            this.chk_eyecube_dead.TabIndex = 55;
            this.chk_eyecube_dead.Text = "Eyecube Dead";
            this.chk_eyecube_dead.UseVisualStyleBackColor = true;
            // 
            // chk_sludgeheart_dead
            // 
            this.chk_sludgeheart_dead.AutoSize = true;
            this.chk_sludgeheart_dead.Location = new System.Drawing.Point(182, 16);
            this.chk_sludgeheart_dead.Name = "chk_sludgeheart_dead";
            this.chk_sludgeheart_dead.Size = new System.Drawing.Size(151, 24);
            this.chk_sludgeheart_dead.TabIndex = 54;
            this.chk_sludgeheart_dead.Text = "Sludgeheart Dead";
            this.chk_sludgeheart_dead.UseVisualStyleBackColor = true;
            // 
            // tp_misc
            // 
            this.tp_misc.Controls.Add(this.chk_titan);
            this.tp_misc.Controls.Add(this.chk_truthdoorlook);
            this.tp_misc.Controls.Add(this.chk_kingtitan);
            this.tp_misc.Controls.Add(this.chk_king_started);
            this.tp_misc.Controls.Add(this.chk_floor2_door_open);
            this.tp_misc.Controls.Add(this.chk_icedoor);
            this.tp_misc.Controls.Add(this.chk_avarice_switch);
            this.tp_misc.Controls.Add(this.chk_floor1_door_open);
            this.tp_misc.Controls.Add(this.chk_colossus_door);
            this.tp_misc.Controls.Add(this.chk_brain_door);
            this.tp_misc.Controls.Add(this.chk_eyecube_door);
            this.tp_misc.Controls.Add(this.chk_sludge_door);
            this.tp_misc.Controls.Add(this.chk_tutorial_door);
            this.tp_misc.Controls.Add(this.chk_start_eyedoor);
            this.tp_misc.Controls.Add(this.chk_tut_switch);
            this.tp_misc.Controls.Add(this.chk_gamestarted);
            this.tp_misc.Location = new System.Drawing.Point(4, 29);
            this.tp_misc.Name = "tp_misc";
            this.tp_misc.Size = new System.Drawing.Size(746, 374);
            this.tp_misc.TabIndex = 2;
            this.tp_misc.Text = "Misc. Flags";
            this.tp_misc.UseVisualStyleBackColor = true;
            // 
            // chk_titan
            // 
            this.chk_titan.AutoSize = true;
            this.chk_titan.Location = new System.Drawing.Point(419, 226);
            this.chk_titan.Name = "chk_titan";
            this.chk_titan.Size = new System.Drawing.Size(64, 24);
            this.chk_titan.TabIndex = 36;
            this.chk_titan.Text = "Titan";
            this.chk_titan.UseVisualStyleBackColor = true;
            // 
            // chk_truthdoorlook
            // 
            this.chk_truthdoorlook.AutoSize = true;
            this.chk_truthdoorlook.Location = new System.Drawing.Point(419, 196);
            this.chk_truthdoorlook.Name = "chk_truthdoorlook";
            this.chk_truthdoorlook.Size = new System.Drawing.Size(138, 24);
            this.chk_truthdoorlook.TabIndex = 35;
            this.chk_truthdoorlook.Text = "Truth Door Look";
            this.chk_truthdoorlook.UseVisualStyleBackColor = true;
            // 
            // chk_kingtitan
            // 
            this.chk_kingtitan.AutoSize = true;
            this.chk_kingtitan.Location = new System.Drawing.Point(419, 166);
            this.chk_kingtitan.Name = "chk_kingtitan";
            this.chk_kingtitan.Size = new System.Drawing.Size(98, 24);
            this.chk_kingtitan.TabIndex = 34;
            this.chk_kingtitan.Text = "King Titan";
            this.chk_kingtitan.UseVisualStyleBackColor = true;
            // 
            // chk_king_started
            // 
            this.chk_king_started.AutoSize = true;
            this.chk_king_started.Location = new System.Drawing.Point(419, 136);
            this.chk_king_started.Name = "chk_king_started";
            this.chk_king_started.Size = new System.Drawing.Size(113, 24);
            this.chk_king_started.TabIndex = 33;
            this.chk_king_started.Text = "King Started";
            this.chk_king_started.UseVisualStyleBackColor = true;
            // 
            // chk_floor2_door_open
            // 
            this.chk_floor2_door_open.AutoSize = true;
            this.chk_floor2_door_open.Location = new System.Drawing.Point(419, 106);
            this.chk_floor2_door_open.Name = "chk_floor2_door_open";
            this.chk_floor2_door_open.Size = new System.Drawing.Size(151, 24);
            this.chk_floor2_door_open.TabIndex = 32;
            this.chk_floor2_door_open.Text = "Floor2 Door Open";
            this.chk_floor2_door_open.UseVisualStyleBackColor = true;
            // 
            // chk_icedoor
            // 
            this.chk_icedoor.AutoSize = true;
            this.chk_icedoor.Location = new System.Drawing.Point(419, 76);
            this.chk_icedoor.Name = "chk_icedoor";
            this.chk_icedoor.Size = new System.Drawing.Size(88, 24);
            this.chk_icedoor.TabIndex = 31;
            this.chk_icedoor.Text = "Ice Door";
            this.chk_icedoor.UseVisualStyleBackColor = true;
            // 
            // chk_avarice_switch
            // 
            this.chk_avarice_switch.AutoSize = true;
            this.chk_avarice_switch.Location = new System.Drawing.Point(419, 46);
            this.chk_avarice_switch.Name = "chk_avarice_switch";
            this.chk_avarice_switch.Size = new System.Drawing.Size(127, 24);
            this.chk_avarice_switch.TabIndex = 30;
            this.chk_avarice_switch.Text = "Avarice Switch";
            this.chk_avarice_switch.UseVisualStyleBackColor = true;
            // 
            // chk_floor1_door_open
            // 
            this.chk_floor1_door_open.AutoSize = true;
            this.chk_floor1_door_open.Location = new System.Drawing.Point(419, 16);
            this.chk_floor1_door_open.Name = "chk_floor1_door_open";
            this.chk_floor1_door_open.Size = new System.Drawing.Size(151, 24);
            this.chk_floor1_door_open.TabIndex = 29;
            this.chk_floor1_door_open.Text = "Floor1 Door Open";
            this.chk_floor1_door_open.UseVisualStyleBackColor = true;
            // 
            // chk_colossus_door
            // 
            this.chk_colossus_door.AutoSize = true;
            this.chk_colossus_door.Location = new System.Drawing.Point(182, 226);
            this.chk_colossus_door.Name = "chk_colossus_door";
            this.chk_colossus_door.Size = new System.Drawing.Size(126, 24);
            this.chk_colossus_door.TabIndex = 28;
            this.chk_colossus_door.Text = "Colossus Door";
            this.chk_colossus_door.UseVisualStyleBackColor = true;
            // 
            // chk_brain_door
            // 
            this.chk_brain_door.AutoSize = true;
            this.chk_brain_door.Location = new System.Drawing.Point(182, 196);
            this.chk_brain_door.Name = "chk_brain_door";
            this.chk_brain_door.Size = new System.Drawing.Size(103, 24);
            this.chk_brain_door.TabIndex = 27;
            this.chk_brain_door.Text = "Brain Door";
            this.chk_brain_door.UseVisualStyleBackColor = true;
            // 
            // chk_eyecube_door
            // 
            this.chk_eyecube_door.AutoSize = true;
            this.chk_eyecube_door.Location = new System.Drawing.Point(182, 166);
            this.chk_eyecube_door.Name = "chk_eyecube_door";
            this.chk_eyecube_door.Size = new System.Drawing.Size(124, 24);
            this.chk_eyecube_door.TabIndex = 26;
            this.chk_eyecube_door.Text = "Eyecube Door";
            this.chk_eyecube_door.UseVisualStyleBackColor = true;
            // 
            // chk_sludge_door
            // 
            this.chk_sludge_door.AutoSize = true;
            this.chk_sludge_door.Location = new System.Drawing.Point(182, 136);
            this.chk_sludge_door.Name = "chk_sludge_door";
            this.chk_sludge_door.Size = new System.Drawing.Size(149, 24);
            this.chk_sludge_door.TabIndex = 25;
            this.chk_sludge_door.Text = "Sludgeheart Door";
            this.chk_sludge_door.UseVisualStyleBackColor = true;
            // 
            // chk_tutorial_door
            // 
            this.chk_tutorial_door.AutoSize = true;
            this.chk_tutorial_door.Location = new System.Drawing.Point(182, 106);
            this.chk_tutorial_door.Name = "chk_tutorial_door";
            this.chk_tutorial_door.Size = new System.Drawing.Size(120, 24);
            this.chk_tutorial_door.TabIndex = 24;
            this.chk_tutorial_door.Text = "Tutorial Door";
            this.chk_tutorial_door.UseVisualStyleBackColor = true;
            // 
            // chk_start_eyedoor
            // 
            this.chk_start_eyedoor.AutoSize = true;
            this.chk_start_eyedoor.Location = new System.Drawing.Point(182, 76);
            this.chk_start_eyedoor.Name = "chk_start_eyedoor";
            this.chk_start_eyedoor.Size = new System.Drawing.Size(121, 24);
            this.chk_start_eyedoor.TabIndex = 23;
            this.chk_start_eyedoor.Text = "Start Eyedoor";
            this.chk_start_eyedoor.UseVisualStyleBackColor = true;
            // 
            // chk_tut_switch
            // 
            this.chk_tut_switch.AutoSize = true;
            this.chk_tut_switch.Location = new System.Drawing.Point(182, 46);
            this.chk_tut_switch.Name = "chk_tut_switch";
            this.chk_tut_switch.Size = new System.Drawing.Size(129, 24);
            this.chk_tut_switch.TabIndex = 22;
            this.chk_tut_switch.Text = "Tutorial Switch";
            this.chk_tut_switch.UseVisualStyleBackColor = true;
            // 
            // chk_gamestarted
            // 
            this.chk_gamestarted.AutoSize = true;
            this.chk_gamestarted.Location = new System.Drawing.Point(182, 16);
            this.chk_gamestarted.Name = "chk_gamestarted";
            this.chk_gamestarted.Size = new System.Drawing.Size(122, 24);
            this.chk_gamestarted.TabIndex = 21;
            this.chk_gamestarted.Text = "Game Started";
            this.chk_gamestarted.UseVisualStyleBackColor = true;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(17, 506);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(69, 20);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "File Time";
            // 
            // txt_time
            // 
            this.txt_time.Enabled = false;
            this.txt_time.Location = new System.Drawing.Point(92, 503);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(125, 27);
            this.txt_time.TabIndex = 4;
            // 
            // txt_hash
            // 
            this.txt_hash.Enabled = false;
            this.txt_hash.Location = new System.Drawing.Point(409, 503);
            this.txt_hash.Name = "txt_hash";
            this.txt_hash.Size = new System.Drawing.Size(357, 27);
            this.txt_hash.TabIndex = 5;
            // 
            // lbl_hash
            // 
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.Location = new System.Drawing.Point(331, 506);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(72, 20);
            this.lbl_hash.TabIndex = 6;
            this.lbl_hash.Text = "File Hash:";
            // 
            // gb_file
            // 
            this.gb_file.Controls.Add(this.lbl_current_file);
            this.gb_file.Controls.Add(this.lbl_file_saved);
            this.gb_file.Controls.Add(this.btn_discard);
            this.gb_file.Controls.Add(this.lbl_file_name);
            this.gb_file.Controls.Add(this.btn_save);
            this.gb_file.Controls.Add(this.tc_save_file);
            this.gb_file.Controls.Add(this.lbl_hash);
            this.gb_file.Controls.Add(this.lbl_time);
            this.gb_file.Controls.Add(this.txt_hash);
            this.gb_file.Controls.Add(this.txt_time);
            this.gb_file.Enabled = false;
            this.gb_file.Location = new System.Drawing.Point(12, 31);
            this.gb_file.Name = "gb_file";
            this.gb_file.Size = new System.Drawing.Size(776, 592);
            this.gb_file.TabIndex = 7;
            this.gb_file.TabStop = false;
            this.gb_file.Text = "Save File Information";
            // 
            // lbl_current_file
            // 
            this.lbl_current_file.AutoSize = true;
            this.lbl_current_file.Location = new System.Drawing.Point(17, 40);
            this.lbl_current_file.Name = "lbl_current_file";
            this.lbl_current_file.Size = new System.Drawing.Size(87, 20);
            this.lbl_current_file.TabIndex = 9;
            this.lbl_current_file.Text = "Current File:";
            // 
            // lbl_file_saved
            // 
            this.lbl_file_saved.AutoSize = true;
            this.lbl_file_saved.Location = new System.Drawing.Point(409, 555);
            this.lbl_file_saved.Name = "lbl_file_saved";
            this.lbl_file_saved.Size = new System.Drawing.Size(78, 20);
            this.lbl_file_saved.TabIndex = 14;
            this.lbl_file_saved.Text = "File saved!";
            this.lbl_file_saved.Visible = false;
            // 
            // btn_discard
            // 
            this.btn_discard.Location = new System.Drawing.Point(636, 551);
            this.btn_discard.Name = "btn_discard";
            this.btn_discard.Size = new System.Drawing.Size(130, 29);
            this.btn_discard.TabIndex = 13;
            this.btn_discard.Text = "Discard Changes";
            this.btn_discard.UseVisualStyleBackColor = true;
            this.btn_discard.Click += new System.EventHandler(this.btn_discard_Click);
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_file_name.Location = new System.Drawing.Point(110, 40);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_file_name.Size = new System.Drawing.Size(656, 22);
            this.lbl_file_name.TabIndex = 1;
            this.lbl_file_name.Text = "no save file";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(500, 551);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 29);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // nav_menu_strip
            // 
            this.nav_menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nav_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_nav_file});
            this.nav_menu_strip.Location = new System.Drawing.Point(0, 0);
            this.nav_menu_strip.Name = "nav_menu_strip";
            this.nav_menu_strip.Size = new System.Drawing.Size(798, 28);
            this.nav_menu_strip.TabIndex = 8;
            // 
            // menu_nav_file
            // 
            this.menu_nav_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_nav_file_new,
            this.menu_nav_file_open,
            this.menu_nav_file_save,
            this.menu_nav_file_save_as});
            this.menu_nav_file.Name = "menu_nav_file";
            this.menu_nav_file.Size = new System.Drawing.Size(46, 24);
            this.menu_nav_file.Text = "File";
            // 
            // menu_nav_file_new
            // 
            this.menu_nav_file_new.Name = "menu_nav_file_new";
            this.menu_nav_file_new.Size = new System.Drawing.Size(152, 26);
            this.menu_nav_file_new.Text = "New";
            // 
            // menu_nav_file_open
            // 
            this.menu_nav_file_open.Name = "menu_nav_file_open";
            this.menu_nav_file_open.Size = new System.Drawing.Size(152, 26);
            this.menu_nav_file_open.Text = "Open...";
            // 
            // menu_nav_file_save
            // 
            this.menu_nav_file_save.Name = "menu_nav_file_save";
            this.menu_nav_file_save.Size = new System.Drawing.Size(152, 26);
            this.menu_nav_file_save.Text = "Save";
            // 
            // menu_nav_file_save_as
            // 
            this.menu_nav_file_save_as.Name = "menu_nav_file_save_as";
            this.menu_nav_file_save_as.Size = new System.Drawing.Size(152, 26);
            this.menu_nav_file_save_as.Text = "Save As...";
            // 
            // save_file_dialog
            // 
            this.save_file_dialog.DefaultExt = "txt";
            this.save_file_dialog.Filter = "Text documents (.txt)|*.txt";
            this.save_file_dialog.Title = "Save File...";
            // 
            // timer_lbl_file_changed
            // 
            this.timer_lbl_file_changed.Interval = 4000;
            // 
            // SaveEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 635);
            this.Controls.Add(this.gb_file);
            this.Controls.Add(this.nav_menu_strip);
            this.MainMenuStrip = this.nav_menu_strip;
            this.MaximizeBox = false;
            this.Name = "SaveEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titan Souls Save Editor";
            this.Load += new System.EventHandler(this.SaveEditorForm_Load);
            this.tc_save_file.ResumeLayout(false);
            this.tp_general.ResumeLayout(false);
            this.tp_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_player_position_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_player_position_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_deaths)).EndInit();
            this.tp_titans.ResumeLayout(false);
            this.tp_titans.PerformLayout();
            this.tp_misc.ResumeLayout(false);
            this.tp_misc.PerformLayout();
            this.gb_file.ResumeLayout(false);
            this.gb_file.PerformLayout();
            this.nav_menu_strip.ResumeLayout(false);
            this.nav_menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.TabControl tc_save_file;
        private System.Windows.Forms.TabPage tp_general;
        private System.Windows.Forms.TabPage tp_titans;
        private System.Windows.Forms.TabPage tp_misc;
        private System.Windows.Forms.NumericUpDown num_player_position_y;
        private System.Windows.Forms.NumericUpDown num_player_position_x;
        private System.Windows.Forms.Label lbl_deaths;
        private System.Windows.Forms.Label lbl_kills;
        private System.Windows.Forms.Label lbl_respawn_point;
        private System.Windows.Forms.Label lbl_player_position_y;
        private System.Windows.Forms.Label lbl_player_position_x;
        private System.Windows.Forms.Label lbl_player_position;
        private System.Windows.Forms.Label lbl_map;
        private System.Windows.Forms.ComboBox cb_respawn_point;
        private System.Windows.Forms.ComboBox cb_map;
        private System.Windows.Forms.CheckBox chk_trespawn;
        private System.Windows.Forms.CheckBox chk_noroll;
        private System.Windows.Forms.CheckBox chk_truth;
        private System.Windows.Forms.CheckBox chk_iron;
        private System.Windows.Forms.CheckBox chk_hard;
        private System.Windows.Forms.NumericUpDown num_kills;
        private System.Windows.Forms.NumericUpDown num_deaths;
        private System.Windows.Forms.CheckBox chk_eyecube2_dead;
        private System.Windows.Forms.CheckBox chk_plant12_dead;
        private System.Windows.Forms.CheckBox chk_truth_dead;
        private System.Windows.Forms.CheckBox chk_elder_dead;
        private System.Windows.Forms.CheckBox chk_ghost_dead;
        private System.Windows.Forms.CheckBox chk_thesoul_dead;
        private System.Windows.Forms.CheckBox chk_guardian_dead;
        private System.Windows.Forms.CheckBox chk_snowface_dead;
        private System.Windows.Forms.CheckBox chk_onyx_dead;
        private System.Windows.Forms.CheckBox chk_yeti_dead;
        private System.Windows.Forms.CheckBox chk_roller_dead;
        private System.Windows.Forms.CheckBox chk_ironknuckle_dead;
        private System.Windows.Forms.CheckBox chk_bomber_dead;
        private System.Windows.Forms.CheckBox chk_avarice_dead;
        private System.Windows.Forms.CheckBox chk_knight_dead;
        private System.Windows.Forms.CheckBox chk_plant_dead;
        private System.Windows.Forms.CheckBox chk_mushroom_dead;
        private System.Windows.Forms.CheckBox chk_colossus_dead;
        private System.Windows.Forms.CheckBox chk_brainfreeze_dead;
        private System.Windows.Forms.CheckBox chk_eyecube_dead;
        private System.Windows.Forms.CheckBox chk_sludgeheart_dead;
        private System.Windows.Forms.CheckBox chk_titan;
        private System.Windows.Forms.CheckBox chk_truthdoorlook;
        private System.Windows.Forms.CheckBox chk_kingtitan;
        private System.Windows.Forms.CheckBox chk_king_started;
        private System.Windows.Forms.CheckBox chk_floor2_door_open;
        private System.Windows.Forms.CheckBox chk_icedoor;
        private System.Windows.Forms.CheckBox chk_avarice_switch;
        private System.Windows.Forms.CheckBox chk_floor1_door_open;
        private System.Windows.Forms.CheckBox chk_colossus_door;
        private System.Windows.Forms.CheckBox chk_brain_door;
        private System.Windows.Forms.CheckBox chk_eyecube_door;
        private System.Windows.Forms.CheckBox chk_sludge_door;
        private System.Windows.Forms.CheckBox chk_tutorial_door;
        private System.Windows.Forms.CheckBox chk_start_eyedoor;
        private System.Windows.Forms.CheckBox chk_tut_switch;
        private System.Windows.Forms.CheckBox chk_gamestarted;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_hash;
        private System.Windows.Forms.Label lbl_hash;
        private System.Windows.Forms.GroupBox gb_file;
        private System.Windows.Forms.MenuStrip nav_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem menu_nav_file;
        private System.Windows.Forms.ToolStripMenuItem menu_nav_file_open;
        private System.Windows.Forms.ToolStripMenuItem menu_nav_file_save;
        private System.Windows.Forms.ToolStripMenuItem menu_nav_file_save_as;
        private System.Windows.Forms.ToolStripMenuItem menu_nav_file_new;
        private System.Windows.Forms.SaveFileDialog save_file_dialog;
        private System.Windows.Forms.Button btn_discard;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolStripMenuItem menu_nav_help;
        private System.Windows.Forms.ToolTip tt_respawn_point;
        private System.Windows.Forms.Label lbl_map_tt;
        private System.Windows.Forms.ToolTip tt_map;
        private System.Windows.Forms.ToolTip tt_player_position;
        private System.Windows.Forms.ToolTip tt_titan_respawn_mode;
        private System.Windows.Forms.Label lbl_respawn_point_tt;
        private System.Windows.Forms.Label lbl_player_position_tt;
        private System.Windows.Forms.Label lbl_file_saved;
        private System.Windows.Forms.Timer timer_lbl_file_changed;
        private System.Windows.Forms.Button btn_clear_player_position;
        private System.Windows.Forms.Label lbl_current_file;
        private System.Windows.Forms.Label lbl_file_name;
    }
}