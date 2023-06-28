using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    
    internal class LibraryMembers
    {
        public string MemberId;
        public string Name;
        public string Address;
        public string PhoneNumber;
        public LibraryMembers(string MemberId, string Name, string Address, string PhoneNumber) 
        {
            this.MemberId = MemberId;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
        internal void memberDetails() // To Display member details 
        {
            Console.WriteLine("-_-_- Member Detais -_-_-");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Id: {MemberId}");
            Console.WriteLine($"Member Name: {Address}");
            Console.WriteLine($"Member Name: {PhoneNumber}");
        }
        internal void bookTrack() // To track the books borrowed by the member.
        {

        }
    }
}
