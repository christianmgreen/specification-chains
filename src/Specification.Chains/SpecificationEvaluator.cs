using Specification.Chains.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Specification.Chains.Core.Specifications;

namespace Specification.Chains.Evaluator
{
    // ENTITY FRAMEWORK EXAMPLE
    public class SpecificationEvaluator<TEntity> : ISpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> ApplySpecification(IQueryable<TEntity> input, ISpecification<TEntity> specification)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (specification == null) throw new ArgumentNullException(nameof(specification));

            var query = input;
            // Apply criteria
            var predicate = specification.ToExpression().Compile();
            query = query.Where(x => predicate(x));
            
            return query;
        }
    }
}
