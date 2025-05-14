using NUnit.Framework;
using System.Threading;
using WatiN.Core;

namespace WatiNTests {
    [TestFixture]
    [Apartment(ApartmentState.STA)]
    public class Tests {
        private IE browser;

        [SetUp]
        public void Setup() {
            browser = new IE();
        }

        [TearDown]
        public void Cleanup() {
            browser.Close();
        }

        [Test]
        public void WejscieNaStrone() {
            browser.GoTo("https://www.google.com/");
            Assert.AreEqual("Google", browser.Title);
        }
    }
}
