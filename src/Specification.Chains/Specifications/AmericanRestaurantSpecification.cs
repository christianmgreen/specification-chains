using Specification.Chains.Core.Specifications;
using Specification.Chains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Specification.Chains.Specifications
{
    public class AmericanRestaurantSpecification : BaseSpecification<Restaurant>
    {
        public AmericanRestaurantSpecification()
            : base(r => r.Categories.Contains(RestaurantCategory.American)) { }
    }
}
