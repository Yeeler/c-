using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVM.DataAccess;

namespace MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        readonly DeviceRepository deviceRepository;

        ObservableCollection<ViewModelBase> viewModels;

        public MainWindowViewModel()
        {
            deviceRepository = new DeviceRepository();
            DeviceListViewModel deviceListViewModel = new DeviceListViewModel(deviceRepository);
            this.ViewModels.Add(deviceListViewModel);
        }

        public ObservableCollection<ViewModelBase> ViewModels 
        { 
            get
            {
                if (viewModels == null)
                {
                    viewModels = new ObservableCollection<ViewModelBase>();
                }
                return viewModels;
            }
        }
  

    }
}
