using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendar.Business.Abstract;
using Calendar.Entity;
using Microsoft.AspNetCore.Mvc;
using Calendar.DataAccess;
using Calendar.Business.Concrete;
using System.Globalization;


namespace Calendar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private ICalendarService _calenderService;

        public CalendarController()
        {
            _calenderService = new CalendarManager();
        }

        [HttpGet]
        public List<Etkinlik> Get()
        {
            return _calenderService.GetAllEvents();
        }

        /*public Event LoadEvents()
        {
            List<Event> events = new List<Event>();

            using(var db = new CalendarDbContext())
            {
                events = db.Events.ToList();
            }

            ViewBag.users = users;
        }*/

        [HttpGet("{id}")]
        public Etkinlik Get(int id)
        {
            return _calenderService.GetEventById(id);//
        }

        [HttpPost]
        public Etkinlik Post([FromBody] Etkinlik eventx)
        {
            return _calenderService.CreateEvent(eventx);
        }

        //[HttpGet("getAll")]
        //public Etkinlik GetAll()
        //{
        //    return _calenderService.GetAll();
        //}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _calenderService.DeleteEvent(id);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Etkinlik eventx)
        {
            // İstenen tarih biçimine dönüşümü burada gerçekleştirin
            eventx.StartTime = DateTime.ParseExact(eventx.StartTime.ToString("yyyy-MM-ddTHH:mm:ss"), "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            eventx.EndTime = DateTime.ParseExact(eventx.EndTime.ToString("yyyy-MM-ddTHH:mm:ss"), "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);

            var existingEvent = _calenderService.GetEventById(id);

            if (existingEvent == null)
            {
                return NotFound(); // Etkinlik bulunamadıysa 404 hatası döndürün
            }

            // Güncelleme işlemi
            existingEvent.Title = eventx.Title;
            existingEvent.StartTime = eventx.StartTime;
            existingEvent.EndTime = eventx.EndTime;

            _calenderService.UpdateEvent(existingEvent);

            return Ok(existingEvent); // Başarılı güncelleme yanıtı
        }

        //public IActionResult Index()
        //{
        //    var dictionary = GetDictionaryFromDatabase();
        //    return View(dictionary);
        //}

    }
}
