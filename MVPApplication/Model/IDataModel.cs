using System.Collections.Generic;

namespace MVPApplication.Model
{
    /// <summary>
    /// ListViewFormPresenter uses model through this interface.
    /// </summary>
    public interface IDataModel
    {
        Dictionary<string, IEnumerable<string>> SourceFiles { get; set; }
        Dictionary<string, IEnumerable<string>> DestinationFiles { get; set; }
    }
}
