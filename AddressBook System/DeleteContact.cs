using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class DeleteContact
    {
        public static void DeleteExistingContact(List<Contact> list)
        {
            Contact obj = new Contact();
            Console.WriteLine("Enter the first name of person to delete the contact\n");
            string name = Console.ReadLine();
            bool isExisting = false;

            foreach (Contact contact in list)
            {
                if(contact.firstName == name)
                {
                    isExisting = true;
                    Console.WriteLine("Contact details are available as below so deleting it\n");
                    Console.WriteLine($"First name:{contact.firstName}, Last name:{contact.lastName}, address ={contact.address}, city = {contact.city},state = {contact.state}, email ={contact.email}, zip = {contact.zip}, phoneNumber = {contact.phoneNumber}\n ");
                    list.Remove(contact);
                    Console.WriteLine(".....After deleting.....\n");
                    break;
                }
               
            }
            if(!isExisting)
            {
                Console.WriteLine("Contact does not exist");
            }
            foreach(Contact contact in list)
            {
                Console.WriteLine("Present contacts from the address book...\n");
                Console.WriteLine($"First name:{contact.firstName}, Last name:{contact.lastName}, address ={contact.address}, city = {contact.city},state = {contact.state}, email ={contact.email}, zip = {contact.zip}, phoneNumber = {contact.phoneNumber}\n ");
            }
            Console.ReadLine();
        }
    }
}
