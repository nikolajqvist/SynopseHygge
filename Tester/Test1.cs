using System.Diagnostics;
using AlternativeStrategy;
using ProductOfSynopsis.Interfaces;
using ProductOfSynopsis.Modelclass;
using ProductOfSynopsis.Repositories;
using ProductOfSynopsis.Strategies;

namespace Tester
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepository<Person> repository = new Repository<Person>(new MemoryStrategy<Person>());

            Person p1 = new Person(1, "Mogens");
            Person p2 = new(2, "Kaj");
            repository.Add(p1);
            repository.Add(p2);

            List<Person> list = repository.GetAll();

            int actual = list.Count;
            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            IRRepository<PPerson> repo = new Reporepo<PPerson>(new MemoryStrat<PPerson>());

            repo.Add(new PPerson(1, "ss"));
            repo.Add(new PPerson(3, "vv"));

            Assert.AreEqual(repo.GetAll().Count, 2);
        }
    }
}
