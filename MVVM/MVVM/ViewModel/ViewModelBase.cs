using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MVVM.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        protected ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var handle = this.PropertyChanged;
            if(handle != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handle(this, e);
            }
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        public virtual void OnDispose()
        {
        }
    }
}
