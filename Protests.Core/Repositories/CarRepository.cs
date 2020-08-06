using Microsoft.EntityFrameworkCore;
using Protests.Data;
using Protests.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protests.Core.Repositories
{
    public interface ICarRepository : IRepository<Car> { }

    public class CarRepository : ICarRepository
    {
        private readonly ApplicationContext context;
        
        public CarRepository(ApplicationContext context) => this.context = context;

        public Car Create(Car entity)
        {
            this.context.Cars.Add(entity);
            this.context.SaveChanges();// insertinto ...
            return entity;
        }

        public bool Delete(long id)
        {
            this.context.Cars.Remove(this.GetOne(id));
            this.context.SaveChanges();
            /* if here, command executed without exception */
            return true;
        }
        public IEnumerable<Car> GetAll(string search)
        {
            var query = this.context.Cars.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                /* simple search */
                query = query.Where(
                    p => p.LicencePlate.Contains(search)
                );
            }
            return query.ToList();
        }

        public Car GetOne(long id) =>
            this.context.Cars
                .Where(p => p.Id == id)
                .First<Car>();


        public Car Update(long id, Car entity)
        {
            entity.Id = id;
                this.context.Entry(entity).State = EntityState.Modified;
                this.context.SaveChanges();
                return this.GetOne(id);
         }
    }
}
