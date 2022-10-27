using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ExerciseDetailService
    {
        ExerciseRepository exerciseRepository;
        ExerciseDetailRepository exerciseDetailRepository;

        public ExerciseDetailService()
        {
            exerciseRepository = new ExerciseRepository();
            exerciseDetailRepository = new ExerciseDetailRepository();
        }
        public List<ExerciseDetail> GetExerciseDetailsBetweenDate(string userID,DateTime dateTime,DateTime dateTime2)
        {
            return exerciseDetailRepository.GetExerciseDetailsBetweenDate(userID,dateTime,dateTime2);
        }

        public List<ExerciseDetail> GetSportsByExercise (string userID,  DateTime dateTime)
        {
            
            Exercise exercise = exerciseRepository.GetExercise(userID, dateTime);
            if (exercise==null)
            {
                return null;
            }

            List<ExerciseDetail> exerciseDetails = exerciseDetailRepository.GetExerciseDetails(exercise.ExerciseID);

            return exerciseDetails;
        }
        public List<ExerciseDetail> GetExerciseDetailsByUserId(string userID)
        {
            return exerciseDetailRepository.GetExerciseDetailsByUserId(userID);
        }
        public int GetSumCalori(string userID,DateTime dateTime)
        {
            Exercise exercise = exerciseRepository.GetExercise(userID, dateTime);
            List<ExerciseDetail> exerciseDetails = exerciseDetailRepository.GetExerciseDetails(exercise.ExerciseID);
            int sum= 0;
            foreach (ExerciseDetail item in exerciseDetails)
            {
                sum += item.BurningCalori;
            }
            return sum;
        }
        public int GetSumCalori(List<ExerciseDetail> exerciseDetails)
        {
            int sum = 0;
            if (exerciseDetails==null)
            {
                return sum;
            }
            
            foreach (ExerciseDetail item in exerciseDetails)
            {
                sum += item.BurningCalori;
            }
            return sum;
        }



        void CheckExerciseDetailId(int exerciseDetailId)
        {
            //if (exerciseDetailId <= 0) throw new Exception("Egzersiz bulunamadı");
        }

        public bool Delete(int exerciseDetailID)
        {
            CheckExerciseDetailId(exerciseDetailID);
            return exerciseDetailRepository.Delete(exerciseDetailID);
        }

        public bool Insert(ExerciseDetail exerciseDetail)
        {
            CheckExerciseDetailId(exerciseDetail.ExerciseDetailID);
            return exerciseDetailRepository.Insert(exerciseDetail);
        }
        public bool Update(ExerciseDetail exerciseDetail)
        {
            CheckExerciseDetailId(exerciseDetail.ExerciseDetailID);
            return exerciseDetailRepository.Update(exerciseDetail);
        }
        public ExerciseDetail GetExerciseDetailById(int exercesiDetailId)
        {
            return exerciseDetailRepository.GetExerciseDetailById(exercesiDetailId);
        }
    }
}
