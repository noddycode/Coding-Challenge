using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.DataAccess
{
    interface IContactsDataAccess
    {
        void AddContact(string email, string lastName, string firstName);
        List<Contact> GetContacts();
    }
}
