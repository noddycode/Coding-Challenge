using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.DataAccess
{
    

    public readonly struct Contact
    {
        public string Email { get;}
        public string LastName { get; }
        public string FirstName { get; }

        public Contact(string email, string lastName, string firstName)
        {
            Email = email;
            LastName = lastName;
            FirstName = firstName;
        }

    }
}
