
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
            string path = @$"{CurrentDirectory.Get()}\Result\test.csv";
            //var dataToLoad = ReaderWriterCsv.ReadFromCsv<ContragentData>(path, ';');

            string data = "";
            using (var reader = new StreamReader(path))
            {
                data = reader.ReadToEnd();
            }
            
            selenium.GoToUrl(SecureData.Get("LinkListImport"));

            selenium.InputValue(NavigationBar.InputFieldFromText, Selenium.Type.CssSelector, data);

        }
    }
}
