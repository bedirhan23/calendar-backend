using Calendar.Business.Abstract;
using Calendar.DataAccess.Abstract;
using Calendar.DataAccess.Concrete;
using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Business.Concrete
{
    public class UserManager : IUserService
      
    {
        private IUserRepo _userRepo;

        public UserManager()
        {
            _userRepo = new UserRepo();
        }

        public User CreateUser(User user)
        {
            return _userRepo.CreateUser(user);
        }

        public User GetUser(string username, string password)
        {
            return _userRepo.GetUser(username, password);
        }

    }
}
