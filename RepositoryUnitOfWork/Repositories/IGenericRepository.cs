﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace RepositoryUnitOfWork.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null,
             Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
             string includeProperties = "");

        Task<TEntity> FindByIdAsync(object id);

        void Add(TEntity entity);

        void Delete(int id);

        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
    }
}