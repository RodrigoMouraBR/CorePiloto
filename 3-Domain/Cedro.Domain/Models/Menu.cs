using System;
using Cedro.Domain.Core.Entities;

namespace Cedro.Domain.Models
{
    public class Menu : Entity<Menu>
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Guid RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; } 
        public override bool IsValidated()
        {
            throw new System.NotImplementedException();
        }
    }
}