﻿using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq.Expressions;

namespace ExaminationSystem.Data.Repository
{
    public class Repository<Entity> : IRepository<Entity> where Entity : BaseModel
    {
        Context _context;
        DbSet<Entity> _dbSet;

        public Repository(Context context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }

        public void Add(Entity entity)
        {
            entity.CreatedDate = DateTime.Now;
            //entity.CreatedBy = userID;

            _dbSet.Add(entity);
        }

        public bool SaveInclude(Entity entity, params string[] properties)
        {
            var local = _dbSet.Local.FirstOrDefault(x => x.ID == entity.ID);
            string[] immutableProperties = [nameof(entity.CreatedDate), nameof(entity.CreatedBy)];

            EntityEntry entry = null;

            if(local is null)
            {
                entry = _context.Entry(entity);
            }
            else
            {
                entry = _context.ChangeTracker.Entries<Entity>()
                    .FirstOrDefault(x => x.Entity.ID == entity.ID);
            }

            foreach (var property in entry.Properties)
            {
                if(properties.Contains(property.Metadata.Name)
                   && !property.Metadata.IsPrimaryKey()
                   && !immutableProperties.Contains(property.Metadata.Name))
                {
                    property.CurrentValue = entity.GetType().GetProperty(property.Metadata.Name).GetValue(entity);
                    property.IsModified = true;
                }
            }
            return true;
        }
        public bool Delete(Entity entity)
        {
            entity.Deleted = true;
            return SaveInclude(entity, nameof(BaseModel.Deleted));
        }

        public void HardDelete(Entity entity)
        {
            _dbSet.Remove(entity);
        }


        public IQueryable<Entity> Get(Expression<Func<Entity, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<Entity> GetAll()
        {
            return _dbSet.Where(x => ! x.Deleted);
        }

        public IQueryable<Entity> GetAllWithDeleted()
        {
            return _dbSet;
        }

        public IQueryable<Entity> GetByID(int id)
        {
            return _dbSet.Where(x => x.ID == id && !x.Deleted);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
