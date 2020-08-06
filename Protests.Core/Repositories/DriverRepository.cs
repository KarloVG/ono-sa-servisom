using Microsoft.EntityFrameworkCore;
using Protests.Data;
using Protests.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protests.Core.Repositories
{
    public interface IDriverRepository : IRepository<Driver> { }
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationContext context;

        public DriverRepository(ApplicationContext context) => this.context = context;

        public Driver Create(Driver entity)
        {
            this.context.Drivers.Add(entity);
            this.context.SaveChanges();// insertinto ...
            return entity;
        }

        public bool Delete(long id)
        {
            this.context.Drivers.Remove(this.GetOne(id));
            this.context.SaveChanges();
            /* if here, command executed without exception */
            return true;
        }
        public IEnumerable<Driver> GetAll(string search)
        {
            var query = this.context.Drivers.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                /* simple search */
                query = query.Where(
                    p => p.FirstName.Contains(search) || p.LastName.Contains(search)
                );
            }
            return query.ToList();
        }

        public Driver GetOne(long id) =>
            this.context.Drivers
                .Where(p => p.Id == id)
                .First<Driver>();


        public Driver Update(long id, Driver entity)
        {
            entity.Id = id;
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
            return this.GetOne(id);
        }
    }
}
