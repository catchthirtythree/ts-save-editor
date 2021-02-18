using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TitanSouls.Save;

namespace TitanSouls.Forms {
    public partial class SaveControl : UserControl, IObservable<FileSlot> {
        private List<IObserver<FileSlot>> Observers { get; }

        public SaveControl() {
            InitializeComponent();

            this.Observers = new List<IObserver<FileSlot>>();
        }

        public EditorState SelectedState {
            get {
                return (EditorState)cb_select_save.SelectedItem;
            }
        }

        public IDisposable Subscribe(IObserver<FileSlot> observer) {
            if (!this.Observers.Contains(observer)) {
                this.Observers.Add(observer);
                observer.OnNext(this.SelectedState.Id);
            }

            return new Unsubscriber<FileSlot>(this.Observers, observer);
        }

        private void SaveControl_Load(object sender, EventArgs e) {
            List<EditorState> slots = new List<EditorState> {
                new EditorState(FileSlot.First, FileSlot.First.ToString()),
                new EditorState(FileSlot.Second, FileSlot.Second.ToString()),
                new EditorState(FileSlot.Third, FileSlot.Third.ToString()),
                new EditorState(FileSlot.Fourth, FileSlot.Fourth.ToString())
            };

            cb_select_save.DataSource = slots;
            cb_select_save.ValueMember = "Id";
            cb_select_save.DisplayMember = "Name";
        }

        private void cb_select_save_SelectedIndexChanged(object sender, EventArgs e) {
            this.NotifyChange();
        }

        private void NotifyChange() {
            foreach (var observer in this.Observers) {
                observer.OnNext(this.SelectedState.Id);
            }
        }
    }
}
