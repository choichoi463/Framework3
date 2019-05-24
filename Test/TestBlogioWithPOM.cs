using Framework3;
using Framework3.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    class TestBlogioWithPOM
    {
        [SetUp]
        public void startTest()
        {
            Browsers.Init();
            Browsers.Goto("https://blog.testproject.io/");
        }

        [TearDown]
        public void endTest()
        {
            Browsers.Close();
        }

        [Test]
        public void ClickContactUs()
        {
            //Browsers.getDriver.FindElement(By.Id("menu-item-1296")).Click();
            Pages.contactUs.GoTo();

        }

    }

}

