using DataAccessLayer.Entities;
using Service.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositries
{
    public class EventRepository
    {
        public void CreateEvent(CreateOrUpdateEventDto dto)
        {
            var entity = new Event();
            entity.StartDate = dto.StartDate;
            entity.EndDate = dto.EndDate;
            entity.EventName = dto.EventName;
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                _dbContext.Events.Add(entity);
                _dbContext.SaveChanges();
            }
        }
        public EventDto GetEventById(int Id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var entity = _dbContext.Events.FirstOrDefault(n => n.EventID == Id);
                if (entity == null)
                {
                    return null;
                }

                var dto = new EventDto()
                {
                    EventName = entity.EventName,
                    StartDate = entity.StartDate,
                    EndDate = entity.EndDate,
                    Id = entity.EventID,
                };

                return dto;
            }
        }
        public List<EventDto> GetAllEvents()
        {
            var li = new List<EventDto>();
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var E = _dbContext.Events.ToList();
                foreach (var item in E)
                {
                    var dto = new EventDto
                    {
                        EventName = item.EventName,
                        StartDate = item.StartDate,
                        EndDate = item.EndDate,
                        Id = item.EventID,
                    };
                    li.Add(dto);
                }

            }
            return li;
        }
        public EventDto UpdateEvent(EventDto @event)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                // Use of lambda expression to access
                // particular record from a database
                var data = _dbContext.Events.FirstOrDefault(x => x.EventID == @event.Id);
                // Checking if any such record exist
                if (data != null)
                {
                    data.EventName = @event.EventName;
                    data.StartDate = @event.StartDate;
                    data.EndDate = @event.EndDate;
                    _dbContext.SaveChanges();
                    return @event;
                }
                else
                {
                    return null;
                }
            }
        }
        public void DeleteEvent(int eventId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var entity = _dbContext.Events.FirstOrDefault(n => n.EventID == eventId);

                _dbContext.Entry(entity).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
        }
    }
}

