using Specification.Chains.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Specification.Chains.Interfaces
{
    public interface ISpecification<TEntity> where TEntity : BaseEntity
    {
        Expression<Func<TEntity, bool>> ToExpression();
    }
}
