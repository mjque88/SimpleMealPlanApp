using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMealPlanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMealsPage : ContentPage
    {
        public MyMealsPage()
        {
            InitializeComponent();
            BindingContext = new MyMealsViewModel();

            MessagingCenter.Subscribe<MyMealsViewModel>(this, "DisplayAlertAddToMealPlan", (sender) =>
            {
                _ = DisplayAlert("Select Meal:", "Tap on the meal you wish to add to Meal Plan.", "OK");
                NoMealSelected = true;
            });

            MessagingCenter.Subscribe<MyMealsViewModel, Meal>(this, "AddToMealPlan",
               (sender, Meal) =>
               {
                   _ = DisplayAlert("Select Day:", "Tap on day and meal time on My Meal Plan to add a meal.", "OK");
                   NoMealSelected = true;

                   _ = Navigation.PopAsync();
               });


            MessagingCenter.Subscribe<MyMealsViewModel>(this, "NavigateToMyMealPlanPage", (sender) =>
            {
                NoMealSelected = false;
            });
        }

        public bool NoMealSelected = false;

        private void AddToMealPlanButton_Clicked(object sender, EventArgs e)
        {
            if(NoMealSelected)
            {
                return;
            }
            else
            {
                _ = Navigation.PopAsync();
            }
        }

        private async void CreateMeal_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditMeal());
        }

        private void ReturnToMealPlanButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyMealPlanPage());
        }

    }
}