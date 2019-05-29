using Framework3.PageObjects;
using Framework3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestBlogioExtended
    {
        [Test]
        public void ContactUsTestflow()
        {
            Browsers.Init();
            Browsers.Goto("https://blog.testproject.io/");

            Pages.contactUs.GoTo();

            Assert.IsTrue(Pages.contactUs.isAt());
            Pages.contactUs.SendYourName("Asya test2");
            Pages.contactUs.SendYourEmail("TestProject@testproject.com");
            Pages.contactUs.SendYourSubject("Test");
            Pages.contactUs.SendYourMessage("Test 123");
            Pages.contactUs.ScrollPageToViewSubmit(); // not necessary here, just for the show.
            Pages.contactUs.clickSubmit();
            Pages.contactUs.hardClickSubmit();
            Pages.contactUs.ValidateMessage();
            Pages.contactUs.ValidateMessageTextIs("Thank you for your message. It has been sent.");


        }
    }
}
