using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductOfSynopsis.Interfaces;

namespace ProductOfSynopsis.Strategies
{
    public class MemoryStrategy<T> : IStrategy<T> where T : class
    {
        private readonly List<T> _list;
        public MemoryStrategy()
        {
            _list = new List<T>();
        }
        public T Add(T entity)
        {
            _list.Add(entity);
            return entity;
        }

        public T DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _list;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
