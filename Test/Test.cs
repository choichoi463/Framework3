﻿using Framework3;
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
    class Test
    {

        [SetUp]
        public void startTest()
        {
            Browsers.Init();
            Browsers.Goto("https://www.hearandplay.com/main/piano-chords-complete-guide");
        }

        [TearDown]
        public void endTest()
        {
            Browsers.Close();
        }

        [Test]
        public void zenTest()
        {
            Assert.IsTrue(Browsers.getDriver.Title.Contains("Piano"));
        }
    }
}
