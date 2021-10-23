using SimpleMealPlanApp.Models;
using SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SimpleMealPlanApp.Services
{
    public class DayMealTimeService
    {
        private static SQLiteAsyncConnection db;

        public bool FirstTimeUse = false;

        static DayMealTimeService()
        {
            var dmtMonBrekky = new DayMealTime("MonBrekky", "Add Meal");
            var dmtMonLunch = new DayMealTime("MonLunch", "Add Meal");
            var dmtMonDinner = new DayMealTime("MonDinner", "Add Meal");
            var dmtTueBrekky = new DayMealTime("TueBrekky", "Add Meal");
            var dmtTueLunch = new DayMealTime("TueLunch", "Add Meal");
            var dmtTueDinner = new DayMealTime("TueDinner", "Add Meal");
            var dmtWedBrekky = new DayMealTime("WedBrekky", "Add Meal");
            var dmtWedLunch = new DayMealTime("WedLunch", "Add Meal");
            var dmtWedDinner = new DayMealTime("WedDinner", "Add Meal");
            var dmtThuBrekky = new DayMealTime("ThuBrekky", "Add Meal");
            var dmtThuLunchnew = new DayMealTime("ThuLunch", "Add Meal");
            var dmtThuDinner = new DayMealTime("ThuDinner", "Add Meal");
            var dmtFriBrekky = new DayMealTime("FriBrekky", "Add Meal");
            var dmtFriLunch = new DayMealTime("FriLunch", "Add Meal");
            var dmtFriDinner = new DayMealTime("FriDinner", "Add Meal");
            var dmtSatBrekky = new DayMealTime("SatBrekky", "Add Meal");
            var dmtSatLunch = new DayMealTime("SatLunch", "Add Meal");
            var dmtSatDinner = new DayMealTime("SatDinner", "Add Meal");
            var dmtSunBrekky = new DayMealTime("SunBrekky", "Add Meal");
            var dmtSunLunch = new DayMealTime("SunLunch", "Add Meal");
            var dmtSunDinner = new DayMealTime("SunDinner", "Add Meal");

            if (db != null)
            {
                return;
            }
            else
            {
                var databasePath = Path.Combine(FileSystem.AppDataDirectory, "DayMealTime.db");
                db = new SQLiteAsyncConnection(databasePath);

                db.CreateTableAsync<DayMealTime>();

                db.InsertAsync(dmtMonBrekky);
                db.InsertAsync(dmtMonLunch);
                db.InsertAsync(dmtMonDinner);
                db.InsertAsync(dmtTueBrekky);
                db.InsertAsync(dmtTueLunch);
                db.InsertAsync(dmtTueDinner);
                db.InsertAsync(dmtWedBrekky);
                db.InsertAsync(dmtWedLunch);
                db.InsertAsync(dmtWedDinner);
                db.InsertAsync(dmtThuBrekky);
                db.InsertAsync(dmtThuLunchnew);
                db.InsertAsync(dmtThuDinner);
                db.InsertAsync(dmtFriBrekky);
                db.InsertAsync(dmtFriLunch);
                db.InsertAsync(dmtFriDinner);
                db.InsertAsync(dmtSatBrekky);
                db.InsertAsync(dmtSatLunch);
                db.InsertAsync(dmtSatDinner);
                db.InsertAsync(dmtSunBrekky);
                db.InsertAsync(dmtSunLunch);
                db.InsertAsync(dmtSunDinner);
            }
        }
        
        static async Task Init()
        {
            if (db != null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "DayMealTime.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<DayMealTime>();
        }

        public async static Task<string> GetMealName(string dayMealTime)
        {
            await Init();

            await Task.Delay(2000);

            System.Collections.Generic.List<DayMealTime> dbDayMealTime = await db.Table<DayMealTime>().ToListAsync();
            while (dbDayMealTime.Count < 21)
            {
                await Task.Delay(1000);
            }
            System.Collections.Generic.IEnumerable<DayMealTime> listMealNameResults = dbDayMealTime.Where(i => i.DayMealTimeMeal.Contains(dayMealTime));
            DayMealTime dayMealTimeMealResults = listMealNameResults.FirstOrDefault();
            string mealName = dayMealTimeMealResults.MealName;
            if (mealName == null || mealName == "")
            {
                mealName = "Add Meal";
            }
             return mealName;
        }

        public static async Task AddMeal(string dayMealTime, string mealname)
        {
            await Init();

            var dayMealTimeMeal = new DayMealTime
            {
                DayMealTimeMeal = dayMealTime,
                MealName = mealname
            };

            await db.InsertOrReplaceAsync(dayMealTimeMeal);
        }

        public async static Task ClearAllMealNames()
        {
            await Init();

            var dmtMonBrekky = new DayMealTime("MonBrekky", "Add Meal");
            var dmtMonLunch = new DayMealTime("MonLunch", "Add Meal");
            var dmtMonDinner = new DayMealTime("MonDinner", "Add Meal");
            var dmtTueBrekky = new DayMealTime("TueBrekky", "Add Meal");
            var dmtTueLunch = new DayMealTime("TueLunch", "Add Meal");
            var dmtTueDinner = new DayMealTime("TueDinner", "Add Meal");
            var dmtWedBrekky = new DayMealTime("WedBrekky", "Add Meal");
            var dmtWedLunch = new DayMealTime("WedLunch", "Add Meal");
            var dmtWedDinner = new DayMealTime("WedDinner", "Add Meal");
            var dmtThuBrekky = new DayMealTime("ThuBrekky", "Add Meal");
            var dmtThuLunchnew = new DayMealTime("ThuLunch", "Add Meal");
            var dmtThuDinner = new DayMealTime("ThuDinner", "Add Meal");
            var dmtFriBrekky = new DayMealTime("FriBrekky", "Add Meal");
            var dmtFriLunch = new DayMealTime("FriLunch", "Add Meal");
            var dmtFriDinner = new DayMealTime("FriDinner", "Add Meal");
            var dmtSatBrekky = new DayMealTime("SatBrekky", "Add Meal");
            var dmtSatLunch = new DayMealTime("SatLunch", "Add Meal");
            var dmtSatDinner = new DayMealTime("SatDinner", "Add Meal");
            var dmtSunBrekky = new DayMealTime("SunBrekky", "Add Meal");
            var dmtSunLunch = new DayMealTime("SunLunch", "Add Meal");
            var dmtSunDinner = new DayMealTime("SunDinner", "Add Meal");

            await db.InsertOrReplaceAsync(dmtMonBrekky);
            await db.InsertOrReplaceAsync(dmtMonLunch);
            await db.InsertOrReplaceAsync(dmtMonDinner);
            await db.InsertOrReplaceAsync(dmtTueBrekky);
            await db.InsertOrReplaceAsync(dmtTueLunch);
            await db.InsertOrReplaceAsync(dmtTueDinner);
            await db.InsertOrReplaceAsync(dmtWedBrekky);
            await db.InsertOrReplaceAsync(dmtWedLunch);
            await db.InsertOrReplaceAsync(dmtWedDinner);
            await db.InsertOrReplaceAsync(dmtThuBrekky);
            await db.InsertOrReplaceAsync(dmtThuLunchnew);
            await db.InsertOrReplaceAsync(dmtThuDinner);
            await db.InsertOrReplaceAsync(dmtFriBrekky);
            await db.InsertOrReplaceAsync(dmtFriLunch);
            await db.InsertOrReplaceAsync(dmtFriDinner);
            await db.InsertOrReplaceAsync(dmtSatBrekky);
            await db.InsertOrReplaceAsync(dmtSatLunch);
            await db.InsertOrReplaceAsync(dmtSatDinner);
            await db.InsertOrReplaceAsync(dmtSunBrekky);
            await db.InsertOrReplaceAsync(dmtSunLunch);
            await db.InsertOrReplaceAsync(dmtSunDinner);
        }

        public async static Task InitialiseDatabaseWithMealNames()
        {
            await Init();

            if(db != null)
            {
                return;
            }
            else
            {
                var dmtMonBrekky = new DayMealTime("MonBrekky", "Add Meal");
                var dmtMonLunch = new DayMealTime("MonLunch", "Add Meal");
                var dmtMonDinner = new DayMealTime("MonDinner", "Add Meal");
                var dmtTueBrekky = new DayMealTime("TueBrekky", "Add Meal");
                var dmtTueLunch = new DayMealTime("TueLunch", "Add Meal");
                var dmtTueDinner = new DayMealTime("TueDinner", "Add Meal");
                var dmtWedBrekky = new DayMealTime("WedBrekky", "Add Meal");
                var dmtWedLunch = new DayMealTime("WedLunch", "Add Meal");
                var dmtWedDinner = new DayMealTime("WedDinner", "Add Meal");
                var dmtThuBrekky = new DayMealTime("ThuBrekky", "Add Meal");
                var dmtThuLunchnew = new DayMealTime("ThuLunch", "Add Meal");
                var dmtThuDinner = new DayMealTime("ThuDinner", "Add Meal");
                var dmtFriBrekky = new DayMealTime("FriBrekky", "Add Meal");
                var dmtFriLunch = new DayMealTime("FriLunch", "Add Meal");
                var dmtFriDinner = new DayMealTime("FriDinner", "Add Meal");
                var dmtSatBrekky = new DayMealTime("SatBrekky", "Add Meal");
                var dmtSatLunch = new DayMealTime("SatLunch", "Add Meal");
                var dmtSatDinner = new DayMealTime("SatDinner", "Add Meal");
                var dmtSunBrekky = new DayMealTime("SunBrekky", "Add Meal");
                var dmtSunLunch = new DayMealTime("SunLunch", "Add Meal");
                var dmtSunDinner = new DayMealTime("SunDinner", "Add Meal");

                await Task.Delay(2000);

                await db.InsertOrReplaceAsync(dmtMonBrekky);
                await db.InsertOrReplaceAsync(dmtMonLunch);
                await db.InsertOrReplaceAsync(dmtMonDinner);
                await db.InsertOrReplaceAsync(dmtTueBrekky);
                await db.InsertOrReplaceAsync(dmtTueLunch);
                await db.InsertOrReplaceAsync(dmtTueDinner);
                await db.InsertOrReplaceAsync(dmtWedBrekky);
                await db.InsertOrReplaceAsync(dmtWedLunch);
                await db.InsertOrReplaceAsync(dmtWedDinner);
                await db.InsertOrReplaceAsync(dmtThuBrekky);
                await db.InsertOrReplaceAsync(dmtThuLunchnew);
                await db.InsertOrReplaceAsync(dmtThuDinner);
                await db.InsertOrReplaceAsync(dmtFriBrekky);
                await db.InsertOrReplaceAsync(dmtFriLunch);
                await db.InsertOrReplaceAsync(dmtFriDinner);
                await db.InsertOrReplaceAsync(dmtSatBrekky);
                await db.InsertOrReplaceAsync(dmtSatLunch);
                await db.InsertOrReplaceAsync(dmtSatDinner);
                await db.InsertOrReplaceAsync(dmtSunBrekky);
                await db.InsertOrReplaceAsync(dmtSunLunch);
                await db.InsertOrReplaceAsync(dmtSunDinner);
            }
        }
    }
}
