using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class MealCategory
    {
        public MealCategory()
        {
            Meals = new HashSet<Meal>();
        }

        public int MealCategoryID { get; set; }
        public string MealCategoryName { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}
