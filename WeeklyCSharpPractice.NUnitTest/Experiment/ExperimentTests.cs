using WeeklyCSharpPractice.Core.Experiments;

namespace WeeklyCSharpPractice.NUnitTest.Experiments
{
    public class ExperimentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EnumTest01()
        {
            // act
            var little = Experiment.GetEnumLabel(ExperimentEnum.LittleChange);
            var big = Experiment.GetEnumLabel(ExperimentEnum.BigChange);

            // assert
            Assert.AreEqual(little, "LittleChange");
            Assert.AreEqual(big, "BigChange");
        }
    }
}
