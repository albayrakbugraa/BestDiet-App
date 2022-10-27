using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class WaterConfiguration : EntityTypeConfiguration<Water>
    {
        public WaterConfiguration()
        {
            Property(w => w.Quantity).IsRequired();
            Property(w => w.UserID).IsRequired();
        }
    }
}
