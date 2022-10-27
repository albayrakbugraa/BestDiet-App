using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Meal
    {
        public Meal()
        {
            MealDetails=new HashSet<MealDetail>();
        }
        public int MealID { get; set; }
        public DateTime MealTime { get; set; }
        public string UserID { get; set; }
        public int MealCategoryID { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }


        public virtual MealCategory MealCategory { get; set; }
        public virtual User User { get; set; }        
    }
}
