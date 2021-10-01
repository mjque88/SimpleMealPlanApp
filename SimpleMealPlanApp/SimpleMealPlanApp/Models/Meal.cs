using SQLite;

namespace SimpleMealPlanApp.Models
{
    public class Meal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string MealName { get; set; }

        public Meal()
        {

        }

        public Meal(string mealName)
        {
            MealName = mealName.ToLower();
        }
    }
}