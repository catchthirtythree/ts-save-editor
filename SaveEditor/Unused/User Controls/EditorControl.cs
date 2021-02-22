using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TitanSouls.Save;
using TitanSouls.Save.Utils;

namespace TitanSouls.Forms {
    public partial class EditorControl : UserControl, IObserver<FileSlot> {
        // @TODO
        // User should add this somewhere.
        private readonly string PATH = @"C:\Program Files (x86)\Steam\steamapps\common\Titan Souls\data\SAVE\";

        private SaveFile SaveFile { get; set; }
        private FileSlot Slot { get; set; }

        public EditorControl() {
            InitializeComponent();

            SaveFile.FileChanged += OnFileChanged;
        }

        public void OnFileChanged(SaveFile file) {
            var data = file.GetData();

            this.SetFormElements(file, data);
        }

        public void OnCompleted() {
            throw new NotImplementedException();
        }

        public void OnError(Exception error) {
            throw new NotImplementedException();
        }

        public void OnNext(FileSlot slot) {
            this.Slot = slot;
            this.SaveFile = new SaveFile(this.PATH, slot);
         
            this.SetFormElements(this.SaveFile, this.SaveFile.GetData());
        }

        public void SetFormElements(SaveFile file, SaveData save_data) {
            // Player
            this.cb_map.SelectedIndex = this.cb_map.FindString(Map.Mappings[save_data.Map.Id].ToString());
            this.cb_respawn_point.SelectedIndex = this.cb_respawn_point.FindString(save_data.RespawnPoint.Id);
            this.txt_player_position_x.Text = save_data.PlayerPosition.X;
            this.txt_player_position_y.Text = save_data.PlayerPosition.Y;

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
            this.txt_time.Text = Convert.ToString(save_data.Time.Value);

            // Hash
            this.txt_hash.Text = file.GetHash();
        }

        public void StoreFormData() {
            var save_data = this.SaveFile.GetData();

            // Player
            save_data.Map.Id = Map.Mappings.GetKeyFromValue((MapId)cb_map.SelectedValue, "");
            save_data.RespawnPoint.Id = RespawnPoint.Mappings.GetKeyFromValue((RespawnPointId)cb_respawn_point.SelectedValue, "");
            save_data.PlayerPosition.X = this.txt_player_position_x.Text;
            save_data.PlayerPosition.Y = this.txt_player_position_y.Text;

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
            this.SaveFile.SetData(save_data);
        }

        private void btn_discard_changes_Click(object sender, EventArgs e) {
            this.SaveFile = new SaveFile(this.PATH, this.Slot);
            this.SetFormElements(this.SaveFile, this.SaveFile.GetData());
        }

        private void btn_save_file_Click(object sender, EventArgs e) {
            this.StoreFormData();
            this.SaveFile.Save();
        }

        private void btn_new_save_file_Click(object sender, EventArgs e) {
            this.SaveFile.SetData(SaveData.CreateEmptyData());
        }

        private void EditorControl_Load(object sender, EventArgs e) {
            cb_map.DataSource = Enum.GetValues(typeof(MapId));
            cb_respawn_point.DataSource = Enum.GetValues(typeof(RespawnPointId));
        }
    }
}
