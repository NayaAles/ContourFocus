
using OpenQA.Selenium;
using System.IO;

namespace ContourFocus
{
    public static class ListInput
    {
        private class ContragentData 
        {
            public string Inn { get; set; } = null!;
        }

        public static void Add(Selenium selenium)
        {
            //  Add csv file with inn to parse
            var points = AutoCliker.AddPoints();
            foreach (var point in points)
            {
                if (String.IsNullOrEmpty(point.InputText))
                    AutoCliker.Click(point);
                else
                    AutoCliker.InputText(point);
            }

            //  Add new inns to list
            selenium.ClickButton(NavigationBar.ButtonShowMore, Selenium.Type.CssSelector);
            selenium.ClickButton(NavigationBar.ButtonSelectList, Selenium.Type.CssSelector);
            selenium.ClickButton(NavigationBar.ButtonCompanyAndIP, Selenium.Type.CssSelector);
            selenium.ClickButton(NavigationBar.ButtonAddToList, Selenium.Type.CssSelector);
            // Load file in xlsx
            selenium.ClickButton(NavigationBar.ButtonUploadInXlsx, Selenium.Type.CssSelector);



        }
    }
}
