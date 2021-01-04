using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCourses.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime Date { get; set; }
        public int Periodicity { get; set; }
        public int Price { get; set; }
    }
}
