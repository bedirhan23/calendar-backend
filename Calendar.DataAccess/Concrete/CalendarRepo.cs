using Calendar.DataAccess.Abstract;
using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar.DataAccess.Concrete
{
    public class CalendarRepo : ICalendarRepo
    {
        public Etkinlik CreateEvent(Etkinlik eventx)
        {
            using (var calendarDbContext = new CalendarDbContext())
            {
                calendarDbContext.Events.Add(eventx);
                calendarDbContext.SaveChanges();
                return eventx;            }
        }

        public void DeleteEvent(int id)
        {
            using (var calendarDbContext = new CalendarDbContext())
            {
                var deletedEvent = GetEventById(id);
                if (deletedEvent != null)
                {
                    calendarDbContext.Events.Remove(deletedEvent);
                    calendarDbContext.SaveChanges();
                }
                else
                {
                    
                }
            }
        }

        public List<Etkinlik> GetAllEvents()
        {
            using (var calendarDbContext = new CalendarDbContext())
            {
                return calendarDbContext.Events.ToList();
            }
        }

        public Etkinlik GetEventById(int id)
        {
            using (var calendarDbContext = new CalendarDbContext())
            {
                return calendarDbContext.Events.FirstOrDefault(s => s.Id == id);
            }
        }

        public Etkinlik UpdateEvent(Etkinlik eventx)
        {
            using (var calendarDbContext = new CalendarDbContext())
            {
                calendarDbContext.Events.Update(eventx);

                calendarDbContext.SaveChanges();
                return eventx;
            }
        }
    }
}
