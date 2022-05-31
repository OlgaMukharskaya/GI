using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork.Pages
{
    public class YahooStart : BasePage
    {
        const string EnterButtonLocator = "//*[@id='signin-main']/div[1]/a";

        public IWebElement EnterButton { get; private set; }


        public YahooStart(IWebDriver driver) : base(driver)
        {
            EnterButton = FindElement(By.XPath(EnterButtonLocator));
            EnterButton.Click();
        }   
    }
}
