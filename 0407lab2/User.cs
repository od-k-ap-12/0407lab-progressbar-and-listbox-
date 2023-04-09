using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0407lab2
{
    [Serializable]
    internal class User
    {
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public string Email { get;set; }
        public string PhoneNumber { get;set; }
        public int Code { get; set; }
        public static int Counter = 0;
        public User(){}
        public User(string FirstName, string LastName, string Email, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Code=Counter;
            Counter++;
        }
        public override string ToString()
        {
            return Code+" "+FirstName+" "+LastName+" "+Email+" "+PhoneNumber;
        }
    }
}
