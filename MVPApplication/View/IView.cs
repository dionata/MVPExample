using System;
using System.Collections.Generic;

namespace MVPApplication.View
{
    /// <summary>
    /// This interface defines what the presenter will need in order to handle the data.
    /// </summary>
    public interface IView
    {
        event EventHandler<StringListEventArgs> MoveToDestinationRequested;
        event EventHandler<StringListEventArgs> MoveToSourceRequested;
        event EventHandler<StringEventArgs> FolderSelected; 
        event EventHandler AllCleared;

        void UpdateSource(Dictionary<string, IEnumerable<string>> data);
        void UpdateDestination(Dictionary<string, IEnumerable<string>> data);
    }
}
