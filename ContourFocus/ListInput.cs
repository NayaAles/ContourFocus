
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
            //string path = @$"{CurrentDirectory.Get()}\Result\test.csv";

            //selenium.GoToUrl(SecureData.Get("LinkListImport"));

            //selenium.ClickButton(NavigationBar.ButtonFromFile, Selenium.Type.CssSelector);
            //selenium.ClickButton(NavigationBar.ButtonSelectFile, Selenium.Type.CssSelector);

            //AutoCliker
            var points = AutoCliker.AddPoints();

            foreach (var point in points)
            {
                if (String.IsNullOrEmpty(point.InputText))
                    AutoCliker.Click(point);
                else
                    AutoCliker.InputText(point);
            }




        }
    }
}
