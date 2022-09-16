﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context C = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = C.Set<T>();
        }


        public void Delete(T p)
        {
            var deletedEntity = C.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            C.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var EddedEntity = C.Entry(p);
            EddedEntity.State = EntityState.Added;
            //_object.Add(p);
            C.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = C.Entry(p);
            updatedEntity.State = EntityState.Modified; 
             C.SaveChanges();
        }
    }
}
