using System;
namespace OnlineCourses.Models
{
    public class Sell
    {
        public int SellId { get; set; }
        public Group Group { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int Discount { get; set; }
    }
}
