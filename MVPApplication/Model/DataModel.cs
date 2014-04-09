using System.Collections.Generic;

namespace MVPApplication.Model
{
    public class DataModel : IDataModel
    {
        public Dictionary<string, IEnumerable<string>> SourceFiles { get; set; }
        public Dictionary<string, IEnumerable<string>> DestinationFiles { get; set; }

        public DataModel()
        {
            SourceFiles = new Dictionary<string, IEnumerable<string>>();
            DestinationFiles = new Dictionary<string, IEnumerable<string>>();
        }
    }
}
