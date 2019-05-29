using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3.Helpers
{
    public class JsClick
    {
        public void JsHardClickElement(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Browsers.getDriver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

    }
}
