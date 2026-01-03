using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_StrategyPatternTogether
{
    public class StratUser : IStrategy
    {
        private readonly IRepository _strategy;
        public StratUser(IRepository strategy)
        {
            _strategy = strategy; 
        }
        public NormalItem Add(NormalItem item)
        {
            return _strategy.Add(item);
        }

        public List<NormalItem> GetAll()
        {
            return _strategy.GetAll();
        }

        public NormalItem GetById(int id)
        {
            return _strategy.GetById(id);
        }

        public NormalItem Remove(int id)
        {
            return _strategy.Remove(id);
        }

        public NormalItem Update(NormalItem item)
        {
            return _strategy.Update(item);
        }
        public string UseOfStrat()
        {
            return _strategy.UseOfStrat();
        }
    }
}
