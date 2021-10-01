using SimpleMealPlanApp.Models;
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


        //Monday Meals
        public Meal MonBrekky { get; set; }

        private string monbrekky { get; set; } = "Add Meal";

        public string MonBrekkyMeal
        {
            get
            {
                return monbrekky;
            }
            set
            {
                monbrekky = value;
                NotifyPropertyChanged();
            }
        }

        public Meal MonLunch { get; set; }

        private string monLunch { get; set; } = "Add Meal";

        public string MonLunchMeal
        {
            get
            {
                return monLunch;
            }
            set
            {
                monLunch = value;
                NotifyPropertyChanged();
            }
        }

        public Meal MonDinner { get; set; }

        private string monDinner { get; set; } = "Add Meal";

        public string MonDinnerMeal
        {
            get
            {
                return monDinner;
            }
            set
            {
                monDinner = value;
                NotifyPropertyChanged();
            }
        }

        // Tuesday Meals
        public Meal TueBrekky { get; set; }

        private string tuebrekky { get; set; } = "Add Meal";

        public string TueBrekkyMeal
        {
            get
            {
                return tuebrekky;
            }
            set
            {
                tuebrekky = value;
                NotifyPropertyChanged();
            }
        }

        public Meal TueLunch { get; set; }

        private string tueLunch { get; set; } = "Add Meal";

        public string TueLunchMeal
        {
            get
            {
                return tueLunch;
            }
            set
            {
                tueLunch = value;
                NotifyPropertyChanged();
            }
        }

        public Meal TueDinner { get; set; }

        private string tueDinner { get; set; } = "Add Meal";

        public string TueDinnerMeal
        {
            get
            {
                return tueDinner;
            }
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

            //Monday meal time subsriptions
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanMonBrekky",
                (sender, monBrekkyMeal) =>
                {
                    MonBrekky = monBrekkyMeal;
                    MonBrekkyMeal = MonBrekky.MealName;
                });

            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanMonLunch",
                (sender, monLunchMeal) =>
                {
                    MonLunch = monLunchMeal;
                    MonLunchMeal = MonLunch.MealName;
                });

            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanMonDinner",
                (sender, monDinnerMeal) =>
                {
                    MonDinner = monDinnerMeal;
                    MonDinnerMeal = MonDinner.MealName;
                });

            //Monday meal time subsriptions
            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanTueBrekky",
                (sender, tueBrekkyMeal) =>
                {
                    TueBrekky = tueBrekkyMeal;
                    TueBrekkyMeal = TueBrekky.MealName;
                });

            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanTueLunch",
                (sender, tueLunchMeal) =>
                {
                    TueLunch = tueLunchMeal;
                    TueLunchMeal = TueLunch.MealName;
                });

            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlanTueDinner",
                (sender, tueDinnerMeal) =>
                {
                    TueDinner = tueDinnerMeal;
                    TueDinnerMeal = TueDinner.MealName;
                });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public ICommand OpenWebMealIdeasCommand => new Command(OpenWebMealIdeas);

        public async void OpenWebMealIdeas()
        {
            await Browser.OpenAsync("https://www.bestrecipes.com.au/budget/galleries/cheap-family-meals-under-5-serve/hek2k6x4", BrowserLaunchMode.SystemPreferred);
        }
    }
}
