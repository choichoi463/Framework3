using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3
{
    class CustomMethods
    {
        public void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                Console.Write("Id");
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementtype == "Name")
            {
                Console.Write("Name");
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }
    }
}
