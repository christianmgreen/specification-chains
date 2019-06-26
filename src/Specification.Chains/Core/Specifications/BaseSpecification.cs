using Specification.Chains.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Specification.Chains.Core.Specifications
{
    public abstract class BaseSpecification<TEntity> : ISpecification<TEntity> where TEntity : BaseEntity
    {
        public Expression<Func<TEntity, bool>> Criteria { get; protected set; }

        public BaseSpecification()
        {

        }
        public BaseSpecification(Expression<Func<TEntity, bool>> criteria)
        {
            Criteria = criteria;
        }
        public virtual Expression<Func<TEntity, bool>> ToExpression()
        {
            return Criteria;
        }
        public BaseSpecification<TEntity> And(BaseSpecification<TEntity> spec)
        {
            return new AndSpecification<TEntity>(this, spec);
        }
        public BaseSpecification<TEntity> Or(BaseSpecification<TEntity> spec)
        {
            return new OrSpecification<TEntity>(this, spec);
        }
    }
}
