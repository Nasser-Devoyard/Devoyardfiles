using Service.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IServices
{
    public interface IEventService
    {
        void CreateEvent(CreateOrUpdateEventDto dto);
        EventDto GetEventById(int Id);
        List<EventDto> GetAllEvents();
        EventDto UpdateEvent(EventDto @event);
        void DeleteEvent(int eventId);
    }
}
