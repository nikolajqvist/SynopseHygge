using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlternativeStrategy.WIthAbstract;

namespace AlternativeStrategy.TemplatePattern
{
    public class TemplateStrategy
    {
        //public AbstractTemplate Template { get; set; }
        //public TemplateStrategy(AbstractTemplate template)
        //{
        //    Template = template;
        //}

        private readonly AbstractTemplate _template;
        public TemplateStrategy(AbstractTemplate template)
        {
            _template = template;
        }
        public void GetAll()
        {
            _template.GetFlow();
        }
    }
}
