using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class ExerciseDetail
    {
        public int ExerciseDetailID { get; set; }
        public int ExerciseID { get; set; }
        public virtual Exercise Exercise { get; set; }
        public int SportID { get; set; }
        public virtual Sport Sport { get; set; }
        public int Minute { get; set; }
        public int BurningCalori { get; set; }
    }
}
