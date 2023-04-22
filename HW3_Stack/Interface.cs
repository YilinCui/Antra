using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Stack
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    public interface IRepository<T> where T : class, IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

}
