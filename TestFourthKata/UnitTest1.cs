using FourthKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestFourthKata
{
    public class Tests
    {
        ISearchCity _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SearchCities();
        }

        [Test]
        public void TestLess2Char()
        {
            var actual = _sut.SearchCity("L");
            Assert.IsEmpty(actual);
        }

        [Test]
        public void TestSearch()
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
        public void TestSearchAsterisk()
        {
            var actual = _sut.SearchCity("*");
            Assert.AreEqual(actual.Count, 16);
        }

    }
}