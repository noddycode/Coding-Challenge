using ClarkCodingChallenge.DataStorage;
using ClarkCodingChallenge.Models;
using System.Collections.Generic;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactsDataAccess : IContactsDataAccess
    {
        private IDataStorage dataStorage;

        public ContactsDataAccess(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        public void AddContact(string email, string lastName, string firstName)
        {
            dataStorage.AddEntry(email, new string[] { lastName, firstName });
        }

        public List<ContactModel> GetContacts()
        {
            IDictionary<string, string[]> entries = dataStorage.GetEntries();
            List<ContactModel> contacts = new List<ContactModel>();

            foreach (KeyValuePair<string, string[]> entry in entries)
            {
                // Do we create a new ContactModel object at this point? Or does that come later down the line?
                //contacts.Add(new ContactModel() { entry.Key, entry.Value[0], entry.Value[1] });
            }

            return contacts;
        }
    }
}
