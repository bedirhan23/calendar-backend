using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Calendar.DataAccess;

namespace Calendar.Business.Abstract
{
    public interface IUserService
    {
        User CreateUser(IUserService user); 
    }
}
