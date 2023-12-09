using System.Linq.Expressions;
using System.Collections.Generic;
using System; 

namespace Core.Specifications
{
    public interface ISpecifications<T>
    {
        Expression<Func<T,bool>>Criteria{get;}
        List<Expression<Func<T,object>>>Includes{get;}

        Expression<Func<T,object>>OrderByDescending{get;}
        Expression<Func<T,object>>OrderBy{get;}

        int Take{get;}
        int Skip{get;}
        bool IsPagingEnabled{get;}
    }
}