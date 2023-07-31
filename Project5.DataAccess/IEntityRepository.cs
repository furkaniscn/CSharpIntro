using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    // class--reference type
    // Referans tip olmak zorunda newlenebilir olmak zorunda ve T tipi IEntity veya IEntityden implemente edilen bir şey olmak zorunda.
    // new() eklememizin nedeni IEntity interface olduğu için newlenemez ama IEntity'i implemente eden sınıflar newlenebilir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
