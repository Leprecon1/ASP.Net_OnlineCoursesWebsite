using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Models
{
    public class Events
    {
        public int EventsId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public bool Availability { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public byte[] Image { get; set; }
        public string Direction { get; set; }
    }
}
