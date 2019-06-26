using Specification.Chains.Core.Specifications;
using Specification.Chains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specification.Chains.Specifications
{
    public class ItalianRestaurantSpecification : BaseSpecification<Restaurant>
    {
        public ItalianRestaurantSpecification()
            : base(r => r.Categories.Contains(RestaurantCategory.Italian)) { }
    }
}
