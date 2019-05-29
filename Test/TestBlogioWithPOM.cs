﻿using Framework3;
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

        [Test]
        public void ContactUsTestflow()
        {
            Browsers.Init();
            Browsers.Goto("https://blog.testproject.io/");

            Pages.contactUs.GoTo();

            Assert.IsTrue(Pages.contactUs.isAt());
            Pages.contactUs.SendYourName("Asya test1");
            Pages.contactUs.SendYourEmail("TestProject@testproject.com");
            Pages.contactUs.SendYourSubject("Test");
            Pages.contactUs.SendYourMessage("Test 123");
            Pages.contactUs.clickSubmit();
            Pages.contactUs.ValidateMessage();
        }

    }

}

