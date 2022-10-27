using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ExerciseRepository
    {
        public List<Exercise> GetExercisesByDate(DateTime dateTime)
        {
            return MainRepository.db.Exercises.Where(m => m.ExerciseDate == dateTime).ToList();
        }
        public Exercise GetExercise(string userID,DateTime dateTime)
        {
            return MainRepository.db.Exercises.Where(a => a.UserID == userID && a.ExerciseDate == dateTime).FirstOrDefault();
        }
        public bool Insert(Exercise exercise)
        {
            MainRepository.db.Exercises.Add(exercise);
            return MainRepository.db.SaveChanges() > 0;
        }
    }
}
