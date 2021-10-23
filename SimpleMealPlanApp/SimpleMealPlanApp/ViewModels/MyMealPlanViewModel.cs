using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.Services;
using SimpleMealPlanApp.Views;
using SQLite;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SimpleMealPlanApp.ViewModels
{
    public class MyMealPlanViewModel : INotifyPropertyChanged
    {
        public string Day { get; }
        public string Brekky { get; }
        public string Lunch { get; }
        public string Dinner { get; }
        public string Title { get; }
        public string AddMealString { get; }
        public string MonBrekkyString { get; }
        public string MonLunchString { get; }
        public string MonDinnerString { get; }
        public string TueBrekkyString { get; }
        public string TueLunchString { get; }
        public string TueDinnerString { get; }
        public string WedBrekkyString { get; }
        public string WedLunchString { get; }
        public string WedDinnerString { get; }
        public string ThuBrekkyString { get; }
        public string ThuLunchString { get; }
        public string ThuDinnerString { get; }
        public string FriBrekkyString { get; }
        public string FriLunchString { get; }
        public string FriDinnerString { get; }
        public string SatBrekkyString { get; }
        public string SatLunchString { get; }
        public string SatDinnerString { get; }
        public string SunBrekkyString { get; }
        public string SunLunchString { get; }
        public string SunDinnerString { get; }


        //Monday Meals
        public string monBrekky { get; set; }

        public string MonBrekky
        {
            get => monBrekky;
            set
            {
                monBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string monLunch { get; set; }

        public string MonLunch
        {
            get => monLunch;
            set
            {
                monLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string monDinner { get; set; }

        public string MonDinner
        {
            get => monDinner;
            set
            {
                monDinner = value;
                NotifyPropertyChanged();
            }
        }

        //Tuesday Meals
        public string tueBrekky { get; set; }

        public string TueBrekky
        {
            get => tueBrekky;
            set
            {
                tueBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string tueLunch { get; set; }

        public string TueLunch
        {
            get => tueLunch;
            set
            {
                tueLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string tueDinner { get; set; }

        public string TueDinner
        {
            get => tueDinner;
            set
            {
                tueDinner = value;
                NotifyPropertyChanged();
            }
        }

        //Wednesday Meals
        public string wedBrekky { get; set; }

        public string WedBrekky
        {
            get => wedBrekky;
            set
            {
                wedBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string wedLunch { get; set; }

        public string WedLunch
        {
            get => wedLunch;
            set
            {
                wedLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string wedDinner { get; set; }

        public string WedDinner
        {
            get => wedDinner;
            set
            {
                wedDinner = value;
                NotifyPropertyChanged();
            }
        }

        //Thusday Meals
        public string thuBrekky { get; set; }

        public string ThuBrekky
        {
            get => thuBrekky;
            set
            {
                thuBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string thuLunch { get; set; }

        public string ThuLunch
        {
            get => thuLunch;
            set
            {
                thuLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string thuDinner { get; set; }

        public string ThuDinner
        {
            get => thuDinner;
            set
            {
                thuDinner = value;
                NotifyPropertyChanged();
            }
        }

        //Friday Meals
        public string friBrekky { get; set; }

        public string FriBrekky
        {
            get => friBrekky;
            set
            {
                friBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string friLunch { get; set; }

        public string FriLunch
        {
            get => friLunch;
            set
            {
                friLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string friDinner { get; set; }

        public string FriDinner
        {
            get => friDinner;
            set
            {
                friDinner = value;
                NotifyPropertyChanged();
            }
        }

        //Saturday Meals
        public string satBrekky { get; set; }

        public string SatBrekky
        {
            get => satBrekky;
            set
            {
                satBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string satLunch { get; set; }

        public string SatLunch
        {
            get => satLunch;
            set
            {
                satLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string satDinner { get; set; }

        public string SatDinner
        {
            get => satDinner;
            set
            {
                satDinner = value;
                NotifyPropertyChanged();
            }
        }

        //Sunday Meals
        public string sunBrekky { get; set; }

        public string SunBrekky
        {
            get => sunBrekky;
            set
            {
                sunBrekky = value;
                NotifyPropertyChanged();
            }
        }

        private string sunLunch { get; set; }

        public string SunLunch
        {
            get => sunLunch;
            set
            {
                sunLunch = value;
                NotifyPropertyChanged();
            }
        }

        private string sunDinner { get; set; }

        public string SunDinner
        {
            get => sunDinner;
            set
            {
                sunDinner = value;
                NotifyPropertyChanged();
            }
        }

        public MyMealPlanViewModel()
        {
            Title = "My Meal Plan";
            Day = "Day";
            Brekky = "Brekky";
            Lunch = "Lunch";
            Dinner = "Dinner";
            AddMealString = "Add Meal";
            MonBrekkyString = "MonBrekky";
            MonLunchString = "MonLunch";
            MonDinnerString = "MonDinner";
            TueBrekkyString = "TueBrekky";
            TueLunchString = "TueLunch";
            TueDinnerString = "TueDinner";
            WedBrekkyString = "WedBrekky";
            WedLunchString = "WedLunch";
            WedDinnerString = "WedDinner";
            ThuBrekkyString = "ThuBrekky";
            ThuLunchString = "ThuLunch";
            ThuDinnerString = "ThuDinner";
            FriBrekkyString = "FriBrekky";
            FriLunchString = "FriLunch";
            FriDinnerString = "FriDinner";
            SatBrekkyString = "SatBrekky";
            SatLunchString = "SatLunch";
            SatDinnerString = "SatDinner";
            SunBrekkyString = "SunBrekky";
            SunLunchString = "SunLunch";
            SunDinnerString = "SunDinner";

            //Update database functions for meal plans

            //Monday meal plans
            GetMonBrekkyMealName();

            UpdateMealPlanMonBrekky();

            GetMonLunchMealName();

            UpdateMealPlanMonLunch();

            GetMonDinnerMealName();

            UpdateMealPlanMonDinner();

            //Tuesday meal plans
            GetTueBrekkyMealName();

            UpdateMealPlanTueBrekky();

            GetTueLunchMealName();

            UpdateMealPlanTueLunch();

            GetTueDinnerMealName();

            UpdateMealPlanTueDinner();

            //Wednesday meal plans
            GetWedBrekkyMealName();

            UpdateMealPlanWedBrekky();

            GetWedLunchMealName();

            UpdateMealPlanWedLunch();

            GetWedDinnerMealName();

            UpdateMealPlanWedDinner();

            //Thursday meal plans
            GetThuBrekkyMealName();

            UpdateMealPlanThuBrekky();

            GetThuLunchMealName();

            UpdateMealPlanThuLunch();

            GetThuDinnerMealName();

            UpdateMealPlanThuDinner();

            //Friday meal plans
            GetFriBrekkyMealName();

            UpdateMealPlanFriBrekky();

            GetFriLunchMealName();

            UpdateMealPlanFriLunch();

            GetFriDinnerMealName();

            UpdateMealPlanFriDinner();

            //Saturday meal plans
            GetSatBrekkyMealName();

            UpdateMealPlanSatBrekky();

            GetSatLunchMealName();

            UpdateMealPlanSatLunch();

            GetSatDinnerMealName();

            UpdateMealPlanSatDinner();

            //Sunday meal plans
            GetSunBrekkyMealName();

            UpdateMealPlanSunBrekky();

            GetSunLunchMealName();

            UpdateMealPlanSunLunch();

            GetSunDinnerMealName();

            UpdateMealPlanSunDinner();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Update meals by day and meal time to database from My Meals page.

        // Monday meals
        void UpdateMealPlanMonBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanMonBrekky",
            async (sender, monBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(MonBrekkyString, monBrekkyMeal.MealName);
                GetMonBrekkyMealName();
            });
        }

        void UpdateMealPlanMonLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanMonLunch",
            async (sender, monLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(MonLunchString, monLunchMeal.MealName);
                GetMonLunchMealName();
            });
        }

        void UpdateMealPlanMonDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanMonDinner",
            async (sender, monDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(MonDinnerString, monDinnerMeal.MealName);
                GetMonDinnerMealName();
            });
        }

        // Tuesday meals
        void UpdateMealPlanTueBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanTueBrekky",
            async (sender, tueBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(TueBrekkyString, tueBrekkyMeal.MealName);
                GetTueBrekkyMealName();
            });
        }

        void UpdateMealPlanTueLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanTueLunch",
            async (sender, tueLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(TueLunchString, tueLunchMeal.MealName);
                GetTueLunchMealName();
            });
        }

        void UpdateMealPlanTueDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanTueDinner",
            async (sender, tueDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(TueDinnerString, tueDinnerMeal.MealName);
                GetTueDinnerMealName();
            });
        }

        // Wednesday meals
        void UpdateMealPlanWedBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanWedBrekky",
            async (sender, wedBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(WedBrekkyString, wedBrekkyMeal.MealName);
                GetWedBrekkyMealName();
            });
        }

        void UpdateMealPlanWedLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanWedLunch",
            async (sender, wedLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(WedLunchString, wedLunchMeal.MealName);
                GetWedLunchMealName();
            });
        }

        void UpdateMealPlanWedDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanWedDinner",
            async (sender, wedDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(WedDinnerString, wedDinnerMeal.MealName);
                GetWedDinnerMealName();
            });
        }

        // Thursday meals
        void UpdateMealPlanThuBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanThuBrekky",
            async (sender, thuBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(ThuBrekkyString, thuBrekkyMeal.MealName);
                GetThuBrekkyMealName();
            });
        }

        void UpdateMealPlanThuLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanThuLunch",
            async (sender, thuLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(ThuLunchString, thuLunchMeal.MealName);
                GetThuLunchMealName();
            });
        }

        void UpdateMealPlanThuDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanThuDinner",
            async (sender, thuDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(ThuDinnerString, thuDinnerMeal.MealName);
                GetThuDinnerMealName();
            });
        }

        // Friday meals
        void UpdateMealPlanFriBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanFriBrekky",
            async (sender, friBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(FriBrekkyString, friBrekkyMeal.MealName);
                GetFriBrekkyMealName();
            });
        }

        void UpdateMealPlanFriLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanFriLunch",
            async (sender, friLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(FriLunchString, friLunchMeal.MealName);
                GetFriLunchMealName();
            });
        }

        void UpdateMealPlanFriDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanFriDinner",
            async (sender, friDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(FriDinnerString, friDinnerMeal.MealName);
                GetFriDinnerMealName();
            });
        }

        // Saturday meals
        void UpdateMealPlanSatBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanSatBrekky",
            async (sender, satBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(SatBrekkyString, satBrekkyMeal.MealName);
                GetSatBrekkyMealName();
            });
        }

        void UpdateMealPlanSatLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanSatLunch",
            async (sender, satLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(SatLunchString, satLunchMeal.MealName);
                GetSatLunchMealName();
            });
        }

        void UpdateMealPlanSatDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanSatDinner",
            async (sender, satDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(SatDinnerString, satDinnerMeal.MealName);
                GetSatDinnerMealName();
            });
        }

        // Sunday meals
        void UpdateMealPlanSunBrekky()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanSunBrekky",
            async (sender, sunBrekkyMeal) =>
            {
                await DayMealTimeService.AddMeal(SunBrekkyString, sunBrekkyMeal.MealName);
                GetSunBrekkyMealName();
            });
        }

        void UpdateMealPlanSunLunch()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanSunLunch",
            async (sender, sunLunchMeal) =>
            {
                await DayMealTimeService.AddMeal(SunLunchString, sunLunchMeal.MealName);
                GetSunLunchMealName();
            });
        }

        void UpdateMealPlanSunDinner()
        {
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanSunDinner",
            async (sender, sunDinnerMeal) =>
            {
                await DayMealTimeService.AddMeal(SunDinnerString, sunDinnerMeal.MealName);
                GetSunDinnerMealName();
            });
        }

        // Get meal names from database by day and meal time.

        // Monday meal names
        async void GetMonBrekkyMealName()
        {
            MonBrekky = await DayMealTimeService.GetMealName(MonBrekkyString);

            if (MonBrekky == null)
            {
                await DayMealTimeService.AddMeal(MonBrekkyString, AddMealString);
            }
        }

        async void GetMonLunchMealName()
        {
            MonLunch = await DayMealTimeService.GetMealName(MonLunchString);

            if (MonLunch == null)
            {
                await DayMealTimeService.AddMeal(MonLunchString, AddMealString);
            }
        }

        async void GetMonDinnerMealName()
        {
            MonDinner = await DayMealTimeService.GetMealName(MonDinnerString);

            if (MonDinner == null)
            {
                await DayMealTimeService.AddMeal(MonDinnerString, AddMealString);
            }
        }

        // Tuesday meal names
        async void GetTueBrekkyMealName()
        {
            TueBrekky = await DayMealTimeService.GetMealName(TueBrekkyString);

            if (TueBrekky == null)
            {
                await DayMealTimeService.AddMeal(TueBrekkyString, AddMealString);
            }
        }

        async void GetTueLunchMealName()
        {
            TueLunch = await DayMealTimeService.GetMealName(TueLunchString);

            if (TueLunch == null)
            {
                await DayMealTimeService.AddMeal(TueLunchString, AddMealString);
            }
        }

        async void GetTueDinnerMealName()
        {
            TueDinner = await DayMealTimeService.GetMealName(TueDinnerString);

            if (TueDinner == null)
            {
                await DayMealTimeService.AddMeal(TueDinnerString, AddMealString);
            }
        }

        // Wednesday meal names
        async void GetWedBrekkyMealName()
        {
            WedBrekky = await DayMealTimeService.GetMealName(WedBrekkyString);

            if (WedBrekky == null)
            {
                await DayMealTimeService.AddMeal(WedBrekkyString, AddMealString);
            }
        }

        async void GetWedLunchMealName()
        {
            WedLunch = await DayMealTimeService.GetMealName(WedLunchString);

            if (WedLunch == null)
            {
                await DayMealTimeService.AddMeal(WedLunchString, AddMealString);
            }
        }

        async void GetWedDinnerMealName()
        {
            WedDinner = await DayMealTimeService.GetMealName(WedDinnerString);

            if (WedDinner == null)
            {
                await DayMealTimeService.AddMeal(WedDinnerString, AddMealString);
            }
        }

        // Thursday meal names
        async void GetThuBrekkyMealName()
        {
            ThuBrekky = await DayMealTimeService.GetMealName(ThuBrekkyString);

            if (ThuBrekky == null)
            {
                await DayMealTimeService.AddMeal(ThuBrekkyString, AddMealString);
            }
        }

        async void GetThuLunchMealName()
        {
            ThuLunch = await DayMealTimeService.GetMealName(ThuLunchString);

            if (ThuLunch == null)
            {
                await DayMealTimeService.AddMeal(ThuLunchString, AddMealString);
            }
        }

        async void GetThuDinnerMealName()
        {
            ThuDinner = await DayMealTimeService.GetMealName(ThuDinnerString);

            if (ThuDinner == null)
            {
                await DayMealTimeService.AddMeal(ThuDinnerString, AddMealString);
            }
        }

        // Friday meal names
        async void GetFriBrekkyMealName()
        {
            FriBrekky = await DayMealTimeService.GetMealName(FriBrekkyString);

            if (FriBrekky == null)
            {
                await DayMealTimeService.AddMeal(FriBrekkyString, AddMealString);
            }
        }

        async void GetFriLunchMealName()
        {
            FriLunch = await DayMealTimeService.GetMealName(FriLunchString);

            if (FriLunch == null)
            {
                await DayMealTimeService.AddMeal(FriLunchString, AddMealString);
            }
        }

        async void GetFriDinnerMealName()
        {
            FriDinner = await DayMealTimeService.GetMealName(FriDinnerString);

            if (FriDinner == null)
            {
                await DayMealTimeService.AddMeal(FriDinnerString, AddMealString);
            }
        }

        // Saturday meal names
        async void GetSatBrekkyMealName()
        {
            SatBrekky = await DayMealTimeService.GetMealName(SatBrekkyString);

            if (SatBrekky == null)
            {
                await DayMealTimeService.AddMeal(SatBrekkyString, AddMealString);
            }
        }

        async void GetSatLunchMealName()
        {
            SatLunch = await DayMealTimeService.GetMealName(SatLunchString);

            if (SatLunch == null)
            {
                await DayMealTimeService.AddMeal(SatLunchString, AddMealString);
            }
        }

        async void GetSatDinnerMealName()
        {
            SatDinner = await DayMealTimeService.GetMealName(SatDinnerString);

            if (SatDinner == null)
            {
                await DayMealTimeService.AddMeal(SatDinnerString, AddMealString);
            }
        }

        // Sunday meal names
        async void GetSunBrekkyMealName()
        {
            SunBrekky = await DayMealTimeService.GetMealName(SunBrekkyString);

            if (SunBrekky == null)
            {
                await DayMealTimeService.AddMeal(SunBrekkyString, AddMealString);
            }
        }

        async void GetSunLunchMealName()
        {
            SunLunch = await DayMealTimeService.GetMealName(SunLunchString);

            if (SunLunch == null)
            {
                await DayMealTimeService.AddMeal(SunLunchString, AddMealString);
            }
        }

        async void GetSunDinnerMealName()
        {
            SunDinner = await DayMealTimeService.GetMealName(SunDinnerString);

            if (SunDinner == null)
            {
                await DayMealTimeService.AddMeal(SunDinnerString, AddMealString);
            }
        }

        // Button for opening link to more meal ideas website.

        public ICommand OpenWebMealIdeasCommand => new Xamarin.Forms.Command(OpenWebMealIdeas);

        public async void OpenWebMealIdeas()
        {
            await Browser.OpenAsync("https://www.bestrecipes.com.au/budget/galleries/cheap-family-meals-under-5-serve/hek2k6x4", BrowserLaunchMode.SystemPreferred);
        }

        // Button to clear all meal plans.

        public ICommand ClearAllMealsCommand => new Command(ClearAllMeals);

        public void ClearAllMeals()
        {
            MessagingCenter.Send(this, "ClearAllMeals");

            MessagingCenter.Subscribe<MyMealPlanPage, bool>(this, "ClearAllMealsAnswer",
            async (sender, clearAllMealsAnswer) =>
            {
                if(clearAllMealsAnswer == false)
                {
                    return;
                }
                else
                {
                    await DayMealTimeService.ClearAllMealNames();
                    //Clear Monday Meal Names
                    GetMonBrekkyMealName();
                    GetMonLunchMealName();
                    GetMonDinnerMealName();
                    //Clear Tuesday Meal Names
                    GetTueBrekkyMealName();
                    GetTueLunchMealName();
                    GetTueDinnerMealName();
                    //Clear Wednesday Meal Names
                    GetWedBrekkyMealName();
                    GetWedLunchMealName();
                    GetWedDinnerMealName();
                    //Clear Thursday Meal Names
                    GetThuBrekkyMealName();
                    GetThuLunchMealName();
                    GetThuDinnerMealName();
                    //Clear Friday Meal Names
                    GetFriBrekkyMealName();
                    GetFriLunchMealName();
                    GetFriDinnerMealName();
                    //Clear Saturday Meal Names
                    GetSatBrekkyMealName();
                    GetSatLunchMealName();
                    GetSatDinnerMealName();
                    //Clear Sunday Meal Names
                    GetSunBrekkyMealName();
                    GetSunLunchMealName();
                    GetSunDinnerMealName();
                }
            });
        }
    }
}
