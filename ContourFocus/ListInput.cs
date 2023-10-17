
namespace ContourFocus
{
    public class ListInput
    {
        private string Path = @$"{CurrentDirectory.Get()}/Result/test.csv";
        private class ContragentData 
        {
            public string Inn { get; set; } = null!;
        }

        public void Add()
        {
            var dataToLoad = ReaderWriterCsv.ReadFromCsv<ContragentData>(Path, ';');

        }
    }
}
