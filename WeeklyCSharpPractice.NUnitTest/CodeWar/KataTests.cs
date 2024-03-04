using WeeklyCSharpPractice.Core.CodeWar.Kata;

namespace WeeklyCSharpPractice.NUnitTest.CodeWar
{
    public class KataTests
    {
        [SetUp]
        public void Setup()
        {
            var Kata = new Kata();
        }

        [Test]
        public void ArrayDiffTest()
        {
            

            Assert.AreEqual(new int[] { 2 }, Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));

            var x = Kata.ArrayDiff(new int[] { 0, -1, 17, 6, 6, 7, 10, 0, -7 }, new int[] { 0, -1 });
            Assert.AreEqual(new int[] { 17, 6, 6, 7, 10, -7 }, Kata.ArrayDiff(new int[] { 0, -1, 17, 6, 6, 7, 10, 0, -7 }, new int[] { 0, -1 }));
        }

        [Test]
        public void SquareDigitsTest()
        {

            Assert.AreEqual(811181, Kata.SquareDigits(9119));
            Assert.AreEqual(0, Kata.SquareDigits(0));
        }

        [Test]
        public void DuplicateCountTests()
        {
            Assert.AreEqual(0, Kata.DuplicateCount(""));
            Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }

        [Test]
        public static void FindOddOrEvenTest01()
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Assert.IsTrue(3 == Kata.FindOddOrEven(exampleTest1));
        }

        [Test]
        public static void FindOddOrEvenTest02()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.IsTrue(206847684 == Kata.FindOddOrEven(exampleTest2));
        }

        [Test]
        public static void FindOddOrEvenTest03()
        {
            int[] exampleTest3 = { int.MaxValue, 0, 1 };
            Assert.IsTrue(0 == Kata.FindOddOrEven(exampleTest3));
        }

        [Test]
        public void MoveZerosTest()
        {
            Assert.AreEqual(new int[] { 1, -2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new int[] { 1, -2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}