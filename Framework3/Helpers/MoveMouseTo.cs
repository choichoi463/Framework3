using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3.Helpers
{
    public class MoveMouseTo
    {
        public void MoveMouseToElementAndClick(IWebElement element)
        {
            Actions act = new Actions(Browsers.getDriver);
            act.MoveToElement(element).Click().Build().Perform();
        }

    }
}
