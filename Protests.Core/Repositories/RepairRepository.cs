using Microsoft.EntityFrameworkCore;
using Protests.Data;
using Protests.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protests.Core.Repositories
{
    public interface IRepairRepository : IRepository<Repair> { }
    public class RepairRepository : IRepairRepository
    {
        private readonly ApplicationContext context;

        public RepairRepository(ApplicationContext context) => this.context = context;

        public Repair Create(Repair entity)
        {
            this.context.Repairs.Add(entity);
            this.context.SaveChanges();// insertinto ...
            return entity;
        }

        public bool Delete(long id)
        {
            this.context.Repairs.Remove(this.GetOne(id));
            this.context.SaveChanges();
            /* if here, command executed without exception */
            return true;
        }
        public IEnumerable<Repair> GetAll(string search)
        {
            var query = this.context.Repairs.AsQueryable();

            return query.ToList();
        }

        public Repair GetOne(long id) =>
            this.context.Repairs
                .Where(p => p.Id == id)
                .First<Repair>();


        public Repair Update(long id, Repair entity)
        {
            entity.Id = id;
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
            return this.GetOne(id);
        }
    }
}
