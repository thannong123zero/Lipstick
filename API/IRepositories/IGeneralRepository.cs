using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace API.IRepositories
{
    public interface IGeneralRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// The code Expression<Func<TEntity, bool>> filter means the caller will provide a lambda expression based on the TEntity type, and this expression will return a Boolean value. For example, if the repository is instantiated for the Student entity type, the code in the calling method might specify student => student.LastName == "Smith" for the filter parameter.
        ///The code Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy also means the caller will provide a lambda expression.But in this case, the input to the expression is an IQueryable object for the TEntity type.The expression will return an ordered version of that IQueryable object. For example, if the repository is instantiated for the Student entity type, the code in the calling method might specify q => q.OrderBy(s => s.LastName) for the orderBy parameter.
        ///The code in the Get method creates an IQueryable object and then applies the filter expression if there is one:
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        Task<TEntity> GetById(Guid ID);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid ID);
    }
}
