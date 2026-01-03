using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AlternativeStrategy.WIthAbstract;

namespace AlternativeStrategy.TemplatePattern
{
    public class MemoryRepo : AbstractTemplate
    {
        private List<PPerson> _persons;
        public MemoryRepo()
        {
            _persons = new List<PPerson>();
        }
        public override PPerson Add(PPerson person)
        {
            _persons.Add(person);
            return person;
        }

        public override List<PPerson> GetAll()
        {
            return _persons;
        }
        public override PPerson Validate(PPerson person)
        {
            if(person.Id != 0 && person.Name != null)
            {
                return person;
            }
            return null;
        }
    }
}
