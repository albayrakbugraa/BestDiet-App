using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entites
{
    public class Water
    {
        public int WaterID { get; set; }
        public double Quantity { get; set; }
        public DateTime WaterDate { get; set; }
        public string UserID { get; set; }

        public virtual User User { get; set; }
    }
}
