using System.Linq.Expressions;
using System.Collections.Generic;
using System; 

namespace Core.Specifications
{
    public interface ISpecifications<T>
    {
        Expression<Func<T,bool>>Criteria{get;}
        List<Expression<Func<T,object>>>Includes{get;}
    }
}