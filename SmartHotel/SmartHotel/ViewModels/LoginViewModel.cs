using System;
using System.ComponentModel;
using System.Threading.Tasks;
using SmartHotel.Mvvm.Commands;
using SmartHotel.Services;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }


        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        //với DelegateCommand là class được thêm bên ngoài vào trong MVVM
        public DelegateCommand LoginCommand { get; }
        //LoginCommand: tên sự kiện khi click vào nút Login, được gọi trong LoginView.xaml


        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login, CanLogin)
                .ObservesProperty(()=>Username)
                .ObservesProperty(()=>Password);
            //Với 2 cái .ObservesProperty(()=>Username) và ObservesProperty(() => Password) là
            //để cập nhật cái LoginCommand khi Username và Password thay đổi, vì mặc định LoginCommand chỉ
            //chạy lần đầu nên ta phải cập nhật khi các entry thay đổi
        }

        //Hàm này kiểm tra phải nhập Username và Password thì mới hiện nút Login
        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void Login()
        {
            //Check Login để chạy vào MainView: Với NavigationService 
            //được khởi tạo trong class ViewModelBase
            IsBusy = true;
            if (Username == "abc" && Password == "123")
            {
                NavigationService.NavigateToAsync<MainViewModel>();
            }
        }

        //Tất cả các ViewModel thì đều Overide hàm InitializeAsync lại vì tất cả các
        //class ViewModel đều thừa kế từ ViewModelBase.cs
        public override Task InitializeAsync(object navigationData)
        {
            return Task.CompletedTask;
        }
    }
}
