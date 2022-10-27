using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class MealDetail
    {
        public int MealDetailID { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int Quantity { get; set; }
        public decimal Portion { get; set; }
        public int Calori  { get; set; }
    }
}
