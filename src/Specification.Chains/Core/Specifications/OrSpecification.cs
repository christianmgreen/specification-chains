using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Specification.Chains.Core.Specifications
{
    public class OrSpecification<TEntity> : BaseSpecification<TEntity> where TEntity : BaseEntity
    {
        private readonly BaseSpecification<TEntity> _left;
        private readonly BaseSpecification<TEntity> _right;
        public OrSpecification(BaseSpecification<TEntity> left, BaseSpecification<TEntity> right)
        {
            _right = right;
            _left = left;
        }

        public override Expression<Func<TEntity, bool>> ToExpression()
        {
            Expression<Func<TEntity, bool>> leftExpression = _left.ToExpression();
            Expression<Func<TEntity, bool>> rightExpression = _right.ToExpression();

            var parameter = leftExpression.Parameters.First();

            var andExpression = Expression.Or(
                leftExpression.Body,
                Expression.Invoke(rightExpression, parameter));

            Criteria = Expression.Lambda<Func<TEntity, bool>>(
                andExpression, parameter);

            return Criteria;
        }
    }
}
