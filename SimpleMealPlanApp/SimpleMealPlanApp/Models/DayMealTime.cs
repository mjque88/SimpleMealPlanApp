using SQLite;


namespace SimpleMealPlanApp.Models
{
    public class DayMealTime
    {
        [PrimaryKey]
        public string DayMealTimeMeal { get; set; }

        public string MealName { get; set; }

        public DayMealTime()
        {

        }

        public DayMealTime (string dayMealTimeMeal, string mealName)
        {
            DayMealTimeMeal = dayMealTimeMeal;
            MealName = mealName;
        }
    }
}