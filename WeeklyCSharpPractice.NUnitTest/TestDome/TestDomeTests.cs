using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyCSharpPractice.Core.TestDome;

namespace WeeklyCSharpPractice.NUnitTest.TestDome
{
    public class TestDomeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstUniqueProductTest()
        {
            Assert.That(Dome.FirstUniqueProduct(new string[] { "Apple", "Computer", "Apple", "Bag" }), Is.EqualTo("Computer"));
        }

        [Test]
        public void CropRatioTest()
        {
            // assign
            var Dome = new Dome();

            Dome.AddCrop("Wheat", 4);
            Dome.AddCrop("Wheat", 5);
            Dome.AddCrop("Rice", 1);

            Assert.That(Dome.CropRatioProportion("Wheat"), Is.EqualTo(0.9d));
            Assert.That(Dome.CropRatioProportion("Rice"), Is.EqualTo(0.1d));
            Assert.That(Dome.CropRatioProportion("Oats"), Is.EqualTo(0.0d));
        }

        [Test]
        public void MalwareAnalysisTest()
        {
            // Assign
            int[] records = new int[] { 1, 2, 0, 5, 0, 2, 4, 3, 3, 3 };
            int[] results = new int[] { 1, 0, 0, 5, 0, 0, 0, 3, 3, 0 };

            Assert.That(Dome.MalwareAnalysis(records), Is.EqualTo(results));
        }

        [Test]
        public void FindCommonNamesTest()
        {
            // assign
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };

            // assert
            Assert.That(Dome.FindCommonNames(names1, names2), Is.EqualTo("Ava, Emma, Olivia, Sophia")); // should print Ava, Emma, Olivia, Sophia
        }

        [Test]
        public void SongTest()
        {
            // assign
            Song first = new Song("Hello");
            Song second = new Song("Roar");
            Song third = new Song("Test");

            // act
            first.NextSong = second;
            second.NextSong = third;
            third.NextSong = first;

            Assert.That(first.IsInRepeatingPlaylist(), Is.EqualTo(true));
        }
    }
}
