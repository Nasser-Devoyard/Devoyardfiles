using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}