using System.Diagnostics;
using AlternativeStrategy;
using AlternativeStrategy.TemplatePattern;
using AlternativeStrategy.WIthAbstract;
using AntiStrategySOLID;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using ProductOfSynopsis.Interfaces;
using ProductOfSynopsis.Modelclass;
using ProductOfSynopsis.Repositories;
using ProductOfSynopsis.Strategies;
using Repository_StrategyPatternTogether;

namespace Tester
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var discountStrategy = new UseOfStrategy(new BlackFridayDiscount());

            double actual = discountStrategy.DiscountStrategy(10d);
            
            double expected = 5d;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var repositoy = new StratUser(new DBRepositorystrat());
            var repository2 = new StratUser(new DBRepositorystrat());
            string expected = repositoy.UseOfStrat(); 
            string actual = repository2.UseOfStrat();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var reposito = new Strategy(new NormalRepository());

            PPerson pp = new PPerson(1, "Nora");
            PPerson pp2 = new PPerson(2, "Frank");

            reposito.Add(pp);
            reposito.Add(pp2);

            int expectedcount = 2;
            int actualcount = reposito.GetAll().Count();

            Assert.AreEqual(expectedcount, actualcount);
        }
        [TestMethod]
        public void TestMethod4()
        {
            AbstractTemplate repo = new Strategy(new MemoryRepo());
        }
    }
}
