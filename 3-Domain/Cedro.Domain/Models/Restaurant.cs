using System.Collections.Generic;
using Cedro.Domain.Core.Entities;

namespace Cedro.Domain.Models
{
    public class Restaurant : Entity<Restaurant>
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string DeliveryEstimate { get; set; }
        public string Rating { get; set; }
        public string imagePath { get; set; }
        public string About { get; set; }
        public string Hours { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
        public virtual IEnumerable<Review> Reviews { get; set; }

        public override bool IsValidated()
        {
            throw new System.NotImplementedException();
        }
    }
}