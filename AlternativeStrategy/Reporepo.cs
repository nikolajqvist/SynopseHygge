using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy
{
    public class Reporepo<T>: IRRepository<T> where T : class
    {
        private readonly IStrategy<T> _strategy;

        public Reporepo(IStrategy<T> strategy)
        {
            _strategy = strategy;
        }
        public T Add(T item)
        {
            return _strategy.Add(item);
        }

        public T Delete(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _strategy.GetAll();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
