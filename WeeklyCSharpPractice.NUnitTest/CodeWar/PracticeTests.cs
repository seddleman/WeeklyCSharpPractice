using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyCSharpPractice.Core.CodeWar.Practice;

namespace WeeklyCSharpPractice.NUnitTest.CodeWar
{
    internal class PractiveTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RocksTest()
        {

            // act
            var results = Practice.RockLabelTotalCost(13);
            var results2 = Practice.RockLabelTotalCost(36123011);

            // assert
            Assert.AreEqual(results, 17);
            Assert.AreEqual(results2, 277872985);
        }
    }
}

