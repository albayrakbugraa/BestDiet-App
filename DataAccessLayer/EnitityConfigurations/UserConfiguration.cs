using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u=> u.UserID).IsRequired().HasMaxLength(100);
            Property(u=>u.FirstName).IsRequired().HasMaxLength(100);
            Property(u => u.LastName).IsRequired().HasMaxLength(100);
            Property(u => u.Gender).IsRequired();
            Property(u => u.Height).IsRequired();
            Property(u => u.Weight).IsRequired();
            Property(u => u.TargetWeight).IsRequired();
            Property(u => u.BirthDate).IsRequired();
            Property(u => u.UserType).IsRequired();
        }
    }
}
