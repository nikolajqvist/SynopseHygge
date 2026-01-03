using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlternativeStrategy;
using AlternativeStrategy.TemplatePattern;

namespace AlternativeStrategy.WIthAbstract
{
    public class Strategy
    {
        private readonly AbstractRepository _abstractRepository;
        public Strategy(AbstractRepository abstractRepository)
        {
            _abstractRepository = abstractRepository; 
        }
        public List<PPerson> GetAll()
        {
            return _abstractRepository.GetAll();
        }
        public PPerson Add(PPerson person)
        {
            return _abstractRepository.Add(person);
        }
    }
}
