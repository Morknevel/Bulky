using System.Linq.Expressions;

namespace Bulky.DataAccess.IRepository;

public interface IRepository<T> where T : class
{
    IEnumerable<T> getAll();
    T Get(Expression<Func<T, bool>> filter);
    T Add(T entity);
    T Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);
}