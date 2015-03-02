using System;
using System.Collections.ObjectModel;
using MVVM.DataAccess;

namespace MVVM.ViewModel
{
    public class DeviceListViewModel : ViewModelBase
    {
        readonly DeviceRepository _deviceRepository;

        public ObservableCollection<Model.Device> AllDevices
        {
            get;
            private set;
        }

        public DeviceListViewModel(DeviceRepository deviceRepository)
        {
            if (deviceRepository == null)
            {
                throw new ArgumentNullException("deviceRepository");
            }

            _deviceRepository = deviceRepository;
            this.AllDevices = new ObservableCollection<Model.Device>(_deviceRepository.GetDevices());
        }

        public override void OnDispose()
        {
            this.AllDevices.Clear();
        }
    }
}
