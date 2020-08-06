using Microsoft.EntityFrameworkCore;
using Protests.Data;
using Protests.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protests.Core.Repositories
{
    public interface IRepairOptionRepository : IRepository<RepairOption> { }
    public class RepairOptionRepository : IRepairOptionRepository
    {
        private readonly ApplicationContext context;

        public RepairOptionRepository(ApplicationContext context) => this.context = context;

        public RepairOption Create(RepairOption entity)
        {
            this.context.RepairOptions.Add(entity);
            this.context.SaveChanges();// insertinto ...
            return entity;
        }

        public bool Delete(long id)
        {
            this.context.RepairOptions.Remove(this.GetOne(id));
            this.context.SaveChanges();
            /* if here, command executed without exception */
            return true;
        }
        public IEnumerable<RepairOption> GetAll(string search)
        {
            var query = this.context.RepairOptions.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                /* simple search */
                query = query.Where(
                    p => p.Name.Contains(search)
                );
            }
            return query.ToList();
        }

        public RepairOption GetOne(long id) =>
            this.context.RepairOptions
                .Where(p => p.Id == id)
                .First<RepairOption>();


        public RepairOption Update(long id, RepairOption entity)
        {
            entity.Id = id;
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
            return this.GetOne(id);
        }
    }
}
