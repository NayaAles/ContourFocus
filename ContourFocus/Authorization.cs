
namespace ContourFocus
{
    public static class Authorization
    {
        private const string ButtonOtherServices = "#appRoot > div > div._2Yzqy > div._3SkPi > div " +
            "> div.I7x9t > button:nth-child(2) > span > span._2Zz_C";
        private const string ButtonExtern = "#appRoot > div > div._2Yzqy > div._3SkPi > div > div._" +
            "2Sml6 > table > tbody > tr:nth-child(1) > td:nth-child(1) > a > div._2txFW";
        private const string ButtonPassword = "#root > div > div > div.Container__pad_TI7W.Container__large_Z8jS" +
            " > div.Tabs__tabs_MvQQ.Tabs__bigTabs_G2cW > a:nth-child(1) > div > span";
        private const string InputFieldEmail = "#email";
        private const string InputFieldPassword = "#password";
        private const string Button = "#root > div > div > div > span > form > div.TabItem__large_M" +
            "mVf > div:nth-child(2) > span > button > div.react-ui-j884du.react-ui-button-caption";

        public static void Run(Selenium selenium)
        {
            selenium.GoToUrl(SecureData.Get("BaseLink"));
            selenium.ClickButton(ButtonOtherServices, Selenium.Type.CssSelector);
            selenium.ClickButton(ButtonExtern, Selenium.Type.CssSelector);
            selenium.ClickButton(ButtonPassword, Selenium.Type.CssSelector);
            selenium.InputValue(InputFieldEmail, Selenium.Type.CssSelector, SecureData.Get("Email"));
            selenium.InputValue(InputFieldPassword, Selenium.Type.CssSelector, SecureData.Get("Password"));
            selenium.ClickButton(Button, Selenium.Type.CssSelector);
        }
    }
}
