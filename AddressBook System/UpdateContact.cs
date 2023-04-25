using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    internal class UpdateContact
    {
        public static void UpdateContactDetails(List<Contact> list)
        {
            Contact obj = new Contact();
            Console.WriteLine("Enter the first name of person which you want to update");
            string name= Console.ReadLine();
            bool isExisting = false;

            foreach(Contact contact in list)
            {
                if (contact.firstName.Equals(name))
                {
                    isExisting = true;
                    Console.WriteLine($"firstName:{contact.firstName}, lastName = {contact.lastName}, address ={contact.address}, city = {contact.city},state = {contact.state}, email ={contact.email}, zip = {contact.zip}, phoneNumber = {contact.phoneNumber}");
                    Console.WriteLine("Choose from below options which details you want to update.");
                    Console.WriteLine("1.Update First name\n 2.Update Last name\n 3.Update address\n 4.Update city\n 5.Update state\n 6.Update email\n 7.Update zip code\n 8.Update Phone number\n 9. ");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter the updated first name");
                            contact.firstName = Console.ReadLine(); 
                            break;
                        case 2:
                            Console.WriteLine("Please enter the updated last name");
                            contact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter the updated address ");
                            contact.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter the updated city");
                            contact.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Please enter the updated state");
                            contact.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Please enter the updated email");
                            contact.email = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Please enter the updated zip");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Please enter the updated phone number");
                            contact.phoneNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 9:
                            Console.WriteLine("Please enter the updated first name");
                            contact.firstName = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Choose valid option");
                            break;
                    }
                    Console.WriteLine("Updated contact details:\n");
                    Console.WriteLine($"firstName:{contact.firstName}, lastName = {contact.lastName}, address ={contact.address}, city = {contact.city},state = {contact.state}, email ={contact.email}, zip = {contact.zip}, phoneNumber = {contact.phoneNumber}");
                }
                if(!isExisting)
                {
                    Console.WriteLine("Contact does not exist in address book");
                }
            }

        }
    }
}
