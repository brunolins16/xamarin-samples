using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin.CodeSharing.Tests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            app.Tap( ap => ap.Marked("myButton").Button());

            app.Screenshot("First click.");
            var text = app.Query(ap => ap.Marked("myButton").Button()).FirstOrDefault().Text;
            Assert.AreEqual(text, "1 clicks!");

            app.Screenshot("Second click.");
            text = app.Query(ap => ap.Marked("myButton").Button()).FirstOrDefault().Text;
            Assert.AreEqual(text, "2 clicks!");
        }
    }
}

