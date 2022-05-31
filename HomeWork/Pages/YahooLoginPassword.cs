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

        public bool CkeckPasswordPageAppears()
        {
            var passwordField = FindElement(By.XPath(PasswordFieldLocator));
            var nexButton = FindElement(By.Name(NextButtonLocator));
            return passwordField != null && nexButton != null;
        }

        public bool GetWrongPasswordError()
        {
            GoToMailBoxPage("1111111111");
            var wrongPasswordError = FindElement(By.ClassName("error-msg"));
            return wrongPasswordError != null;
        }

        public void GoToMailBoxPage(string enterPassword)
        {
            PasswordField.Click();
            PasswordField.SendKeys(enterPassword);
            NextButton.Click();
        }

        public void GoToMailBoxOlgaM()
        {
            GoToMailBoxPage("Aa2753331!");
        }
    }
}