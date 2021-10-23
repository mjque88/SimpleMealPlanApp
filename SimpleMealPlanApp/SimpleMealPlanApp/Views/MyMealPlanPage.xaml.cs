using SimpleMealPlanApp.Models;
using SimpleMealPlanApp.ViewModels;
using System;
using System.IO;
using Xamarin.Essentials;
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

            //Load XML file for User Defined Meal Font Size

            var xmlPath = Path.Combine(FileSystem.AppDataDirectory, "UserDefinedMealFontSize.xml");
            if (File.Exists(xmlPath))
            {
                double userSavedMealFontSize = MealFontSize.LoadFromFile(xmlPath).UserMealFontSize;
                MealFontSlider.Value = userSavedMealFontSize;
            }
            else
            {
                return;
            }

            MealFontSlider.ValueChanged += FontSlider_ValueChanged;
        }

        private void FontSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            FontSize.Text = MealFontSlider.Value.ToString();

            MonBrekky.FontSize = MealFontSlider.Value;
            MonLunch.FontSize = MealFontSlider.Value;
            MonDinner.FontSize = MealFontSlider.Value;
            TueBrekky.FontSize = MealFontSlider.Value;
            TueLunch.FontSize = MealFontSlider.Value;
            TueDinner.FontSize = MealFontSlider.Value;
            WedBrekky.FontSize = MealFontSlider.Value;
            WedLunch.FontSize = MealFontSlider.Value;
            WedDinner.FontSize = MealFontSlider.Value;
            ThuBrekky.FontSize = MealFontSlider.Value;
            ThuLunch.FontSize = MealFontSlider.Value;
            ThuDinner.FontSize = MealFontSlider.Value;
            FriBrekky.FontSize = MealFontSlider.Value;
            FriLunch.FontSize = MealFontSlider.Value;
            FriDinner.FontSize = MealFontSlider.Value;
            SatBrekky.FontSize = MealFontSlider.Value;
            SatLunch.FontSize = MealFontSlider.Value;
            SatDinner.FontSize = MealFontSlider.Value;
            SunBrekky.FontSize = MealFontSlider.Value;
            SunLunch.FontSize = MealFontSlider.Value;
            SunDinner.FontSize = MealFontSlider.Value;
        }

        private void SaveFontSize_Clicked(object sender, EventArgs e)
        {
            var xmlPath = Path.Combine(FileSystem.AppDataDirectory, "UserDefinedMealFontSize.xml");
            MealFontSize userSavedMealFontSize = new MealFontSize();
            userSavedMealFontSize.UserMealFontSize = MealFontSlider.Value;
            userSavedMealFontSize.Save(xmlPath);
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

        // Wednesday Meal Time TapGestureRecognizer
        private async void WedBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "WedBrekkyAddMeal", "WedBrekky");
        }

        private async void WedLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "WedLunchAddMeal", "WedLunch");
        }

        private async void WedDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "WedDinnerAddMeal", "WedDinner");
        }

        // Thusday Meal Time TapGestureRecognizer
        private async void ThuBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "ThuBrekkyAddMeal", "ThuBrekky");
        }

        private async void ThuLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "ThuLunchAddMeal", "ThuLunch");
        }

        private async void ThuDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "ThuDinnerAddMeal", "ThuDinner");
        }

        // Friday Meal Time TapGestureRecognizer
        private async void FriBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "FriBrekkyAddMeal", "FriBrekky");
        }

        private async void FriLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "FriLunchAddMeal", "FriLunch");
        }

        private async void FriDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "FriDinnerAddMeal", "FriDinner");
        }

        // Saturday Meal Time TapGestureRecognizer
        private async void SatBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "SatBrekkyAddMeal", "SatBrekky");
        }

        private async void SatLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "SatLunchAddMeal", "SatLunch");
        }

        private async void SatDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "SatDinnerAddMeal", "SatDinner");
        }

        // Sunday Meal Time TapGestureRecognizer
        private async void SunBrekkyTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "SunBrekkyAddMeal", "SunBrekky");
        }

        private async void SunLunchTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "SunLunchAddMeal", "SunLunch");
        }

        private async void SunDinnerTapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyMealsPage());

            MessagingCenter.Send(this, "SunDinnerAddMeal", "SunDinner");
        }
    }
}