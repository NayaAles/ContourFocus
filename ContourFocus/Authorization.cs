
namespace ContourFocus
{
    public static class Authorization
    {
        private const string ButtonPassword = "#root > div > div > div.Container__pad_TI7W.Containe" +
            "r__large_Z8jS > div.Tabs__tabs_MvQQ > a:nth-child(1) > div";
        private const string InputFieldEmail = "#email";
        private const string InputFieldPassword = "#password";
        private const string Button = "#root > div > div > div > span > form > div.TabItem__large_M" +
            "mVf > div:nth-child(2) > span > button > div.react-ui-j884du.react-ui-button-caption";

        public static void Run(Selenium selenium)
        {
            selenium.ClickButton(ButtonPassword, Selenium.Type.CssSelector);
            selenium.InputValue(InputFieldEmail, Selenium.Type.CssSelector, SecureData.Get("Email"));
            selenium.InputValue(InputFieldPassword, Selenium.Type.CssSelector, SecureData.Get("Password"));
            selenium.ClickButton(Button, Selenium.Type.CssSelector);
        }
    }
}
