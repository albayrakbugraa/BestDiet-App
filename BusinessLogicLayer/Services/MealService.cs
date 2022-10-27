using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        UserRepository userRepository;
        MealCategoryRepository mealCategoryRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
            userRepository = new UserRepository();
            mealCategoryRepository = new MealCategoryRepository();
        }
        public Meal GetMealByUserIDandMealCategoryID(string userID, int mealCategoryID, DateTime dateTime)
        {
            Meal meal = mealRepository.GetMealByUserIDandMealCategoryID(userID, mealCategoryID, dateTime);
            return meal;
        }
        public Meal GetMealByUserIDandMealCategoryName(string userID, string mealCategoryName, DateTime dateTime)
        {
            Meal meal = mealRepository.GetMealByUserIDandMealCategoryName(userID, mealCategoryName, dateTime);
            return meal;
        }
        public bool Insert(Meal meal)
        {
            return mealRepository.Insert(meal);
        }

        public User FindUserByUserID(string userID)
        {
            return userRepository.GetUserByUserName(userID);
        }
        public MealCategory FindMealCategoryByMealCategoryName(string name)
        {
            return mealCategoryRepository.GetMealCategoryByName(name);
        }

    }
}
