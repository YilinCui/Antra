using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Stack
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly List<T> _store = new List<T>();

        public void Add(T item)
        {
            _store.Add(item);
        }

        public void Remove(T item)
        {
            _store.Remove(item);
        }

        public void Save()
        {
        }

        public IEnumerable<T> GetAll()
        {
            return _store;
        }

        public T GetById(int id)
        {
            return _store.FirstOrDefault(item => item.Id == id);
        }
    }

}
