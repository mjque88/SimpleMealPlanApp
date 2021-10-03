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

        public Meal SelectedMeal { get;  set; }

        public string MealName { get; set; }

        public string SearchMealInputValue { get; set; }

        public string MealPlanMealDay { get; set; }

        private ObservableCollection<Meal> searchResults;
        public ObservableCollection<Meal> SearchResults
        {
            get
            {
                return searchResults;
            }
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
            {
                return meals;
            }
            set
            {
                meals = value;
                NotifyPropertyChanged();
            }
        }

        public AsyncCommand CreateMealCommand { get; }
        public AsyncCommand SearchMealCommand { get; }


        public MyMealsViewModel()
        {
            Task.Run(async () =>
            {
                Meals = await MealService.GetMeal();
            });

            CreateMealCommand = new AsyncCommand(CreateNewMeal);
            SearchMealCommand = new AsyncCommand(SearchMeal);

            SelectedMeal = new Meal();

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
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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

        async Task CreateNewMeal()
        {
            await MealService.AddMeal(MealName);
        }

        async Task SearchMeal()
        {
            SearchResults = await MealService.GetSearchResults(SearchMealInputValue.ToLower());
        }
    }
}
