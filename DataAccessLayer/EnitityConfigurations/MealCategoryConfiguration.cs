using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class MealCategoryConfiguration : EntityTypeConfiguration<MealCategory>
    {
        public MealCategoryConfiguration()
        {
            Property(mc => mc.MealCategoryName).IsRequired().HasMaxLength(100);
        }
    }
}
