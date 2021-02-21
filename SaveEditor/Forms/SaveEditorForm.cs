using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TitanSouls.Save;
using TitanSouls.Save.Utils;

namespace TitanSouls.Forms {
    public partial class SaveEditorForm : Form {
        private SaveFile File { get; set; }

        public SaveEditorForm() {
            InitializeComponent();

            this.menu_nav_file_new.Click += menu_nav_file_new_Click;
            this.menu_nav_file_open.Click += menu_nav_file_open_Click;
            this.menu_nav_file_save.Click += menu_nav_file_save_Click;
            this.menu_nav_file_save_as.Click += menu_nav_file_save_as_Click;

            this.num_player_position_x.Maximum = int.MaxValue;
            this.num_player_position_y.Maximum = int.MaxValue;
            this.num_kills.Maximum = int.MaxValue;
            this.num_deaths.Maximum = int.MaxValue;
            this.num_player_position_x.Minimum = -1;
            this.num_player_position_y.Minimum = -1;
            this.num_kills.Minimum = -1;
            this.num_deaths.Minimum = -1;

            this.tt_map.SetToolTip(lbl_map_tt,
                "The map the player will spawn into when the file loads / after death." +
                "\nno_map will start the player at the beginning of the game."
            );

            this.tt_player_position.SetToolTip(lbl_player_position_tt,
                "The x and y coordinate in which the player will spawn into when the file loads." +
                "\nThe origin (0, 0) is in the top-left of the screen." +
                "\nInputting negative numbers (-1, -1) or nothing will spawn the player at the entrance of the map."
            );

            this.tt_respawn_point.SetToolTip(lbl_respawn_point_tt,
                "Where the player respawns after death.\n" +
                "no_spawn will spawn the player at the entrance of the map on death."
            );

            this.timer_lbl_file_changed.Tick += new EventHandler((object Sender, EventArgs e) => {
                this.lbl_file_saved.Visible = false;
                this.timer_lbl_file_changed.Enabled = false;
            });
        }

        private void menu_nav_file_new_Click(object sender, EventArgs e) {
            this.SetSaveFile(new SaveFile());
        }

        private void menu_nav_file_open_Click(object sender, EventArgs e) {
            var result = open_file_dialog.ShowDialog();

            if (result == DialogResult.OK) { 
                this.SetSaveFile(new SaveFile(open_file_dialog.FileName));
            }

            Console.WriteLine(result);
        }

        private void menu_nav_file_save_Click(object sender, EventArgs e) {
            this.SaveFile(this.File.Path);
        }

        private void menu_nav_file_save_as_Click(object sender, EventArgs e) {
            this.SaveFileToLocation();
        }

        private void btn_save_Click(object sender, EventArgs e) {
            this.SaveFile(this.File.Path);
        }

        private void btn_discard_Click(object sender, EventArgs e) {
            this.File.SetData(this.File.GetData());
            this.SetFormElements(this.File);
        }

        private void SaveFile(string path) {
            if (path == null) {
                this.SaveFileToLocation();
            } else {
                this.StoreFormData();
                this.File.Save();
                this.SetSaveFile(this.File);
            }

            this.ToggleFileSavedMessage();
        }

        private void SaveFileToLocation() {
            var result = this.save_file_dialog.ShowDialog();

            if (result == DialogResult.OK) {
                this.StoreFormData();
                this.File.Save(this.save_file_dialog.FileName);
                this.SetSaveFile(this.File);
            }
        }

        private void ToggleFileSavedMessage() {
            this.timer_lbl_file_changed.Enabled = true;
            this.lbl_file_saved.Visible = true;
        }

        private void SetSaveFile(SaveFile file) {
            var save_file = file;

            this.File = save_file;

            this.lbl_file_name.Text = file.GetFilePath() ?? "new save file";
            this.gb_file.Enabled = true;

            this.SetFormElements(save_file);
        }

        public void SetFormElements(SaveFile file) {
            var save_data = file.GetData();

            // Player
            this.cb_map.SelectedIndex = this.cb_map.FindString(Map.Mappings[save_data.Map.Id].ToString());
            this.cb_respawn_point.SelectedIndex = this.cb_respawn_point.FindString(save_data.RespawnPoint.Id);
            this.num_player_position_x.Text = save_data.PlayerPosition.X;
            this.num_player_position_y.Text = save_data.PlayerPosition.Y;

            // Miscellaneous Flags
            this.chk_gamestarted.Checked = save_data.HasKey(KeyId.gamestarted);
            this.chk_tut_switch.Checked = save_data.HasKey(KeyId.tut_switch);
            this.chk_start_eyedoor.Checked = save_data.HasKey(KeyId.start_eyedoor);
            this.chk_tutorial_door.Checked = save_data.HasKey(KeyId.tutorial_door);
            this.chk_sludge_door.Checked = save_data.HasKey(KeyId.sludge_door);
            this.chk_eyecube_door.Checked = save_data.HasKey(KeyId.eyecube_door);
            this.chk_brain_door.Checked = save_data.HasKey(KeyId.brain_door);
            this.chk_colossus_door.Checked = save_data.HasKey(KeyId.colossus_door);
            this.chk_floor1_door_open.Checked = save_data.HasKey(KeyId.floor1_door_open);
            this.chk_avarice_switch.Checked = save_data.HasKey(KeyId.avarice_switch);
            this.chk_icedoor.Checked = save_data.HasKey(KeyId.icedoor);
            this.chk_floor2_door_open.Checked = save_data.HasKey(KeyId.floor2_door_open);
            this.chk_king_started.Checked = save_data.HasKey(KeyId.king_started);
            this.chk_kingtitan.Checked = save_data.HasKey(KeyId.kingtitan);
            this.chk_truthdoorlook.Checked = save_data.HasKey(KeyId.truthdoorlook);
            this.chk_titan.Checked = save_data.HasKey(KeyId.titan);

            // Titan Dead Flags
            this.chk_sludgeheart_dead.Checked = save_data.HasKey(KeyId.sludgeheart_dead);
            this.chk_brainfreeze_dead.Checked = save_data.HasKey(KeyId.brainfreeze_dead);
            this.chk_eyecube_dead.Checked = save_data.HasKey(KeyId.eyecube_dead);
            this.chk_eyecube2_dead.Checked = save_data.HasKey(KeyId.eyecube2_dead);
            this.chk_colossus_dead.Checked = save_data.HasKey(KeyId.colossus_dead);
            this.chk_mushroom_dead.Checked = save_data.HasKey(KeyId.mushroom_dead);
            this.chk_plant_dead.Checked = save_data.HasKey(KeyId.plant_dead);
            this.chk_plant12_dead.Checked = save_data.HasKey(KeyId.plant12_dead);
            this.chk_knight_dead.Checked = save_data.HasKey(KeyId.knight_dead);
            this.chk_avarice_dead.Checked = save_data.HasKey(KeyId.avarice_dead);
            this.chk_ghost_dead.Checked = save_data.HasKey(KeyId.ghost_dead);
            this.chk_elder_dead.Checked = save_data.HasKey(KeyId.elder_dead);
            this.chk_bomber_dead.Checked = save_data.HasKey(KeyId.bomber_dead);
            this.chk_ironknuckle_dead.Checked = save_data.HasKey(KeyId.ironknuckle_dead);
            this.chk_roller_dead.Checked = save_data.HasKey(KeyId.roller_dead);
            this.chk_yeti_dead.Checked = save_data.HasKey(KeyId.yeti_dead);
            this.chk_onyx_dead.Checked = save_data.HasKey(KeyId.onyx_dead);
            this.chk_snowface_dead.Checked = save_data.HasKey(KeyId.snowface_dead);
            this.chk_guardian_dead.Checked = save_data.HasKey(KeyId.guardian_dead);
            this.chk_thesoul_dead.Checked = save_data.HasKey(KeyId.thesoul_dead);
            this.chk_truth_dead.Checked = save_data.HasKey(KeyId.truth_dead);

            // Numbers
            this.num_deaths.Value = Convert.ToDecimal(save_data.PlayerDeaths.Count);
            this.num_kills.Value = Convert.ToDecimal(save_data.TitanKills.Count);

            // Modes
            this.chk_hard.Checked = Convert.ToBoolean(save_data.HardMode.Value);
            this.chk_iron.Checked = Convert.ToBoolean(save_data.IronMode.Value);
            this.chk_truth.Checked = Convert.ToBoolean(save_data.TruthMode.Value);
            this.chk_noroll.Checked = Convert.ToBoolean(save_data.NoRollMode.Value);
            this.chk_trespawn.Checked = Convert.ToBoolean(save_data.TitanRespawn.Value);

            // Time
            this.txt_time.Text = save_data.Time.ToReadableTime();

            // Hash
            this.txt_hash.Text = file.GetHash();
        }

        public void StoreFormData() {
            var save_data = this.File.GetData();

            // Player
            save_data.Map.Id = Map.Mappings.GetKeyFromValue((MapId)cb_map.SelectedValue, "");
            save_data.RespawnPoint.Id = RespawnPoint.Mappings.GetKeyFromValue((RespawnPointId)cb_respawn_point.SelectedValue, "");
            save_data.PlayerPosition.X = this.num_player_position_x.Text;
            save_data.PlayerPosition.Y = this.num_player_position_y.Text;

            // Miscellaneous Flags
            save_data.ToggleKey(KeyId.gamestarted, this.chk_gamestarted.Checked);
            save_data.ToggleKey(KeyId.tut_switch, this.chk_tut_switch.Checked);
            save_data.ToggleKey(KeyId.start_eyedoor, this.chk_start_eyedoor.Checked);
            save_data.ToggleKey(KeyId.tutorial_door, this.chk_tutorial_door.Checked);
            save_data.ToggleKey(KeyId.sludge_door, this.chk_sludge_door.Checked);
            save_data.ToggleKey(KeyId.eyecube_door, this.chk_eyecube_door.Checked);
            save_data.ToggleKey(KeyId.brain_door, this.chk_brain_door.Checked);
            save_data.ToggleKey(KeyId.colossus_door, this.chk_colossus_door.Checked);
            save_data.ToggleKey(KeyId.floor1_door_open, this.chk_floor1_door_open.Checked);
            save_data.ToggleKey(KeyId.avarice_switch, this.chk_avarice_switch.Checked);
            save_data.ToggleKey(KeyId.icedoor, this.chk_icedoor.Checked);
            save_data.ToggleKey(KeyId.floor2_door_open, this.chk_floor2_door_open.Checked);
            save_data.ToggleKey(KeyId.king_started, this.chk_king_started.Checked);
            save_data.ToggleKey(KeyId.kingtitan, this.chk_kingtitan.Checked);
            save_data.ToggleKey(KeyId.truthdoorlook, this.chk_truthdoorlook.Checked);
            save_data.ToggleKey(KeyId.titan, this.chk_titan.Checked);

            // Titan Dead Flags
            save_data.ToggleKey(KeyId.sludgeheart_dead, this.chk_sludgeheart_dead.Checked);
            save_data.ToggleKey(KeyId.brainfreeze_dead, this.chk_brainfreeze_dead.Checked);
            save_data.ToggleKey(KeyId.eyecube_dead, this.chk_eyecube_dead.Checked);
            save_data.ToggleKey(KeyId.eyecube2_dead, this.chk_eyecube2_dead.Checked);
            save_data.ToggleKey(KeyId.colossus_dead, this.chk_colossus_dead.Checked);
            save_data.ToggleKey(KeyId.mushroom_dead, this.chk_mushroom_dead.Checked);
            save_data.ToggleKey(KeyId.plant_dead, this.chk_plant_dead.Checked);
            save_data.ToggleKey(KeyId.plant12_dead, this.chk_plant12_dead.Checked);
            save_data.ToggleKey(KeyId.knight_dead, this.chk_knight_dead.Checked);
            save_data.ToggleKey(KeyId.avarice_dead, this.chk_avarice_dead.Checked);
            save_data.ToggleKey(KeyId.ghost_dead, this.chk_ghost_dead.Checked);
            save_data.ToggleKey(KeyId.elder_dead, this.chk_elder_dead.Checked);
            save_data.ToggleKey(KeyId.bomber_dead, this.chk_bomber_dead.Checked);
            save_data.ToggleKey(KeyId.ironknuckle_dead, this.chk_ironknuckle_dead.Checked);
            save_data.ToggleKey(KeyId.roller_dead, this.chk_roller_dead.Checked);
            save_data.ToggleKey(KeyId.yeti_dead, this.chk_yeti_dead.Checked);
            save_data.ToggleKey(KeyId.onyx_dead, this.chk_onyx_dead.Checked);
            save_data.ToggleKey(KeyId.snowface_dead, this.chk_snowface_dead.Checked);
            save_data.ToggleKey(KeyId.guardian_dead, this.chk_guardian_dead.Checked);
            save_data.ToggleKey(KeyId.thesoul_dead, this.chk_thesoul_dead.Checked);
            save_data.ToggleKey(KeyId.truth_dead, this.chk_truth_dead.Checked);

            // Numbers
            save_data.PlayerDeaths.Count = this.num_deaths.Value.ToString();
            save_data.TitanKills.Count = this.num_kills.Value.ToString();

            // Modes
            save_data.HardMode.Value = Convert.ToInt32(this.chk_hard.Checked);
            save_data.IronMode.Value = Convert.ToInt32(this.chk_iron.Checked);
            save_data.TruthMode.Value = Convert.ToInt32(this.chk_truth.Checked);
            save_data.NoRollMode.Value = Convert.ToInt32(this.chk_noroll.Checked);
            save_data.TitanRespawn.Value = Convert.ToInt32(this.chk_trespawn.Checked);

            // Update save data.
            this.File.SetData(save_data);
        }

        private void SaveEditorForm_Load(object sender, EventArgs e) {
            cb_map.DataSource = Enum.GetValues(typeof(MapId));
            cb_respawn_point.DataSource = Enum.GetValues(typeof(RespawnPointId));
        }

        private void btn_clear_player_position_Click(object sender, EventArgs e) {
            this.num_player_position_x.Text = "-1";
            this.num_player_position_y.Text = "-1";
        }
    }
}
