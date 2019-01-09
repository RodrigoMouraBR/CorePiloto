using System;

namespace Cedro.Application.ViewModels
{
    public class MenuViewModel
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Guid RestaurantId { get; set; }
        public virtual RestaurantViewModel Restaurant { get; set; } 
    }
}