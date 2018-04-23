using SmartHotel.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHotel.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public MenuViewModel MenuViewModel { get; set; }

        public MainViewModel()
        {
            MenuViewModel = new MenuViewModel();
        }
    }
}
