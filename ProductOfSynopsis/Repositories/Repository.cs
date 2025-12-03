using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using ProductOfSynopsis.Interfaces;

namespace ProductOfSynopsis.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Har to repositories der har samme metoder, 
        //havde jeg ikke det så havde jeg haft en problem
        //med at jeg skulle sikre mig at det ikke var
        //repositoriet jeg arbejdede med hver gang jeg skiftede strategy.
        private readonly IStrategy<T> _strategy;
        public Repository(IStrategy<T> strategy)
        {
            _strategy = strategy;
        }

        public T Add(T entity)
        {
            return _strategy.Add(entity);
        }

        public T DeleteById(int id)
        {
            return _strategy.DeleteById(id);
        }

        public List<T> GetAll()
        {
            return _strategy.GetAll();
        }

        public T GetById(int id)
        {
            return _strategy.GetById(id);
        }

        public T Update(T entity)
        {
            return _strategy.Update(entity);
        }
    }
}
