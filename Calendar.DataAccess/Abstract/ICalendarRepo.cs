using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.DataAccess.Abstract
{
    public interface ICalendarRepo
    {
        List<Etkinlik> GetAllEvents();
        Etkinlik GetEventById(int id);
        Etkinlik CreateEvent(Etkinlik eventx);
        Etkinlik UpdateEvent(Etkinlik eventx);
        void DeleteEvent(int id);
    }
}
