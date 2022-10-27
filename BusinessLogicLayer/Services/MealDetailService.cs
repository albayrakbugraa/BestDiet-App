using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MealDetailService
    {
        MealRepository mealRepository;
        MealDetailRepository mealDetailRepository;

        public MealDetailService()
        {
            mealRepository = new MealRepository();
            mealDetailRepository = new MealDetailRepository();
        }

        public List<MealDetail> GetMealDetailsByMealID(int mealID)
        {
            return mealDetailRepository.GetMealDeteailsByMealId(mealID);
        }
        public List<MealDetail> GetMealDetailsByUserId(string userID,DateTime dateTime)
        {
            return mealDetailRepository.GetMealDetailsByUserId(userID,dateTime);
        }
        public List<MealDetail> GetMealDetailsBetweenDate(string userID, DateTime dateTime, DateTime dateTime2)
        {
            return mealDetailRepository.GetMealDetailsBetweenDate(userID,dateTime,dateTime2);
        }
        public int GetSumCalori(List<MealDetail> mealDetails)
        {
            int sum= 0;
            foreach (MealDetail item in mealDetails)
            {
                sum += item.Calori;
            }
            return sum;

        }
        public int GetSumCalori(int mealID)
        {
            List<MealDetail> mealDetails=GetMealDetailsByMealID(mealID);
            int sum = 0;
            foreach (MealDetail item in mealDetails)
            {
                sum += item.Calori;
            }
            return sum;

        }
        public bool Delete(int mealDetailID)
        {
            CheckMealDetailId(mealDetailID);
            return mealDetailRepository.Delete(mealDetailID);

        }
        void CheckMealDetailId(int mealDetailId)
        {
            if (mealDetailId <= 0) throw new Exception("Öğüne ait yiyecekler bulunamadı.");
        }
        public bool Insert(MealDetail mealDetail)
        {
            //CheckMealDetailId(mealDetail.MealDetailID);
            return mealDetailRepository.Insert(mealDetail);
        }
        public bool Update(MealDetail mealDetail)
        {
            CheckMealDetailId(mealDetail.MealDetailID);
            return mealDetailRepository.Update(mealDetail);
        }
        public MealDetail GetMealDetailById(int mealDetailId)
        {
            CheckMealDetailId(mealDetailId);
            return mealDetailRepository.GetMealDetailById(mealDetailId);
        }
    }
}
