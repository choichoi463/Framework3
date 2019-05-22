using OpenQA.Selenium;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Framework3
{
    public class Browsers
    {
        private static IWebDriver webDriver;

        private static string baseUrl = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];

        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;

            }

        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static IWebDriver getDriver
        {
            get
            {
                return webDriver;
            }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;

        }

        public static void Close()
        {
            webDriver.Close();
        }
        

    }
}
