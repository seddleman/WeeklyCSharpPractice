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
        public void EnumTest()
        {
            // act
            var little = Experiment.GetEnumLabel(ExperimentEnum.LittleChange);
            var big = Experiment.GetEnumLabel(ExperimentEnum.BigChange);

            // assert
            Assert.AreEqual(little, "LittleChange");
            Assert.AreEqual(big, "BigChange");
        }

        [Test]
        public void NestedStringReplacement()
        {
            // act
            var positive = Experiment.NestedStringReplace(7);
            var negative = Experiment.NestedStringReplace(-7);

            // assert
            Assert.That(positive, Is.EqualTo("GMT+7:00"));
            Assert.That(negative, Is.EqualTo("GMT-7:00"));
            Assert.That(Experiment.NestedStringReplace(-11), Is.EqualTo("GMT-11:00"));
            Assert.That(Experiment.NestedStringReplace(10), Is.EqualTo("GMT+10:00"));
            Assert.That(Experiment.NestedStringReplace(-5), Is.EqualTo("GMT-5:00"));
            Assert.That(Experiment.NestedStringReplace(0), Is.EqualTo("GMT+0:00"));
        }

        [Test]
        public void DatesAndStringsTest()
        {
            // act
            var now = DateTime.Now;
            var strNow = Experiment.DatesAndStrings(now);

            var xmas = new DateTime(2000, 12, 25, 0, 0, 0, 0);

            // assert
            Assert.That(Experiment.DatesAndStrings(new DateTime(1979, 5, 28, 23, 59, 59)), Is.EqualTo("05/28/1979 11:59:59.000 PM"));
            Assert.That(strNow, Is.EqualTo(now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));
            Assert.That(Experiment.DatesAndStrings(xmas), Is.EqualTo(xmas.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));
            Assert.That(Experiment.DatesAndStrings(new DateTime(2024, 3, 11, 8, 15, 1, 50)), Is.EqualTo("03/11/2024 08:15:01.050 AM"));
            Assert.That(Experiment.DatesAndStrings(new DateTime(1966, 5, 17)), Is.EqualTo("05/17/1966 12:00:00.000 AM"));
            Assert.That(Experiment.DatesAndStrings24Hour(new DateTime(1979, 5, 28, 23, 59, 59)), Is.EqualTo("05/28/1979 23:59:59.000"));
            Assert.That(Experiment.DatesAndStrings24HourYearFirst(new DateTime(1979, 5, 28, 23, 59, 59)), Is.EqualTo("1979-05-28 23:59:59.000"));
        }
    }
}
