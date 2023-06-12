using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IServices;
using TraningProject.Web.Models.Events;

namespace TraningProject.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public IActionResult Index()
        {
            var events = _eventService.GetAllEvents();
            var modal = new IndexModal()
            {
                Events = events,
            };
            return View(modal);
        }

        [HttpGet]
        public IActionResult CreateEvent()
        {
            var modal = new CreateEventModal();
            return View(modal);
        }

        [HttpPost]
        public IActionResult CreateEvent(CreateEventModal modal)
        {
            _eventService.CreateEvent(modal);

            return RedirectToAction("Index");
        }

    }
}
