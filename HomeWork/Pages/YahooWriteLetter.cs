using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork.Pages
{
    public class YahooWriteLetter : BasePage
    {
        const string AddresseeFieldLocator = "//*[@id='message-to-field']";
        const string TopicFieldLocator = "//*[@id='mail-app-component']/div/div/div/div[1]/div[3]/div/div/input";
        const string ContentFieldLocator = "//*[@id='editor-container']/div[1]/div";
        const string SendButtonLocator = "//*[@id='mail-app-component']/div/div/div/div[2]/div[2]/div/button";

        public IWebElement AddresseeField { get; private set; }
        public IWebElement TopicField { get; private set; }
        public IWebElement ContentField { get; private set; }
        public IWebElement SentdButton { get; private set; }

        public YahooWriteLetter(IWebDriver driver) : base(driver)
        {
            AddresseeField = FindElement(By.XPath(AddresseeFieldLocator));
            TopicField = FindElement(By.XPath(TopicFieldLocator));
            ContentField = FindElement(By.XPath(ContentFieldLocator));
            SentdButton = FindElement(By.XPath(SendButtonLocator));
        }

        public void WriteLetter(string enterAddressee, string enterTopic, string enterContent)
        {
            AddresseeField.Click();
            AddresseeField.SendKeys(enterAddressee);
            TopicField.Click();
            TopicField.SendKeys(enterTopic);
            ContentField.Click();
            ContentField.SendKeys(enterContent);
            SentdButton.Click();
        }

        public bool WriteletterPageAppears()
        {
            var addresseeField = FindElement(By.XPath(AddresseeFieldLocator));
            var topicField = FindElement(By.XPath(TopicFieldLocator));
            var contentField = FindElement(By.XPath(ContentFieldLocator));
            var sentdButton = FindElement(By.XPath(SendButtonLocator));
            return addresseeField != null && topicField!= null && contentField != null && sentdButton!= null;
        }

        public void WriteLetterFromVolhaToOlga()
        {
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            WriteLetter("olgamautomation@yahoo.com", currentTime, "Aturomation Test from VolhaM");
        }
    }
}
