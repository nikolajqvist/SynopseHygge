using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy.WIthAbstract
{
    public class NormalRepository : AbstractRepository
    {
        private List<PPerson> _persons;
        public NormalRepository()
        {
            _persons = new List<PPerson>();  
        }
        public override PPerson Add(PPerson person)
        {
            _persons.Add(person);
            return person;
        }

        public override PPerson Delete(int persontodelete)
        {
            throw new NotImplementedException();
        }

        public override List<PPerson> GetAll()
        {
            return _persons;
        }

        public override PPerson Update(PPerson person)
        {
            throw new NotImplementedException();
        }
    }
}
