using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface IAsyncRepository<T>
    {
        public Task<IList<T>> GetAllAsync();
        public Task<T> GetByIDAsync(int ID);
        public Task<T> AddAsync(T Obj);
        public Task<T> UpdateAsync(T Obj);
        public Task<T> DeleteAsync(T Obj);
        public Task<T> DeleteByIdAsync(int ID);
        public Task<T> CheckObjAsync(T obj);
        Task<T> CheckObjAsync(Expression<Func<T, bool>> predicate);
    }
}
