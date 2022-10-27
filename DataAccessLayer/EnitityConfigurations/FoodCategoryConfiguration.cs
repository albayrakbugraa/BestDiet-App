using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class FoodCategoryConfiguration : EntityTypeConfiguration<FoodCategory>
    {
        public FoodCategoryConfiguration()
        {
            Property(a => a.CategoryName).IsRequired().HasMaxLength(200);
        }
    }
}
