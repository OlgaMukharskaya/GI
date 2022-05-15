using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading.Tasks;

namespace HomeWork.Pages
{
    class ExitAccount : BasePage
    {
        const string ExitMenuLocator = "//label[@class='icon-vertical-ellipsis svg-bg']";
        const string ExitButtonLocator = "//button[@class='card-menu-button']";

        public IWebElement ExitMenu { get; private set; }
        public IWebElement ExitButton { get; private set; }


        public ExitAccount(IWebDriver driver) : base(driver)
        {
            ExitMenu = FindElement(By.XPath(ExitMenuLocator));
            ExitMenu.Click();

            ExitButton = FindElement(By.XPath(ExitButtonLocator));
            ExitButton.Click();
        }

    }
}
