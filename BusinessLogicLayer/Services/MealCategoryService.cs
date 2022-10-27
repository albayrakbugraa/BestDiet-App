using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MealCategoryService
    {
        MealCategoryRepository mealCategoryRepository;
        public MealCategoryService()
        {
            mealCategoryRepository = new MealCategoryRepository();
        }
        public MealCategory GetMealCategoryByName(string name)
        {
            return mealCategoryRepository.GetMealCategoryByName(name);
        }
    }
}
