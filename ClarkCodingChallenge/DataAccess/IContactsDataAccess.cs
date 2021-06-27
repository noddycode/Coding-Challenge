using ClarkCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.DataAccess
{
    public interface IContactsDataAccess
    {
        void AddContact(string email, string lastName, string firstName);
        List<ContactModel> GetContacts();
    }
}
