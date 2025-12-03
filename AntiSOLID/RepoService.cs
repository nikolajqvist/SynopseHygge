using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiRepositorySOLID
{
    public class RepoService
    {
        private Repository repository = new Repository();

        public List<Person> ServiceGetAll()
        {
            return repository.GetAll();
        }
    }
}
