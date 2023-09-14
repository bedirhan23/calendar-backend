using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Calendar.DataAccess.Abstract;

namespace Calendar.DataAccess.Concrete
{
    public class UserRepo : IUserRepo
    {
        public User GetUser(string email, string password)
        {
            using (var CalendarDbContext = new CalendarDbContext())
            {
                CalendarDbContext.Users.ToList();

            }
            return new User();


            //return LoginPageDbContext.Users.FirstOrDefault(x=>x.UserName == username && x.Password == password);
        }

        public User CreateUser(User user)
        {
            using (var calendarDbContext = new CalendarDbContext())
            {
                calendarDbContext.Users.Add(user);
                calendarDbContext.SaveChanges();
                return user;
            }
        }

    }
}
