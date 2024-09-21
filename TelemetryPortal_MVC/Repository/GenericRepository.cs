using TelemetryPortal_MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TelemetryPortal_MVC.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TechtrendsContext _context;

        public GenericRepository(TechtrendsContext context)
        {
            _context = context;
        }

        //THIS METHOD ADDS A RECORD
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        //THIS METHOD IS RESPONSIBLE FOR ADDING A RANGE RECORD
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        //THIS METHOD IS USED TO FIND A RECORD
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        //THE METHOD GETS ALL RECORDS
        public IEnumerable<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        //THIS METHOD GETS A RECORD BY ID
        public T GetByID(int id) 
        {
            var entity = _context.Set<T>().Find(id);
            if (entity == null)
            {
                throw new InvalidOperationException($"Entity of type {typeof(T).Name} with ID {id} not found.");
            }
            return entity;
        }


        //THIS METHOD REMOVES A RECORD
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        //THIS METHOD REMOVES A RANGE
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        //THIS METHOD UPDATES A RECORD
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
