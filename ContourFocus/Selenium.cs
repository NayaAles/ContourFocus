using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ContourFocus
{
    public class Selenium
    {
        public enum Type
        {
            CssSelector,
            XPath
        }

        private static ChromeDriver Driver = new ChromeDriver();
        private static WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public void GoToUrl(string Url)
        {
            Driver.Url = Url;
            Driver.Manage().Window.Maximize();
        }

        public void ClickButton(string pathElement, Type type)
        {
            switch (type)
            { 
                case Type.CssSelector:
                    Wait.Until(d => Driver.FindElement(By.CssSelector(pathElement)) != null);
                    Driver.FindElement(By.CssSelector(pathElement))
                        .Click();
                    return;

                case Type.XPath:
                    Wait.Until(d => Driver.FindElement(By.XPath(pathElement)) != null);
                    Driver.FindElement(By.XPath(pathElement))
                        .Click();
                    return;
            }
        }

        public void InputValue(string pathElement, Type type, string value)
        {
            switch (type)
            {
                case Type.CssSelector:
                    Wait.Until(d => Driver.FindElement(By.CssSelector(pathElement)) != null);
                    Driver.FindElement(By.CssSelector(pathElement))
                        .SendKeys(value);
                    return;

                case Type.XPath:
                    Wait.Until(d => Driver.FindElement(By.XPath(pathElement)) != null);
                    Driver.FindElement(By.XPath(pathElement))
                        .SendKeys(value);
                    return;
            }
        }
    }
}
