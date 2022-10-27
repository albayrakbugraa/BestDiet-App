using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class User
    {
        public User()
        {
            Meals = new HashSet<Meal>();
            Waters = new HashSet<Water>();
            Exercises = new HashSet<Exercise>();
        }

        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public double TargetWeight { get; set; }
        public DateTime BirthDate { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Water> Waters { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }

        public UserType UserType { get; set; }
        public string Password { get; set; }
    }
}
