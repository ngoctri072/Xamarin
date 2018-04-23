using System;
using System.Threading.Tasks;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.Services.Navigation
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;    
        Task NavigateToAsync(Type viewModelType);    
        Task NavigateToAsync(Type viewModelType, object parameter);
        Task NavigateBackAsync();
    }
}