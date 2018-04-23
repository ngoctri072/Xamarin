using SmartHotel.Mvvm;
using SmartHotel.Services.Navigation;
using System.Threading.Tasks;

namespace SmartHotel.ViewModels.Base
{
    public class ViewModelBase : BindableBase
    {
        private bool _isBusy;
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        protected INavigationService NavigationService { get; }

        //khởi tạo NavigationService để gọi kiểm tra Login bên LoginViewModel.cs
        public ViewModelBase()
        {
            NavigationService = ServiceLocator.Instance.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.CompletedTask;
        }
    }
}