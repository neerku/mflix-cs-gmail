using M220N.Repositories;
using MongoDB.Driver;
using NUnit.Framework;

namespace pavantest
{
    public class Tests
    {
        //private MoviesRepository _movieRepository;
        private MongoClient _client;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test1()
        {
            var abc = new MoviesRepository(_client);
            var result = calculator.add(2, 4);
            Assert.AreEqual(6, result);
            Assert.Pass();
        }
    }
}