using Specification.Chains.Core.Specifications;
using Specification.Chains.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Chains.Specifications
{
    public class GoodRestaurantSpecification : BaseSpecification<Restaurant>
    {
        public GoodRestaurantSpecification()
            : base(r => r.Rating > 4.0) { }
    }
}
