using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        public List<Customer> GetCustomers();
    }
}
