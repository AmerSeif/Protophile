using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protophile.Models
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}