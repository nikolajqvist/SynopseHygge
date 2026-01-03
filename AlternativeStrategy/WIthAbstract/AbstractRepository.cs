using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy.WIthAbstract
{
    public abstract class AbstractRepository
    {
        public abstract List<PPerson> GetAll();
        public abstract PPerson Add(PPerson person);
        public abstract PPerson Update(PPerson person);
        public abstract PPerson Delete(int persontodelete);
    }
}
