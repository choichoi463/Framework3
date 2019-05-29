using Framework3.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3
{
    public class ContactUs
    {
        [FindsBy(How = How.Name, Using = "your-name")]
        private IWebElement yourName;

        [FindsBy(How = How.Name, Using = "your-email")]
        private IWebElement yourEmail;

        [FindsBy(How = How.Name, Using = "your-subject")]
        private IWebElement yourSubject;

        [FindsBy(How = How.Name, Using = "your-message")]
        private IWebElement yourMessage;

        [FindsBy(How = How.XPath, Using = "//p/input[@type='submit']")]
        private IWebElement submit;        

        [FindsBy(How = How.ClassName, Using = "wpcf7-response-output")]
        private IWebElement SuccMessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='wpcf7-response-output wpcf7-display-none wpcf7-mail-sent-ok']")]
        private IWebElement SuccMessageText;

        [FindsBy(How = How.Id, Using = "menu-item-1296")]
        private IWebElement contactUs;


        public bool isAt()
        {
            return Browsers.Title.Contains("Contact Us");
        }

        public void GoTo()
        {
            contactUs.Click();
        }

        public void SendYourName(string name)
        {
            yourName.SendKeys(name);
        }

        public void SendYourEmail(string email)
        {
            yourEmail.SendKeys(email);
        }

        public void SendYourSubject(string Subject)
        {
            yourSubject.SendKeys(Subject);
        }

        public void SendYourMessage(string massage)
        {
            yourMessage.SendKeys(massage);
        }

        public void ScrollPageToViewSubmit()
        {
            ScrollPage scrollpage = new ScrollPage();
            scrollpage.ScrollToView(submit);
        }

        public void clickSubmit()
        {
            // i think it still clicking another overlaping elent instead of button.
            MoveMouseTo move = new MoveMouseTo();
            move.MoveMouseToElementAndClick(submit);

            // standard sumbit below did not work, because some div was over the submit form page, and was unclickable.
            // submit.Click();
        }

        public void hardClickSubmit()
        {
            JsClick js = new JsClick();
            js.JsHardClickElement(submit);
        }

        public void ValidateMessage()
        {
            try
            {
                var text = SuccMessage.Text;
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        public void ValidateMessageTextIs(string value)
        {
            Assert.IsTrue((SuccMessageText.Text).Equals(value));
        }


    }
}
