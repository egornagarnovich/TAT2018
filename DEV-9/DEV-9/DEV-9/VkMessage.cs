using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV9
{
    /// <summary>
    /// Vk message.
    /// The class contains all methods for getting an unread messages in VKontakte.
    /// </summary>
    public class VkMessage
    {
        /// <summary>
        /// Gets the unread message in VK.
        /// </summary>
        /// <returns>The unread message.</returns>
        /// <param name="logging">Logging for VK .</param>
        /// <param name="password">Password for Vk.</param>
        public string GetUnreadMessage(ref string logging, ref string password)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://vk.com/");
            IWebElement searchLogging = driver.FindElement(By.XPath("//*[@id=\"index_email\"]"));
            searchLogging.SendKeys(logging);

            IWebElement searchPassword = driver.FindElement(By.XPath("//*[@id=\"index_pass\"]"));
            searchPassword.SendKeys(password);

            IWebElement searchEnter = driver.FindElement(By.XPath("//*[@id=\"index_login_button\"]"));
            searchEnter.SendKeys(Keys.Enter);

            IWebElement searchMessage = driver.FindElement(By.XPath("//*[@id=\"l_msg\"]"));
            searchMessage.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement searcUnreadMessage = driver.FindElement(By.XPath("//*[@id=\"ui_rmenu_unread\"]/span/span"));
            return searcUnreadMessage.Text;
        }
    }
}