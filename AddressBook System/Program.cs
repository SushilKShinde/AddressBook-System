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
            Console.WriteLine("Choose from the below options\n ");
            Console.WriteLine(" 1.Print existing contact details in adress book\n 2.Add new contact in address book\n ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Contact.ContactDetails();
                    break;
                case 2:
                    AddNewContact contact = new AddNewContact();
                    contact.AddNewContactToAddressBook();
                    break;
            }
            

        }
    }
}
