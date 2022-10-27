using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class FoodCategoryService
    {
        FoodCategoryRepository foodCategoryRepository;
        public FoodCategoryService()
        {
            foodCategoryRepository = new FoodCategoryRepository();
        }
        public List<FoodCategory> GetFoodCategories()
        {
            List<FoodCategory> foodCategories = new List<FoodCategory>();
            foodCategories=foodCategoryRepository.GetFoodCategories();
            return foodCategories;
        }
    }
}
