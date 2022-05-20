using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDetails
{
    internal class ContactAddress
    {
        public void GetContact()
        {

            IDictionary<string, string> Address = new Dictionary<string, string>();
            Console.WriteLine("Enter your First name");
            string First_Name = Console.ReadLine();

            Console.WriteLine("Enter your Last name");
            string Last_Name = Console.ReadLine();

            Console.WriteLine("Enter your city name");
            string City = Console.ReadLine();

            Console.WriteLine("Enter your state name");
            string State = Console.ReadLine();

            Console.WriteLine("Enter your ZIP number");
            int ZIP = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter your phone number");
            int PhoneNum = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter your Email ID");
            string EmailID = Console.ReadLine();
            
            Console.WriteLine("*****Details*****");
            Address.Add("FullName", First_Name + ' ' + Last_Name);
            Address.Add("FirstName", First_Name);
            Address.Add("LastName", Last_Name);
            Address.Add("City", City);
            Address.Add("State", State);
            Address.Add("ZIP", ZIP);
            Address.Add("PhoneNumber:" , PhoneNum);
            Address.Add("Email", EmailID);

            foreach (var details in Address)
            {
                Console.WriteLine("{0}: {1}", details.Key, details.Value);

            }

            static void Main(string[] args)
            {

                ContactAddress contactAddress = new ContactAddress();

                contactAddress.GetContact();
            }
        }

    }


}
