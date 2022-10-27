using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoodRepository
    {
        public List<Food> GetActiveFoods()
        {
            return MainRepository.db.Foods.Where(a => a.IsActive).ToList();
        }
        public List<Food> GetFoodsAll()
        {
            return MainRepository.db.Foods.ToList();
        }
        public List<Food> GetFoodsByCategory(int foodCategoryID)
        {
            return MainRepository.db.Foods.Where(a => a.FoodCategoryID == foodCategoryID && a.IsActive).ToList();
        }
        public Food GetByFoodID(int foodID)
        {
            return MainRepository.db.Foods.Find(foodID);
        }
        public bool Insert(Food food)
        {
            MainRepository.db.Foods.Add(food);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool Delete(Food food)
        {
            Food deletedFood = MainRepository.db.Foods.Find(food.FoodID);
            deletedFood.IsActive = false;
            return MainRepository.db.SaveChanges() > 0;
        } 
        public List<Food> GetFoodsByText(string text)
        {
            return MainRepository.db.Foods.Where(a => a.FoodName.Contains(text)).ToList();
        }

        public bool UpdateFood(Food food) 
        {
            Food updateFood = MainRepository.db.Foods.Find(food.FoodID);
            updateFood = food;
            return MainRepository.db.SaveChanges() > 0;
        }
    }
}
