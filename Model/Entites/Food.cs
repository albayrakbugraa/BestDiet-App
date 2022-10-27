using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Food
    {
        public Food()
        {
            MealDetails = new HashSet<MealDetail>();
        }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Calori { get; set; }
        public int FoodCategoryID { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }

        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public string ImagePath { get; set; }
    }
}
