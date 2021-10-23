using SimpleMealPlanApp.Services;
using SimpleMealPlanApp.Views;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMealPlanApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                await DayMealTimeService.InitialiseDatabaseWithMealNames();
            });

            try
            {
                MainPage = new NavigationPage(new MyMealPlanPage());
            }
            catch (Exception ex)
            {
                if (ex is SQLite.SQLiteException || ex is NullReferenceException)
                {
                    MainPage.DisplayAlert("Application Restart Required:", "Please re-open Simple Meal Plan to begin adding meals", "CLOSE");
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                else
                {
                    AppDomain currentDomain = AppDomain.CurrentDomain;
                    currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
                }
            }
        }

        private void MyHandler(object sender, UnhandledExceptionEventArgs e)
        {
            MainPage.DisplayAlert("Application Restart Required:", "Please re-open Simple Meal Plan to begin adding meals", "CLOSE");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
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
