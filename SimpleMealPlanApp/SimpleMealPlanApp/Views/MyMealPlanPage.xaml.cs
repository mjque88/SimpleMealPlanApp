using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMealPlanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMealPlanPage : ContentPage
    {
        public MyMealPlanPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<MyMealPlanViewModel>(this, "ClearAllMeals", async (sender) =>
            {
               bool clearAllAnswer = await DisplayAlert("Confirm Action:", "Would you like to clear all meals?", "Yes", "No");

               MessagingCenter.Send(this, "ClearAllMealsAnswer", clearAllAnswer);
            });
        }

        // MyMeals Toolbar Navigation
        private async void MyMeals_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());
        }


        // Monday Meal Time TapGestureRecognizer
        private async void MonBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "MonBrekkyAddMeal", "MonBrekky");
        }

        private async void MonLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "MonLunchAddMeal", "MonLunch");
        }

        private async void MonDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "MonDinnerAddMeal", "MonDinner");
        }

        // Tuesday Meal Time TapGestureRecognizer
        private async void TueBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "TueBrekkyAddMeal", "TueBrekky");
        }

        private async void TueLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "TueLunchAddMeal", "TueLunch");
        }

        private async void TueDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "TueDinnerAddMeal", "TueDinner");
        }
    }
}