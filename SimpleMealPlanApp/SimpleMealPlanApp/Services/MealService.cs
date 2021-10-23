using SimpleMealPlanApp.Models;
using SQLite;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SimpleMealPlanApp.Services
{
    public class MealService
    {
        static SQLiteAsyncConnection db2;

        static MealService()
        {
            if (db2 != null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyMealData.db");
            db2 = new SQLiteAsyncConnection(databasePath);
            db2.CreateTableAsync<Meal>();
        }



        static async Task Init()
        {
            if (db2 != null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyMealData.db");
            db2 = new SQLiteAsyncConnection(databasePath);

            await db2.CreateTableAsync<Meal>();
        }

        public static async Task AddMeal(string mealname)
        {
            await Init();
            var meal = new Meal
            {
                MealName = mealname
            };

            var id = await db2.InsertAsync(meal);
        }

        public static async Task RemoveMeal(int id)
        {
            await Init();

            await db2.DeleteAsync<Meal>(id);
        }

        public static async Task<ObservableCollection<Meal>> GetMeal()
        {
            await Init();

            var meal = await db2.Table<Meal>().ToListAsync();
            var meals = new ObservableCollection<Meal>(meal.Distinct());
            return meals;
        }

        public static async Task<ObservableCollection<Meal>> GetSearchResults(string queryString)
        {
            await Init();

            var meal = await db2.Table<Meal>().ToListAsync();
            var searchMealResults = meal.Where(i => i.MealName.ToLower().Contains(queryString));
            var oCSearchMealResults = new ObservableCollection<Meal>(searchMealResults.Distinct());
            return oCSearchMealResults;
        }

        public static async Task<ObservableCollection<Meal>> DeleteAllMeals()
        {
            await Init();

            var meal = await db2.Table<Meal>().ToListAsync();
            var meals = new ObservableCollection<Meal>(meal);
            meals.Clear();
            return meals;
        }
    }
}