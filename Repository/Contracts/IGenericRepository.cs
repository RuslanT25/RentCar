using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Add(T entity);
        public void UpdateAsync(T entity);
        public void DeleteAsync(T entity);
    }
}
