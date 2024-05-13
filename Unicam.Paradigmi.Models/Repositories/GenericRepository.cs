﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicam.Paradigmi.Models.Context;

namespace Unicam.Paradigmi.Models.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        protected MyDbContext _ctx;

        public GenericRepository(MyDbContext ctx)
        {
            _ctx = ctx;
        }

        public virtual T Get(object id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public virtual void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public IEnumerable<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

    }
}