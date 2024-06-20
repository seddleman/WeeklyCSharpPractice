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

            Assert.That(big, Is.EqualTo("BigChange"));
            Assert.That(little, Is.EqualTo("LittleChange"));
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

        [Test]
        public void PassByRef_OrNot()
        {
            // act
            var list = new List<MyObject>
            {
                new MyObject {Name = "a", Number = 1, IsHidden = false, Value = 1.0m, UpdatedValue = 0.0m},
                new MyObject {Name = "b", Number = 2, IsHidden = false, Value = 2.0m, UpdatedValue = 0.0m},
                new MyObject {Name = "c", Number = 3, IsHidden = false, Value = 3.0m, UpdatedValue = 0.0m},
            };

            var thing1 = list.First();
            var thing3 = list.Last();

            var test1 = Experiment.ReferencePassChange(thing1, 10.5m);
            var test2 = Experiment.ReferencePassChange(list[1], 18.0m);
            var test3 = Experiment.ReferencePassChange(thing3, 4.5m);

            var addTest = Experiment.ReferencePassAdd(thing3, 4.5m);


            //     var strNow = Experiment.DatesAndStrings(now);

            //     var xmas = new DateTime(2000, 12, 25, 0, 0, 0, 0);

            // assert
            Assert.That(list[0].UpdatedValue, Is.EqualTo(10.5m));
            Assert.That(list[1].UpdatedValue, Is.EqualTo(18.0m));
            Assert.That(list[2].UpdatedValue, Is.EqualTo(7.5m));
            Assert.That(list[2].IsHidden, Is.EqualTo(true));
            Assert.That(addTest, Is.EqualTo(3.0m));
            //Assert.That(Experiment.DatesAndStrings(xmas), Is.EqualTo(xmas.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));
            //Assert.That(Experiment.DatesAndStrings(new DateTime(2024, 3, 11, 8, 15, 1, 50)), Is.EqualTo("03/11/2024 08:15:01.050 AM"));
            //Assert.That(Experiment.DatesAndStrings(new DateTime(1966, 5, 17)), Is.EqualTo("05/17/1966 12:00:00.000 AM"));
            //Assert.That(Experiment.DatesAndStrings24Hour(new DateTime(1979, 5, 28, 23, 59, 59)), Is.EqualTo("05/28/1979 23:59:59.000"));
            //Assert.That(Experiment.DatesAndStrings24HourYearFirst(new DateTime(1979, 5, 28, 23, 59, 59)), Is.EqualTo("1979-05-28 23:59:59.000"));
        }
    }
}
