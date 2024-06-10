using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_DAL.Repositories.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
        T Add(T Pilot);
        T Update(T Pilot);
        bool Delete(int id);
        bool Delete(T Pilot);
    }
}
