using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork.Pages
{
    public class YahooLoginPassword : BasePage
    {
        const string PasswordFieldLocator = "//*[@id='login-passwd']";
        const string NextButtonLocator = "login-signin";

        public IWebElement PasswordField { get; private set; }
        public IWebElement NextButton { get; private set; }


        public YahooLoginPassword(IWebDriver driver) : base(driver)
        {
            PasswordField = FindElement(By.XPath(PasswordFieldLocator));
            NextButton = FindElement(By.Id(NextButtonLocator));
        }

        public void EnterPassword(string enterPassword)
        {
            PasswordField.Click();
            PasswordField.SendKeys(enterPassword);
            NextButton.Click();
        }
    }
}