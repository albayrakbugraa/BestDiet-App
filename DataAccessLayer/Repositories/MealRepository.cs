using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MealRepository
    {
        public List<Meal> GetMealsByDate(DateTime dateTime)
        {
            return MainRepository.db.Meals.Where(m=> m.MealTime == dateTime).ToList();
        }

        public List<Meal> GetMealsBetweenDates(DateTime startDate, DateTime endDate)
        {
            return MainRepository.db.Meals.Where(m => m.MealTime >= startDate && m.MealTime <= endDate).ToList();
        }
        public Meal GetMealByUserIDandMealCategoryID(string userID, int mealCategoryID, DateTime dateTime)
        {
            return MainRepository.db.Meals.Where(a => a.UserID == userID && a.MealCategoryID == mealCategoryID && a.MealTime == dateTime).FirstOrDefault();
        }
        public Meal GetMealByUserIDandMealCategoryName(string userID, string mealCategoryName, DateTime dateTime)
        {
            return MainRepository.db.Meals.Where(a => a.UserID == userID && a.MealCategory.MealCategoryName == mealCategoryName && a.MealTime == dateTime).FirstOrDefault();
        }
        public bool Insert(Meal meal)
        {
            MainRepository.db.Meals.Add(meal);
            return MainRepository.db.SaveChanges() >0;
        }

    }
}
