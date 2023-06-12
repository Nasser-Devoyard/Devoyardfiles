using DataAccessLayer.Repositries;
using Service.Common.Dtos;
using ServiceLayer.IServices;

namespace ServiceLayer.Services
{
    public class EventService : IEventService
    {
        public void CreateEvent(CreateOrUpdateEventDto dto)
        {
            var repos = new EventRepository();
            repos.CreateEvent(dto);
        }

        public EventDto GetEventById(int Id)
        {
            var repos = new EventRepository();
            return repos.GetEventById(Id);
        }
        public List<EventDto> GetAllEvents()
        {
            var repos = new EventRepository();
            return repos.GetAllEvents();
        }
        public EventDto UpdateEvent(EventDto @event)
        {
            var repos = new EventRepository();
            return repos.UpdateEvent(@event);
        }
        public void DeleteEvent(int eventId)
        {
            var repos = new EventRepository();
            repos.DeleteEvent(eventId);
        }
    }
}