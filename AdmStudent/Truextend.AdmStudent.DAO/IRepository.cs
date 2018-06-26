using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.DAO
{
    public interface IRepository<T> where T : class
    {
        int Insert(T entity);

        int Delete(T entity);

        int Update(T entity);

        int Delete(Guid id);

        IEnumerable<T> GetAll();

        IEnumerable<T> FindById(Guid id);
    }
}
