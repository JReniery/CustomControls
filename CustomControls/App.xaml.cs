using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SurveyPage();
            MainPage.BindingContext = new ViewModels.SurveyViewModel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
