using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.DataAccess.Abstract
{
    public interface IUserRepo
    {
        User CreateUser(User user);
        User GetUser(string username, string password);
    }
}
