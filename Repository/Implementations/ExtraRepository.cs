using Data;
using Data.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class ExtraRepository : GenericRepository<Extra>, IExtraRepository
    {
        public ExtraRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}
