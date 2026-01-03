using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_StrategyPatternTogether
{
    public interface IRepository
    {
        string UseOfStrat();
        List<NormalItem> GetAll();
        NormalItem Add(NormalItem item);
        NormalItem Remove(int id);
        NormalItem Update(NormalItem item);
        NormalItem GetById(int id);
    }
}
