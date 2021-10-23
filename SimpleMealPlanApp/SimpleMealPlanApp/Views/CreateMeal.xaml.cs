using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMealPlanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateOrEditMeal : ContentPage
    {
        public CreateOrEditMeal()
        {
            InitializeComponent();
        }

        private async void MyMeals_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());
        }

        private async void CreateMealButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            Meal meal = ((CreateMealViewModel)BindingContext).Meal;

            MessagingCenter.Send(this, "CreateMeal", meal);
        }
    }
}