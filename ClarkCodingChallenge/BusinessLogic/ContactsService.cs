using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Models;
using System;
using System.Collections.Generic;

namespace ClarkCodingChallenge.BusinessLogic
{
    public class ContactsService : IContactsService
    {

        private IContactsDataAccess dataAccess;

        public ContactsService(IContactsDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        private static int SortContacts(ContactModel x, ContactModel y)
        {
            return 0;
        }
        public void AddContact(string email, string lastName, string firstName)
        {
            // Do we need validation here, or do we trust the model to do all of it?
            // Does that depend on what we expect to be able to access this method?
            foreach (string field in new string[] { email, lastName, firstName })
                if (string.IsNullOrEmpty(field))
                    throw new ArgumentException("Cannot add contact with empty fields");

            dataAccess.AddContact(email, lastName, firstName);
        }

        public List<ContactModel> GetContacts(int order)
        {
            List<ContactModel> contacts = dataAccess.GetContacts();

            if (order == 1);
            else if(order == -1);
            
            return contacts;

        }

        public List<ContactModel> GetContacts(int order, string lastName)
        {
            List<ContactModel> contacts = GetContacts(order);
            List<ContactModel> ret_contacts = new List<ContactModel>();

            foreach (ContactModel contact in contacts)
            {
                if (contact.LastName.ToLower() == lastName.ToLower())
                    ret_contacts.Add(contact);
            }

            return ret_contacts;
        }
    }
}
