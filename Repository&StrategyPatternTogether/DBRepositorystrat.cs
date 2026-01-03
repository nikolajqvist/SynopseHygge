using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_StrategyPatternTogether
{
    public class DBRepositorystrat : IRepository
    {
        public NormalItem Add(NormalItem item)
        {
            throw new NotImplementedException();
        }

        public List<NormalItem> GetAll()
        {
            throw new NotImplementedException();
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
            return "You are using db repository now";
        }
    }
}
