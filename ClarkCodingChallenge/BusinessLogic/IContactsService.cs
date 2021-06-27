using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.BusinessLogic
{
    public interface IContactsService
    {
        void AddContact(string email, string lastName, string firstName);
        List<ContactModel> GetContacts(int order);
        // order: 1 = ascending, -1 = descending, anything else = none
        List<ContactModel> GetContacts(int order, string lastName);

    }
}
