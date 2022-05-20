﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDetails
{
    internal class ContactAddress
    {
        ArrayList personlist = new ArrayList();

        public void Addition()
        {
            Console.WriteLine("Enter number of person contact address to save");
            int Num = Convert.ToInt32(Console.ReadLine());

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

        public void Edit()
        {
            Console.WriteLine("\nEnter the Name whose data you want to change");
            string Name = Console.ReadLine();
            for (int i = 0; i < personlist.Count; i += 7)
            {
                if (String.Equals(Name, (personlist[i])))
                {
                    Console.WriteLine("Name:" + personlist + "==" + personlist[i]);
                    Console.WriteLine("Press 1: for first name");
                    Console.WriteLine("Press 2: for last name name");
                    Console.WriteLine("Press 3: for city name");
                    Console.WriteLine("Press 4: for state name");
                    Console.WriteLine("Press 5: for ZIP number");
                    Console.WriteLine("Press 6: for phone number");
                    Console.WriteLine("Press 7: for Email ID");
                    int check = Convert.ToInt32(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            Console.WriteLine("Enter your correct first name");
                            string FirstName = Console.ReadLine();
                            personlist[i] = FirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter your correct last name");
                            string LastName = Console.ReadLine();
                            personlist[i+1] = LastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter your correct city name");
                            string City = Console.ReadLine();
                            personlist[i+2] = City;
                            break;
                        case 4:
                            Console.WriteLine("Enter your correct state name");
                            string State = Console.ReadLine();
                            personlist[i+3] = State;
                            break;
                        case 5:
                            Console.WriteLine("Enter your correct ZIP number");
                            string ZIP = Console.ReadLine();
                            personlist[i+4] = ZIP;
                            break;
                        case 6:
                            Console.WriteLine("Enter your correct Phone number");
                            string PhoneNum = Console.ReadLine();
                            personlist[i+5] = PhoneNum;
                            break;
                        case 7:
                            Console.WriteLine("Enter your correct EmailID");
                            string EmailID = Console.ReadLine();
                            personlist[i+6] = EmailID;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;

                    }
                }
            }
            int j = 0;
            int count = 1;
            foreach (var item in personlist)
            {
                if (j % 7 == 0)
                {
                    Console.WriteLine("\nAfter editing the datas are:");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + personlist[j]);
                    Console.WriteLine("Last Name: " + personlist[j + 1]);
                    Console.WriteLine("City Name: " + personlist[j + 2]);
                    Console.WriteLine("State Name: " + personlist[j + 3]);
                    Console.WriteLine("ZIP Number:" + personlist[j + 4]);
                    Console.WriteLine("Phone Number:" + personlist[j + 5]);
                    Console.Write("Email ID:" + personlist[j + 6]);
                    count++;

                }
                j++;
            }

        }


        static void Main(string[] args)
            {

                ContactAddress contactAddress = new ContactAddress();

            contactAddress.Addition();
            contactAddress.Edit();
        }
        

    }


}
