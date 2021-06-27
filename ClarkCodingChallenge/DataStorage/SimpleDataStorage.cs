using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClarkCodingChallenge.DataStorage
{
    public class SimpleDataStorage : IDataStorage
    {
        private Dictionary<string, string[]> dataStore = new Dictionary<string, string[]>();

        public void AddEntry(string key, string[] values)
        {
            dataStore.Add(key, values);
        }

        public string[] GetEntry(string key)
        {
            return dataStore[key];
        }

        public IDictionary<string, string[]> GetEntries()
        {
            return new ReadOnlyDictionary<string, string[]>(dataStore);
        }
    }
}
