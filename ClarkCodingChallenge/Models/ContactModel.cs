using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please enter an email")]

        // TODO: Add email formatting validation
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }
    }
}
