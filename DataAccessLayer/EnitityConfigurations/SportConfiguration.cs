using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class SportConfiguration : EntityTypeConfiguration<Sport>
    {
        public SportConfiguration()
        {
            Property(s => s.SportID).IsRequired();
            Property(s => s.SportName).IsRequired().HasMaxLength(100);
            Property(s => s.BurningCalori).IsRequired();
        }
    }
}
