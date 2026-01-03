using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiRepositorySOLID
{
    public class Repository:IRepository
    {
        private List<Person> _people;
        public Repository()
        {
            _people = new List<Person>();
        }
        public Person Add(Person toadd)
        {
            _people.Add(toadd);
            return toadd;
        }

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(int id)
        {
            Person foundperson = _people.Find(x => x.Id == id);
            return foundperson;
        }

        public Person Remove(int id)
        {
            Person toremove = GetById(id);
            _people.Remove(toremove);
            return toremove;
        }

        public Person Update(Person person)
        {
            Person p = GetById(person.Id);

            p.Id = person.Id;
            p.Name = person.Name;

            return p;
        }
    }
}
