using System;
using System.Collections.Generic;

namespace Specification.Chains.Entities
{
    public class Menu : BaseEntity
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public IEnumerable<MenuCategory> Categories { get; set; }
        public DateTime Published { get; set; }
    }
}