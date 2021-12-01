using AdventLibrary;
using NUnit.Framework;


namespace AdventTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Class1 libraryClass = new Class1();

            var result = libraryClass.Result();

            Assert.That(result, Is.EqualTo("AoC"));
        }
    }
}