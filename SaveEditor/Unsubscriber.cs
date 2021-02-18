using System;
using System.Collections.Generic;
using System.Text;

namespace TitanSouls.Forms {
    public class Unsubscriber<T> : IDisposable {
        private List<IObserver<T>> Observers { get; }
        private IObserver<T> Observer { get; }

        public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer) {
            this.Observers = observers;
            this.Observer = observer;
        }

        public void Dispose() {
            if (this.Observer != null && this.Observers.Contains(this.Observer)) {
                this.Observers.Remove(this.Observer);
            }
        }
    }
}
