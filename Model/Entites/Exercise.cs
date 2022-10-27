using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Exercise
    {
        public Exercise()
        {
            ExerciseDetails = new HashSet<ExerciseDetail>();
        }
        public int ExerciseID { get; set; }
        public DateTime ExerciseDate { get; set; }
        public string UserID { get; set; }

        
        public virtual User User { get; set; }
        public virtual ICollection<ExerciseDetail> ExerciseDetails { get; set; }
    }
}
