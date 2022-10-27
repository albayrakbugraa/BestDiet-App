using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MealDetailRepository
    {
        
        public List<MealDetail> GetMealDeteailsByMealId(int mealID)
        {
            return MainRepository.db.MealDetails.Where(a => a.MealID == mealID).ToList();
        }
        public List<MealDetail> GetMealDetailsByUserId(string userID,DateTime dateTime)
        {
            return MainRepository.db.MealDetails.Where(a => a.Meal.UserID == userID && a.Meal.MealTime==dateTime).ToList();
        }
        public List<MealDetail> GetMealDetailsBetweenDate(string userID, DateTime dateTime,DateTime dateTime2)
        {
            return MainRepository.db.MealDetails.Where(a => a.Meal.UserID == userID && a.Meal.MealTime >=dateTime && a.Meal.MealTime<=dateTime2).ToList();
        }
        public bool Delete(int mealDetailId)
        {
            MealDetail mealDetail= MainRepository.db.MealDetails.Where(a => a.MealDetailID == mealDetailId).FirstOrDefault();
            MainRepository.db.MealDetails.Remove(mealDetail);
            return MainRepository.db.SaveChanges() > 0;
        }   
        public bool Insert(MealDetail mealDetail)
        {
            MainRepository.db.MealDetails.Add(mealDetail);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool Update(MealDetail mealDetail)
        {
            MealDetail updatedMealDetail = MainRepository.db.MealDetails.Find(mealDetail.MealDetailID);
            updatedMealDetail.Quantity = mealDetail.Quantity;
            updatedMealDetail.Meal.MealTime = mealDetail.Meal.MealTime;
            updatedMealDetail.Portion = mealDetail.Portion;
            return MainRepository.db.SaveChanges() > 0;
        }
        public MealDetail GetMealDetailById(int mealDetailID)
        {
            MealDetail mealDetail = MainRepository.db.MealDetails.Find(mealDetailID);
            return mealDetail;
        }
        public int GetFavoriteFoodID(string userID)
        {
            var mealDetail = MainRepository.db.MealDetails.Where(md=> md.Meal.UserID == userID).GroupBy(md=> md.FoodID).Select(md => new {FoodID = md.Key,AmountOfFodd = md.Count()}).OrderByDescending(x=> x.AmountOfFodd).Take(1).FirstOrDefault();
            if (mealDetail == null)
                return 0;
            return mealDetail.FoodID;
        }
    }
}
