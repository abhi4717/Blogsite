using NUnit.Framework;

namespace BlogSite.Tests.Controllers
{
    [TestFixture]
    public class Sample
    {
        [Test]
        public void successful_test_case()
        {
            Assert.IsTrue(true);
        }

        [Test]
        [Ignore]
        public void unsuccessful_test_case()
        {
            Assert.IsTrue(false);
        }
    }
}
