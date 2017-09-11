using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interfaces
{
    interface ISpecification<T>
    {
        Expression<Func<T, bool>> Critiria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        void AddInclude(Expression<Func<T, object>> includeExpression);
    }
}
