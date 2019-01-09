using System;

namespace Cedro.Application.ViewModels
{
    public class ReviewViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public Guid RestaurantId { get; set; }
        public virtual RestaurantViewModel Restaurant { get; set; } 
    }
}