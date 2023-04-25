using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class AddNewContact
    {
        public void AddNewContactToAddressBook()
        {
            Contact newContact = new Contact();
            Console.WriteLine("Enter the first name");
            newContact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            newContact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the address");
            newContact.address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            newContact.city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            newContact.state = Console.ReadLine();
            Console.WriteLine("Enter the email address");
            newContact.email = Console.ReadLine();
            Console.WriteLine("Enter the zip code");
            newContact.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the phone number");
            newContact.phoneNumber = Convert.ToInt32(Console.ReadLine());
            Contact.contacts.Add(newContact);

            Console.WriteLine("Contact details with added contact");
            Console.ReadLine();
            foreach (Contact contact in Contact.contacts)
            {
                Console.WriteLine("FirstName:{0} LastName: {1}, address: {2}, city: {3}, state: {4}, email: {5}, zip: {6}, phoneNumber{7}\n", contact.firstName, contact.lastName, contact.address, contact.city, contact.state, contact.email, contact.zip, contact.phoneNumber);
            }
            Console.ReadLine();
        }
    }
}
