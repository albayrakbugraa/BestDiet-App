using Model.Entites;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository
    {
        public List<User> GetUsersByUserType(UserType userType)
        {
            return MainRepository.db.Users.Where(u=> u.UserType == userType).ToList();
        }
        public List<User> GetUsersByIsActive(bool isActive)
        {
            return MainRepository.db.Users.Where(u=>u.IsActive == isActive).ToList();
        }
        public User CheckLogin(string userName,string password)
        {
            User user = MainRepository.db.Users.Find(userName);
            if(user !=null && user.Password == password)
            {
                return user;
            }
            return null;
        }
        public User GetUserByUserName(string userName)
        {
            return MainRepository.db.Users.Find(userName);
        }
        public bool InsertUser(User user)
        {
            MainRepository.db.Users.Add(user);
            return MainRepository.db.SaveChanges() > 0;
        }
        public List<User> GetUsers()
        {
            return MainRepository.db.Users.Where(u=> u.UserType == UserType.User).ToList();
        }
        public List<User> GetUserByText(string text)
        {
            return MainRepository.db.Users.Where(u => (u.FirstName.Contains(text) || u.LastName.Contains(text))&& u.UserType==UserType.User).ToList();
        }

        public bool Update(User user)
        {
            User updateUser= GetUserByUserName(user.UserID);
            updateUser.IsActive = user.IsActive;
            return MainRepository.db.SaveChanges() > 0;
        }

    }
}
