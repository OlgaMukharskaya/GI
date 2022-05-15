using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace HomeWork.Pages
{
    public class YahooHome : BasePage
    {
        const string SignInButtonLocator = "_yb_oqe7g";

        public IWebElement SignInButton { get; set; }


        public YahooHome(IWebDriver driver) : base(driver)
        {
            SignInButton = FindElement(By.ClassName(SignInButtonLocator));

            SignInButton.Click();
        }
    }
}
