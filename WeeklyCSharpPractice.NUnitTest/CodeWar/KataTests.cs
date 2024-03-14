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

        [Test]
        public static void SpinWordsTest()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
        
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
       
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }

        [Test]
        public void FindTheOddIntTests()
        {
            Assert.AreEqual(5, Kata.FindTheOddInt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        private static void Tester(Dictionary<char, int> expected, Dictionary<char, int> submitted, string input)
        {
            foreach (KeyValuePair<char, int> entry in expected)
            {
                char key = entry.Key;
                if (submitted.ContainsKey(key))
                {
                    int val = entry.Value;
                    int num = submitted[key];
                    if (num != val)
                    {
                        Assert.AreEqual(val, num, $"For input string: \"{input}\"\n \n< Incorrect Value for Key '{key}' >");
                    }
                }
                else
                {
                    Assert.AreEqual(true, false, $"For input string: \"{input}\"\n \n< The submitted Dictionary should contain an entry for key '{entry.Key}' >");
                }
            }
            foreach (KeyValuePair<char, int> entry in submitted)
            {
                if (expected.ContainsKey(entry.Key) == false)
                {
                    Assert.AreEqual(false, true, $"For input string: \"{input}\"\n \n< The submitted Dictionary should NOT contain an entry for key '{entry.Key}' >");
                }
            }
            Assert.AreEqual(true, true);
        }

        [Test]
        public static void SampleTest_a()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 1);
            string s = "a";
            Tester(d, Kata.DictCountCharInString(s), s);
        }

        [Test]
        public static void SampleTest_aba()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 1);
            string s = "aba";
            Tester(d, Kata.DictCountCharInString(s), s);
        }

        [Test]
        public void MorseCodeDecoderBasicTest1()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = Kata.MorseCodeDecoder(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}