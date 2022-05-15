using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork
{

    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebElement FindElement(By locator)
        {
            IWebElement element = null;
            int attemptsNumber = 0;
            while (attemptsNumber < 10)
            {
                try
                {
                    element = _driver.FindElement(locator);
                }
                catch (Exception exception)
                {
                    Thread.Sleep(3000); // Waiter
                    return _driver.FindElement(locator);
                    Console.WriteLine("Can't find element, I will try again!");
                    Console.WriteLine(exception.Message);
                }
                if (element != null)
                {
                    break;
                }
                attemptsNumber++;
            }
            return element;

        }

    }
}
