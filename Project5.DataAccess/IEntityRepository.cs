using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
