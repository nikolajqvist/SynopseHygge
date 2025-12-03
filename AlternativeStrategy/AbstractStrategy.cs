using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy
{
    public abstract class AbstractStrategy<T> : IStrategy<T> where T : class 
    {
        public abstract T Add(T item);
        public abstract T Delete(T item);
        public abstract List<T> GetAll();
        public abstract T GetById(int id);
    }
}
