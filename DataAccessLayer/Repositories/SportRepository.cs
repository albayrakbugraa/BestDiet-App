using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SportRepository
    {
        public List<Sport> GetCaloriesByQuantity(int burningCalori)
        {
            return MainRepository.db.Sports.Where(w => w.BurningCalori == burningCalori).ToList();
        }
        public Sport GetBySportID(int sportID)
        {
            return MainRepository.db.Sports.Find(sportID);
        }
        public List<Sport> GetSports()
        {
            return MainRepository.db.Sports.Where(u => u.IsActive == true).ToList();
        }

        public List<Sport> GetSportsAll()
        {
            return MainRepository.db.Sports.ToList();
        }

        public bool Insert(Sport sport)
        {
            MainRepository.db.Sports.Add(sport);
            return MainRepository.db.SaveChanges() > 0;
        }
        public bool Delete(Sport sport)
        {
            Sport deletedSport = MainRepository.db.Sports.Find(sport.SportID);
            deletedSport.IsActive = false;
            return MainRepository.db.SaveChanges() > 0;
        }
        public List<Sport> GetSportsByText(string text)
        {
            return MainRepository.db.Sports.Where(a => a.SportName.Contains(text)).ToList();
        }

        public bool Update(Sport sport)
        {
            Sport updateSport = GetBySportID(sport.SportID);
            updateSport.SportName = sport.SportName;
            updateSport.BurningCalori = sport.BurningCalori;
            return MainRepository.db.SaveChanges()>0;
        }
    }
}
