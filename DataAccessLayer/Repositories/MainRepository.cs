using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MainRepository
    {
        public static BestDietDbContext db = new BestDietDbContext();
    }
}
