using System;
using Testfirsttimerun.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Testfirsttimerun
{
    public partial class App : Application
    {
        public string IsFirstTime
        {
            get { return Settings.GeneralSettings; }
            set
            {
                if (Settings.GeneralSettings == value)
                    return;
                Settings.GeneralSettings = value;
            }
        }

        public App()
        {
            InitializeComponent();


            // Check is the app running for the first time
            if (IsFirstTime == "yes")
            {
                // if this is the first time, set it to "No" and load the
                // Main Page ,which will show at the first time use
                IsFirstTime = "no";
                MainPage = new MainPage();
            }
            else
            {
                // If this is not the first time,
                // Go to the login page
                MainPage = new NextPage();
            }   
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
