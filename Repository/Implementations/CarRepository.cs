using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public List<Car> GetCars()
        {
            return _context.Set<Car>()
                .Include(c => c.Category)
                .Include(t=>t.Transmission)
                .ToList();
        }
    }
}
