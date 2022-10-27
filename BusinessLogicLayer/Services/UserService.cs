using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public User CheckLogin(string userName, string password)
        {
            return userRepository.CheckLogin(userName, password);
        }
        public User GetUserByUserName(string userName)
        {
            return userRepository.GetUserByUserName(userName);
        }
        public bool InsertUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName))
                throw new Exception("İsim yada Soyisim boş olamaz!");
            else if (user.BirthDate > DateTime.Now.AddYears(-6))
                throw new Exception("Kullanıcı 6 yaşından küçük olamaz!");
            else if (user.Height < 100 || user.Height > 240)
                throw new Exception("Kullanıcı boyu 100cm den az, 240cm den fazla olamaz!");
            else if (user.Weight < 40 || user.Weight > 400)
                throw new Exception("Kullanıcı kilosu 40kg den küçük, 400kg den fazla olamaz!");
            else if (user.TargetWeight > user.Weight || user.TargetWeight < 40)
                throw new Exception("Kullanıcı hedef kilosu şu anki kilosundan büyük olamaz ve 40kg den az olamaz");
            else if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Şifre boş olamaz");
            
            return userRepository.InsertUser(user);
        }
        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public int GetAge(string userID)
        {
            User user = GetUserByUserName(userID);
            return DateTime.Now.Year - user.BirthDate.Year;
        }

        public List<User> GetUsersByText(string text)
        {
            return userRepository.GetUserByText(text);
        }

        public bool DoPassiveByUserID(string userID)
        {
            User user = GetUserByUserName(userID);
            user.IsActive = false;
            return userRepository.Update(user);
        }
        public bool DoActiveByUserID(string userID)
        {
            User user = GetUserByUserName(userID);
            user.IsActive = true;
            return userRepository.Update(user);
        }
    }
}
