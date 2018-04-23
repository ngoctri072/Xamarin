using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using SmartHotel.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();

            //var service = DependencyService.Get<IEmailService>();
            //service.Send("ac", "c", "aa");            
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (Navigation.NavigationStack[0] is LoginView)
        //        Navigation.RemovePage(Navigation.NavigationStack[0]);
        //}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}