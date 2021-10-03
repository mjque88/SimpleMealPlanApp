using SimpleMealPlanApp.Models;
using SQLite;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SimpleMealPlanApp.Services
{
    public static class MealService
    {
        static SQLiteAsyncConnection db;

        static async Task Init()
        {
            if (db != null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyMealData.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Meal>();
        }

        public static async Task AddMeal(string mealname)
        {
            await Init();
            var meal = new Meal
            {
                MealName = mealname
            };

            var id = await db.InsertAsync(meal);
        }

        public static async Task RemoveMeal(int id)
        {
            await Init();

            await db.DeleteAsync<Meal>(id);
        }

        public static async Task<ObservableCollection<Meal>> GetMeal()
        {
            await Init();

            var meal = await db.Table<Meal>().ToListAsync();
            var meals = new ObservableCollection<Meal>(meal);
            return meals;
        }

        public static async Task<ObservableCollection<Meal>> GetSearchResults(string queryString)
        {
            await Init();

            var meal = await db.Table<Meal>().ToListAsync();
            var searchMealResults = meal.Where(i => i.MealName.ToLower().Contains(queryString));
            var oCSearchMealResults = new ObservableCollection<Meal>(searchMealResults);
            return oCSearchMealResults;
        }

        public static async Task<ObservableCollection<Meal>> DeleteAllMeals()
        {
            await Init();

            var meal = await db.Table<Meal>().ToListAsync();
            var meals = new ObservableCollection<Meal>(meal);
            meals.Clear();
            return meals;
        }
    }
}