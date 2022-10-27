using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class FoodConfiguration : EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            Property(a => a.FoodName).IsRequired().HasMaxLength(200);
            Property(a => a.Calori).IsRequired();
            Property(a => a.FoodCategoryID).IsRequired();            
        }
    }
}
