using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_StrategyPatternTogether
{
    public class NormalItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public NormalItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
