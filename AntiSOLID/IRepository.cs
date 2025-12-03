using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiRepositorySOLID
{
    public interface IRepository
    {
        List<Person> GetAll();
        Person Add(Person person);
        Person Remove(int id);
        Person Update(Person person);
        Person GetById(int id);
    }
}
