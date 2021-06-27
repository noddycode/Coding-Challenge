using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.BusinessLogic
{
    interface IContactsService
    {
        void AddContact(string email, string lastName, string firstName);
        void GetContacts(bool ascending);
        void GetContacts(bool ascending, string lastName);

    }
}
