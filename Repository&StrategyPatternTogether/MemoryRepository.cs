using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_StrategyPatternTogether
{
    public class MemoryRepository : IRepository
    {
        private List<NormalItem> items;
        public MemoryRepository()
        {
            items = new List<NormalItem>();
        }
        public NormalItem Add(NormalItem item)
        {
            items.Add(item);
            return item;
        }

        public List<NormalItem> GetAll()
        {
            return items;
        }

        public NormalItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public NormalItem Remove(int id)
        {
            throw new NotImplementedException();
        }

        public NormalItem Update(NormalItem item)
        {
            throw new NotImplementedException();
        }

        public string UseOfStrat()
        {
            return "You are using memory repository now";
        }
    }
}
