using SmartHotel.Views;
using System;
using SmartHotel.Services;
using Xamarin.Forms;
using SmartHotel.Services.Navigation;
using SmartHotel.ViewModels;

namespace SmartHotel
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
		    
            ServiceLocator.Instance.Build();

            //MainPage = new NavigationPage(new LoginView());

            //Thay thế hàm trên bằng hàm này để Resolve cái LoginViewModel

            ServiceLocator.Instance.Resolve<INavigationService>().
                NavigateToAsync<LoginViewModel>();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
