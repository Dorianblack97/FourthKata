using FourthKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestFourthKata
{
    public class Tests
    {
        ICitiesSearcher _sut;
        DBCities _listCities;

        [SetUp]
        public void Setup()
        {
            _sut = new CitiesSearcher();
            _listCities = new DBCities();
        }

        [Test]
        public void TestLess2Char()
        {
            var actual = _sut.SearchCity("L");
            var actual2 = _sut.SearchCity("");
            Assert.IsEmpty(actual);
            Assert.IsEmpty(actual2);
        }
        [Test]
        public void TestMatch()
        {
            var actual = _sut.SearchCity("Rome");
            var expected = new List<string> { "Rome" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultipleResult()
        {
            var actual = _sut.SearchCity("Va");
            var expected = new List<string> { "Valencia", "Vancouver" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSearchInsensitiveCase()
        {
            var actual = _sut.SearchCity("va");
            var expected = new List<string> { "Valencia", "Vancouver" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSearchPartial()
        {
            var actual = _sut.SearchCity("ngk");
            var expected = new List<string> { "Bangkok" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSearchPartialWithSpace()
        {
            var actual = _sut.SearchCity(" York");
            var expected = new List<string> { "New York City" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSearchAsterisk()
        {
            var actual = _sut.SearchCity("*");
            Assert.AreEqual(actual.Count, _listCities.CitiesList.Count);
        }

        [Test]
        public void TestWrongCity()
        {
            var actual = _sut.SearchCity("Trieste");
            Assert.IsEmpty(actual);
        }

    }
}