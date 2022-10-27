using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MealCategoryRepository
    {
        public List<MealCategory> GetMealCategories()
        {
            return MainRepository.db.MealCategories.ToList();
        }
        public MealCategory GetMealCategoryByName(string name)
        {
            return MainRepository.db.MealCategories.Where(a=>a.MealCategoryName==name).FirstOrDefault();
        }
    }
}
