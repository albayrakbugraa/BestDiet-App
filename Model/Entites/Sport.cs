using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Sport
    {
        public Sport()
        {
            ExerciseDetails = new HashSet<ExerciseDetail>();
        }
        public int SportID { get; set; }
        public string SportName { get; set; }
        public int BurningCalori { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public virtual ICollection<ExerciseDetail> ExerciseDetails { get; set; }
    }
}
