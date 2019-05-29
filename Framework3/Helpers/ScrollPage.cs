using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3.Helpers
{
    public class ScrollPage
    {

        public void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            var jsscroll = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);

            IJavaScriptExecutor js = (IJavaScriptExecutor)Browsers.getDriver;
            js.ExecuteScript(jsscroll);
        }

        public IWebElement ScrollToView(By selector)
        {
            var element = Browsers.getDriver.FindElement(selector);
            ScrollToView(element);
            return element;
        }

        public void ScrollToView(IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo(0, element.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }
    }
}
