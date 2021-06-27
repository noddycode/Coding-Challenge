using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.DataStorage
{
    interface IDataStorage
    {
        void AddEntry(string key, string[] values);
        string[] GetEntry(string key);
        IDictionary<string, string[]> GetEntries();
    }
}
