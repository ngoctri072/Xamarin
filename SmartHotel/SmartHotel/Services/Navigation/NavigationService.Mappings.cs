using System;
using System.Collections.Generic;
using System.Text;
using SmartHotel.ViewModels;
using SmartHotel.ViewModels.Base;
using SmartHotel.Views;
using Xamarin.Forms;

namespace SmartHotel.Services.Navigation
{
    public partial class NavigationService
    {
        private void Mappings()
        {
            Map<LoginViewModel, LoginView>();
            Map<MainViewModel, MainView>();
            Map<HomeViewModel, HomeView>();
            Map<BookingViewModel, BookingView>();
            Map<MyRoomViewModel, MyRoomView>();
            Map<SuggestionsViewModel, SuggestionsView>();
            Map<ConciergeViewModel, ConciergeView>();
        }

        private void Map<TViewModel, TView>() 
            where TViewModel : ViewModelBase
            where TView : Page        
        {
            _mappings.Add(typeof(TViewModel), typeof(TView));
        }
    }
}
