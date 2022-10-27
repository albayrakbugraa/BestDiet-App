using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class WaterService
    {
        WaterRepository waterRepository;
        public WaterService()
        {
            waterRepository = new WaterRepository();
        }

        public Water GetWaterByDateAndUserName(DateTime dateTime, string userName)
        {
            return waterRepository.GetWaterByDateAndUserName(dateTime,userName);
        }
        public List<Water> GetWaterByBetweenDate(DateTime dateTime, DateTime dateTime2, string userName)
        {
            return waterRepository.GetWaterByBetweenDate(dateTime,dateTime2,userName);
        }

        public bool UpdateWater(Water water)
        {
            return waterRepository.UpdateWaterByWater(water);
        }
        
        public bool AddWater(Water water)
        {
            return waterRepository.AddWater(water);
        }
        public double GetWaterDrinked(DateTime dateTime, string userName)
        {
            Water _water = waterRepository.GetWaterByDateAndUserName(dateTime, userName);
            return _water.Quantity;
        }
    }
}
