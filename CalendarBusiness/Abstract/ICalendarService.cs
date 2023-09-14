using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Calendar.DataAccess;

namespace Calendar.Business.Abstract
{
    public interface ICalendarService
    {
        List<Etkinlik> GetAllEvents();
        Etkinlik GetEventById(int id);
        Etkinlik CreateEvent(Etkinlik eventx);
        Etkinlik UpdateEvent(Etkinlik eventx);
        void DeleteEvent(int id);
    }
}
