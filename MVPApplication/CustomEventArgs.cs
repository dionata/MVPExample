using System;
using System.Collections.Generic;

namespace MVPApplication
{
    public class ListViewAddEventArgs : EventArgs
    {
        public readonly Dictionary<string, IEnumerable<string>> values; 

        public ListViewAddEventArgs(Dictionary<string, IEnumerable<string>> pDictionary)
        {
            values = pDictionary;
        }
    }

    public class StringListEventArgs : EventArgs
    {
        public readonly IEnumerable<string> values;

        public StringListEventArgs(IEnumerable<string> pList)
        {
            values = pList;
        }
    }

    public class StringEventArgs : EventArgs
    {
        public readonly string value;

        public StringEventArgs(string s)
        {
            value = s;
        }
    }
}
