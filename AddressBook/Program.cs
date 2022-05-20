﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDetails
{
    internal class ContactAddress
    {
        public void CreateContact()
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
            Address.Add("PhoneNumber:", PhoneNum);
            Address.Add("Email", EmailID);

            foreach (var details in Address)
            {
                Console.WriteLine("{0}: {1}", details.Key, details.Value);

            }
        }
        public void Addition()
        {
            Console.WriteLine("Enter number of person contact address to save");
            int Num = Convert.ToInt32(Console.ReadLine());
            ArrayList personlist = new ArrayList();

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("\nAdd details of person number: " + i);

                Console.WriteLine("Enter your First name");
                string First_Name = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                string Last_Name = Console.ReadLine();
                Console.WriteLine("Enter your city name");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your state name");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your ZIP number");
                string ZIP = Console.ReadLine();
                Console.WriteLine("Enter your phone number");
                string PhoneNum = Console.ReadLine();
                Console.WriteLine("Enter your Email ID");
                string EmailID = Console.ReadLine();
                personlist.Add(First_Name);
                personlist.Add(Last_Name);
                personlist.Add(City);
                personlist.Add(State);
                personlist.Add(ZIP);
                personlist.Add(PhoneNum);
                personlist.Add(EmailID);
            }
            int j = 0;
            int count = 1;
            foreach (var item in personlist)
            {
                if (j % 7 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + personlist[j]);
                    Console.WriteLine("Last Name: " + personlist[j+1]);
                    Console.WriteLine("City Name: " + personlist[j+2]);
                    Console.WriteLine("State Name: " + personlist[j+3]);
                    Console.WriteLine("ZIP Number:" + personlist[j+4]);
                    Console.WriteLine("Phone Number:" + personlist[j+5]);
                    Console.Write("Email ID:" + personlist[j+6]);
                    count++;

                }
                j++;
            }
        }


        static void Main(string[] args)
            {

                ContactAddress contactAddress = new ContactAddress();

                contactAddress.CreateContact();
                contactAddress. Addition();
            }
        

    }


}
