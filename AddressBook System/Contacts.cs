using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
   public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public int zip { get; set; }
        public int phoneNumber { get; set; }

        public static List<Contact>  contacts = new List<Contact>()
            {
                new Contact() {firstName = "Sushil", lastName = "Shinde", address = "Solapur", city = "Pandharpur",state = "Maharashtra", email = "skshinde2028@gmail.com", zip = 413304, phoneNumber = 789456 },
                new Contact() {firstName = "Sachin", lastName = "sharma", address = "Shivajinagar", city = "Pune",state = "Andhra Pradesh", email = "kgf@gmail.com", zip = 413314, phoneNumber = 56789 },
                new Contact() {firstName = "Virat", lastName = "Kohli", address = "Gandhi", city = "Varanasi",state = "Uttar Pradesh", email = "rrr@hotmail.com", zip = 413325, phoneNumber = 123456 }
            };
        public static void ContactDetails()
        {
            
            foreach(Contact contact in contacts)
            {
                Console.WriteLine("FirstName:{0} LastName: {1}, address: {2}, city: {3}, state: {4}, email: {5}, zip: {6}, phoneNumber{7}\n", contact.firstName, contact.lastName, contact.address, contact.city, contact.state, contact.email, contact.zip, contact.phoneNumber);
            }
        }
       
    }
}
