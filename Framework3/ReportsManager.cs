using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3
{
    public class ReportsManager
    {
        Reports report;
        string browser;
        string url;
        IWebDriver driver = Browsers.getDriver;

        public ReportsManager(string browser, string url)
        {
            this.browser = browser;
            this.url = url;
            report = new Reports(browser, url);
        }

        public void verifyUrl(string url)
        {
            string PageUrl = driver.Url;
            string message = "The current url & expected are not equal";

            if (PageUrl.Equals(url))
                report.addLine("Verify url", "Pass", "URL are equal.");
            else
                report.addLine("Verify url", "Fail", message);

            Assert.AreEqual(PageUrl, url, message);

        }
        
        public void verifyElementNotAppear(IWebElement element)
        {
            string message = "Element does not exist.";
            Assert.Fail(message);
            addLog("Looking for Element " + element + " ", "Fail", element + " Should be on the page");
        }

        private void addLog(string description, string result, string exception)
        {
            report.addLine(description, result, exception);
        }

    }
}
