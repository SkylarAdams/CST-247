using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity4.Models
{
    public class UserModel
    {

        public string Name { set; get; }
        public string EmailAddress { set; get; }
        public string PhoneNumber { set; get; }

        public UserModel(string Name, string Email, string Phone)
        {
            this.Name = Name;
            this.EmailAddress = Email;
            this.PhoneNumber = Phone;
        }
    }
}