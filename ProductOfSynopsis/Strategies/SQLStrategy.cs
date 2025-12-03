using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProductOfSynopsis.Interfaces;

namespace ProductOfSynopsis.Strategies
{
    public class SQLStrategy<T> : IStrategy<T> where T : class
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
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
