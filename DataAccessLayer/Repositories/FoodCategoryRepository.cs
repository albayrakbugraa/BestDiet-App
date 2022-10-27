using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoodCategoryRepository
    {
        public List<FoodCategory> GetFoodCategories()
        {
            return MainRepository.db.FoodCategories.ToList();
        }
    }
}
