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
        { //_driver = driver;
            UsernameField = FindElement(By.Id(UsernameFieldLocator));
            NextButton = FindElement(By.Name(NextButtonLocator));
        }

        public bool CkeckUsernamePageAppears()
        {
            var usernameField = FindElement(By.Id(UsernameFieldLocator));
            var nexButton = FindElement(By.Name(NextButtonLocator));
            return usernameField != null && nexButton != null; // sernameField?.Count == 1 && nexButton != null
        }

        public bool GetWrongNameError()
        {
            GoToPasswordPage("WrongUsername");
            var wrongNameError = FindElement(By.XPath("//p[@id='username-error']"));
            return wrongNameError != null;
        }

        public void GoToPasswordPage(string enterUsername)
        {
            UsernameField.Click();
            UsernameField.SendKeys(enterUsername);
            NextButton.Click();
        }

        public void GotoPasswordOlgaM()
        {
            GoToPasswordPage("olgamautomation");
        }
    }
}