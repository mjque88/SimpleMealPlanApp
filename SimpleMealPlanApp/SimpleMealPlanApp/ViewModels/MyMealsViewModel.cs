using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.Services;
using SimpleMealPlanApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace SimpleMealPlanApp.ViewModels
{
    public class MyMealsViewModel : INotifyPropertyChanged
    {
        public string Title { get; } = "My Meals";

        private Meal selectedMeal { get; set; }
        public Meal SelectedMeal
        {
            get => selectedMeal;
            set
            {
                selectedMeal = value;
                NotifyPropertyChanged();
            }
        }

        private Meal meal { get; set; }
        public Meal NewMeal
        {
            get => meal;
            set
            {
                meal = value;
                NotifyPropertyChanged();
            }
        }

        public string SearchMealInputValue { get; set; }

        public string MealPlanMealDay { get; set; }

        private ObservableCollection<Meal> searchResults;
        public ObservableCollection<Meal> SearchResults
        {
            get => searchResults;
            set
            {
                searchResults = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Meal> meals;
        public ObservableCollection<Meal> Meals
        {
            get
            => meals;
            set
            {
                meals = value;
                NotifyPropertyChanged();
            }
        }

        public MyMealsViewModel()
        {
            //Load Meals from Database
            Task.Run(async () =>
            {
                Meals = await MealService.GetMeal();
            });

            SearchMealCommand = new AsyncCommand<string>(SearchMeal);
            //AddMealCommand = new AsyncCommand<Meal>(AddMeal);

            //Initalise properties
            SelectedMeal = new Meal();
            NewMeal = new Meal();

            //Monday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "MonBrekkyAddMeal",
                (sender, monBrekky) =>
                {
                    MealPlanMealDay = monBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "MonLunchAddMeal",
                (sender, monLunch) =>
                {
                    MealPlanMealDay = monLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "MonDinnerAddMeal",
                (sender, monDinner) =>
                {
                    MealPlanMealDay = monDinner;
                });

            //Tuesday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "TueBrekkyAddMeal",
                (sender, tueBrekky) =>
                {
                    MealPlanMealDay = tueBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "TueLunchAddMeal",
                (sender, tueLunch) =>
                {
                    MealPlanMealDay = tueLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "TueDinnerAddMeal",
                (sender, tueDinner) =>
                {
                    MealPlanMealDay = tueDinner;
                });

            //Wednesday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "WedBrekkyAddMeal",
                (sender, wedBrekky) =>
                {
                    MealPlanMealDay = wedBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "WedLunchAddMeal",
                (sender, wedLunch) =>
                {
                    MealPlanMealDay = wedLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "WedDinnerAddMeal",
                (sender, wedDinner) =>
                {
                    MealPlanMealDay = wedDinner;
                });

            //Thursday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "ThuBrekkyAddMeal",
                (sender, thuBrekky) =>
                {
                    MealPlanMealDay = thuBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "ThuLunchAddMeal",
                (sender, thuLunch) =>
                {
                    MealPlanMealDay = thuLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "ThuDinnerAddMeal",
                (sender, thuDinner) =>
                {
                    MealPlanMealDay = thuDinner;
                });

            //Friday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "FriBrekkyAddMeal",
                (sender, friBrekky) =>
                {
                    MealPlanMealDay = friBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "FriLunchAddMeal",
                (sender, friLunch) =>
                {
                    MealPlanMealDay = friLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "FriDinnerAddMeal",
                (sender, friDinner) =>
                {
                    MealPlanMealDay = friDinner;
                });

            //Saturday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "SatBrekkyAddMeal",
                (sender, satBrekky) =>
                {
                    MealPlanMealDay = satBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "SatLunchAddMeal",
                (sender, satLunch) =>
                {
                    MealPlanMealDay = satLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "SatDinnerAddMeal",
                (sender, satDinner) =>
                {
                    MealPlanMealDay = satDinner;
                });

            //Sunday Meal Plan Subscriptions
            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "SunBrekkyAddMeal",
                (sender, sunBrekky) =>
                {
                    MealPlanMealDay = sunBrekky;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "SunLunchAddMeal",
                (sender, sunLunch) =>
                {
                    MealPlanMealDay = sunLunch;
                });

            MessagingCenter.Subscribe<MyMealPlanPage, string>(this, "SunDinnerAddMeal",
                (sender, sunDinner) =>
                {
                    MealPlanMealDay = sunDinner;
                });

            //Receive Created Meal

            MessagingCenter.Subscribe<CreateOrEditMeal, Meal>(this, "CreateMeal",
                async(sender, meal) =>
                {
                    NewMeal = meal;
                    await MealService.AddMeal(meal.MealName);
                });
        }

        //Property Changed Event Handler
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        //Add to Meal Plan
        public ICommand AddToMealPlanCommand => new Command(AddToMealPlan);

        public void AddToMealPlan()
        {
            if (SelectedMeal == null)
            {
                MessagingCenter.Send(this, "DisplayAlertAddToMealPlan");
            }
            else
            {
                string addToMealPlan = $"AddToMealPlan{MealPlanMealDay}";
                MessagingCenter.Send(this, addToMealPlan, SelectedMeal);

                MessagingCenter.Send(this, "NavigateToMyMealPlanPage");

                MealPlanMealDay = string.Empty;
            }
        }

        //Delete New Meal
        public ICommand DeleteMealCommand => new Command<Meal>(RemoveMeal);

        public async void RemoveMeal(Meal meal)
        {
            await MealService.RemoveMeal(meal.Id);

            //Refresh after each delete
            SearchResults.Clear();
            Meals.Clear();

            SearchResults = await MealService.GetSearchResults(SearchMealInputValue.ToLower());
            Meals = await MealService.GetMeal();
        }

        //Search Meal
        public AsyncCommand<string> SearchMealCommand { get; }

        public async Task SearchMeal(string searchMealInputValue)
        {
            SearchMealInputValue = searchMealInputValue;
            SearchResults = await MealService.GetSearchResults(SearchMealInputValue.ToLower());
        }
    }
}
