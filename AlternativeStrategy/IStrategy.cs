using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy
{
    public interface IStrategy<T> where T : class
    {
        List<T> GetAll();
        T Add(T item);
        T Delete(T item);
        T GetById(int id);
    }
}
