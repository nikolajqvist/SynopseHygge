using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AlternativeStrategy.WIthAbstract;

namespace AlternativeStrategy.TemplatePattern
{
    public abstract class AbstractTemplate
    {
        public void AddFlow(PPerson person)
        {
            Validate(person);
            Add(person);
            Success(person);
        }
        public void GetFlow(PPerson person)
        {
            GetAll();
            Success(person);
        }
        public abstract PPerson Validate(PPerson person);
        public abstract PPerson Add(PPerson person);
        public abstract List<PPerson> GetAll();
        public virtual void Success(PPerson person)
        {
            Console.WriteLine($"Success {person.Name} is added to database.");
        }
    }
}
