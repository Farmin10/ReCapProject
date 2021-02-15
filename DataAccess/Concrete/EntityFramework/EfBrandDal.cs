using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand Entity)
        {
            using (ReCapContext contex=new ReCapContext())
            {
               var addedEntity= contex.Entry(Entity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Brand Entity)
        {
            using (ReCapContext contex = new ReCapContext())
            {
                var deletedEntity = contex.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapContext contex = new ReCapContext())
            {
                return  contex.Set<Brand>().SingleOrDefault(filter);
            }
            
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapContext contex = new ReCapContext())
            {
                return filter == null ? contex.Set<Brand>().ToList() : contex.Set<Brand>().Where(filter).ToList();
            }
            
        }

        public void Update(Brand Entity)
        {
            using (ReCapContext contex = new ReCapContext())
            {
                var updatedEntity = contex.Entry(Entity);
                updatedEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
