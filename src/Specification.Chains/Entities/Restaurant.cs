using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Chains.Entities
{
    public class Restaurant : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public IEnumerable<RestaurantCategory> Categories { get; set; }
        public Menu Menu { get; set; }
        public double Rating { get; set; }
    }
}
