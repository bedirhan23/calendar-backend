using Calendar.Business.Abstract;
using Calendar.DataAccess;
using Calendar.DataAccess.Abstract;
using Calendar.DataAccess.Concrete;
using Calendar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
//using Calendar.Entity

namespace Calendar.Business.Concrete
{
    public class CalendarManager : ICalendarService
    {
        private ICalendarRepo _calenderRepo;

        public CalendarManager()
        {
            _calenderRepo = new CalendarRepo();
        }
        public Etkinlik CreateEvent(Etkinlik eventx)
        {
            return _calenderRepo.CreateEvent(eventx);
        }

        public void DeleteEvent(int id)
        {
            _calenderRepo.DeleteEvent(id);
        }

        public List<Etkinlik> GetAllEvents()

        {
            return _calenderRepo.GetAllEvents();
        }

        public Etkinlik GetEventById(int id)
        {
            if (id > 0)
            {
                return _calenderRepo.GetEventById(id);
            }
            throw new Exception("ID can't be less than 1!!!!");
            
        }

        public Etkinlik UpdateEvent(Etkinlik eventx)
        {
            return _calenderRepo.UpdateEvent(eventx);
        }

        //public Dictionary<int, string> GetDictionaryFromDatabase()
        //{
        //    Dictionary<int, string> dictionary = new Dictionary<int, string>();

        //    using (var context = new CalendarDbContext())
        //    {
        //        var dataFromDatabase = context.Events.ToList();

        //        foreach (var item in dataFromDatabase)
        //        {
        //            dictionary.Add(item.Id, item.Title, item.StartTime, item.EndTime);
        //        }
        //    }

        //    return dictionary;
        //}
    }
}
