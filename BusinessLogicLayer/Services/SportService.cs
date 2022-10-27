using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class SportService
    {
        SportRepository sportRepository;
        ExerciseDetailRepository exerciseDetailRepository;
        public SportService()
        {
            sportRepository = new SportRepository();
            exerciseDetailRepository = new ExerciseDetailRepository();
        }

        public List<Sport> GetCaloriesByQuantity(int burningCalori)
        {
            List<Sport> caloriList = new List<Sport>();
            caloriList = sportRepository.GetCaloriesByQuantity(burningCalori);
            return caloriList;
        }
        public List<Sport> GetSports()
        {
            List<Sport> sportList = new List<Sport>();
            sportList = sportRepository.GetSports();
            return sportList;
        }

        public List<Sport> GetSportsAll()
        {
            List<Sport> sportListAll = new List<Sport>();
            sportListAll = sportRepository.GetSportsAll();
            return sportListAll;
        }

        public bool Insert(Sport sport)
        {
            CheckSport(sport);
            return sportRepository.Insert(sport);
        }
        void CheckSport(Sport sport)
        {
            if (string.IsNullOrWhiteSpace(sport.SportName))
                throw new Exception("Tüm bilgileri eksiksiz bir şekilde giriniz");
            else if (sport.BurningCalori < 0)
                throw new Exception("Yakılan kalori değeri sıfır ve sıfırdan küçük olamaz");
        }

        public bool Delete(Sport sport)
        {
            CheckSportId(sport.SportID);
            return sportRepository.Delete(sport);
        }

        void CheckSportId(int sportID)
        {
            if (sportID <= 0) throw new Exception("Yapılan spor bilgisi bulunamadı");
        }

        public Sport GetBySportID(int sportID)
        {
            CheckSportId(sportID);
            return sportRepository.GetBySportID(sportID);
        }
        public List<Sport> GetFoodsByText(string text)
        {
            return sportRepository.GetSportsByText(text);
        }

        public bool Update(Sport sport)
        {
            return sportRepository.Update(sport);
        }

        public bool DoPassiveBySportID(int sportID)
        {
            Sport sport = GetBySportID(sportID);
            sport.IsActive = false;
            return Update(sport);
        }
        public bool DoActiveBySportID(int sportID)
        {
            Sport sport = GetBySportID(sportID);
            sport.IsActive = true;
            return Update(sport);
        }
        public string GetFavoriteSportByUserID(string userID)
        {
            int sportID = exerciseDetailRepository.GetFavoriteSportIDByUserID(userID);
            if (sportID == 0)
                return "Yok";
            Sport sport = sportRepository.GetBySportID(sportID);
            return sport.SportName;
        }
    }
}
