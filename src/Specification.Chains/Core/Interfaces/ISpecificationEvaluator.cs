using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specification.Chains.Interfaces
{
    public interface ISpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> ApplySpecification(IQueryable<TEntity> input, ISpecification<TEntity> specification);
    }
}
