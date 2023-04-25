using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adress Book System problem\n");
            Console.WriteLine("Existing contact details are:\n");
            Contact.ContactDetails();
            Console.WriteLine("Choose from the below options\n ");
            Console.WriteLine(" 1. Add new contact in address book\n 2. Update the contact details\n 3. Delete existing contact details");
            int option = Convert.ToInt32(Console.ReadLine());
           
            switch (option)
            {
                case 1:
                    AddNewContact contact = new AddNewContact();
                    contact.AddNewContactToAddressBook();
                    break;
                case 2:
                    //List<Contact> list = new List<Contact>();
                    UpdateContact.UpdateContactDetails(Contact.contacts);
                    break;
                case 3:
                    DeleteContact.DeleteExistingContact(Contact.contacts);
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}
