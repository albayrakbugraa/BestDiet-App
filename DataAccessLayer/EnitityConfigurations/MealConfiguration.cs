using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            Property(m => m.UserID).IsRequired();
            Property(m=> m.MealCategoryID).IsRequired();
        }
    }
}
