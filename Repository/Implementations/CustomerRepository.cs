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
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            
        }
        public List<Customer> GetCustomers()
        {
            return _context.Set<Customer>()
                .Include(c=>c.Car)
                .ToList();
        }
    }
}
