using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeStrategy
{
    public class PPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PPerson(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
