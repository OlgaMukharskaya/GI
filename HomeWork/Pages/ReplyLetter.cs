using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pages
{
    public class ReplyLetter : BasePage
    {
        const string ReplyButtonLocator = "/html/body/div[1]/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div[2]/div[2]/div/div/ul/span/li[1]/button";
        const string ReplyMessageFieldLocator = "/html/body/div[1]/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div[2]/div[2]/ul/li[2]/div/div/div[2]/div[1]/div/div[2]/div/div[1]/div/div[2]";
        const string SendBackButtonLocator = "//button[@title='Отправить это сообщение']";

        public IWebElement ReplyButton { get; private set; }
        public IWebElement ReplyMessageField { get; private set; }
        public IWebElement ContentField { get; private set; }
        public IWebElement SandBackButton { get; private set; }

        public ReplyLetter(IWebDriver driver) : base(driver)
        {
            ReplyButton = FindElement(By.XPath(ReplyButtonLocator));
            ReplyMessageField = FindElement(By.XPath(ReplyMessageFieldLocator));
            SandBackButton = FindElement(By.XPath(SendBackButtonLocator));
        }

        public void Answer(string enterText)
        {
            ReplyButton.Click();
            ReplyMessageField.Click();
            ReplyMessageField.SendKeys(enterText);
            SandBackButton.Click();
        }
    }
}
