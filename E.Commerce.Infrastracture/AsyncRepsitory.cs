using E.Commerce.Application.Contract;
using E.Commerce.Domain.Common;
using E.Commerce.Infrastracture.ContextDemo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Infrastracture
{
    public class AsyncRepsitory<T> : IAsyncRepository<T> where T : class
    {
        DemoContext db;
        public AsyncRepsitory(DemoContext _db)
        {
            db = _db;

        }
        public async Task<T> AddAsync(T Obj)
        {
            await db.Set<T>().AddAsync(Obj);
            await db.SaveChangesAsync();
            return Obj;
        }

        public async Task<T> CheckObjAsync(Expression<Func<T, bool>> predicate)
        {
            return await db.Set<T>().SingleOrDefaultAsync(predicate);
        }

        public Task<T> CheckObjAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public async Task<T> DeleteAsync(T Obj)
        {
            db.Set<T>().Remove(Obj);
            await db.SaveChangesAsync();
            return Obj;
        }

        public async Task<T> DeleteByIdAsync(int ID)
        {
            var Obj = await db.Set<T>().FindAsync(ID);
            db.Set<T>().Remove(Obj);
            await db.SaveChangesAsync();
            return Obj;
        }

        public async Task<IList<T>> GetAllAsync()
        {


            var data = await db.Set<T>().Select(a => a).ToListAsync();
            return data;

        }

        public async Task<T> GetByIDAsync(int ID)
        {
            var Obj = await db.Set<T>().FindAsync(ID);
            return Obj;
        }

        public async Task<T> UpdateAsync(T Obj)
        {
            db.Entry(Obj).State = EntityState.Modified;

            await db.SaveChangesAsync();
            return Obj;
        }

        

    }
}
