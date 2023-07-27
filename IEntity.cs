using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityToSQL
{
    interface IEntity<T> where T : class
    {
        IList<T> List();

        IList<T> List(int? page, int? pageSize, Expression<Func<T, bool>> predicate, Expression<Func<T, object>> sort);

        void Add(T item);

        T Get(Int64 Id);

        void Update(T item);

        bool Delete(T Item);
    }
}
