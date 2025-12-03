using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy
{
    public class MemoryStrat<T> : AbstractStrategy<T> where T : class
    {
        private readonly List<T> list;
        public MemoryStrat()
        {
            list = new List<T>();
        }
        public override T Add(T item)
        {
            list.Add(item);
            return item;
        }

        public override T Delete(T item)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll()
        {
            return list;
        }

        public override T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
