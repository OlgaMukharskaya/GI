using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork.Pages
{
    public class YahooLoginUsername : BasePage
    {
        const string UsernameFieldLocator = "login-username";
        const string NextButtonLocator = "signin";

        public IWebElement UsernameField { get; private set; }
        public IWebElement NextButton { get; private set; }


        public YahooLoginUsername(IWebDriver driver) : base(driver)
        {
            UsernameField = FindElement(By.Id(UsernameFieldLocator));
            NextButton = FindElement(By.Name(NextButtonLocator));
        }

        public void EnterUsername(string enterUsername)
        {
            UsernameField.Click();
            UsernameField.SendKeys(enterUsername);
            NextButton.Click();
        }
    }
}