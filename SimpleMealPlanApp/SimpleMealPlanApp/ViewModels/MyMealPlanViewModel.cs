using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.Services;
using SimpleMealPlanApp.Views;
using System.ComponentModel;
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

            //Update database functions for meal plans

            GetMonBrekkyMealName();

            UpdateMealPlanMonBrekky();

            GetMonLunchMealName();

            UpdateMealPlanMonLunch();

            GetMonDinnerMealName();

            UpdateMealPlanMonDinner();

            GetTueBrekkyMealName();

            UpdateMealPlanTueBrekky();

            GetTueLunchMealName();

            UpdateMealPlanTueLunch();

            GetTueDinnerMealName();

            UpdateMealPlanTueDinner();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Update meals by day and meal time to database from My Meals page.
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

        // Get meal names from database by day and meal time.

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

        // Button for opening link to more meal ideas website.

        public ICommand OpenWebMealIdeasCommand => new Xamarin.Forms.Command(OpenWebMealIdeas);

        public async void OpenWebMealIdeas()
        {
            await Browser.OpenAsync("https://www.bestrecipes.com.au/budget/galleries/cheap-family-meals-under-5-serve/hek2k6x4", BrowserLaunchMode.SystemPreferred);
        }

        // Button to clear all meal plans.

        public ICommand ClearAllMealsCommand => new Xamarin.Forms.Command(ClearAllMeals);

        public async void ClearAllMeals()
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
                    GetMonBrekkyMealName();
                    GetMonLunchMealName();
                    GetMonDinnerMealName();
                    GetTueBrekkyMealName();
                    GetTueLunchMealName();
                    GetTueDinnerMealName();
                }
            });
        }
    }
}
