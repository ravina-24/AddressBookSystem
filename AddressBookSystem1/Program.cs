﻿using System;

namespace AddressBookSystem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            



            while (true)
            {
                Console.WriteLine("\n Enter your choice \n 1 for Adding AddessbookName \n 2 for adding address book name in th existing address book" +
                    " \n 3 for editing the existing contact \n 4 for deleting the contact\n 5 for viewing Address book \n 6 for searching person by its state and city " +
                     " \n 7 for for sorting address book alphabetically" + "\n 8 for sorting the address book by state , city and zip  alphabetically");


                Console.WriteLine("................................................");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        AddressBook.AddressBookNewNameValidator();
                        break;

                    case 2:
                        AddressBook.AddressBookExistingNameValidator();
                        break;

                    case 3:
                        AddressBook.EditDetails();
                        break;

                    case 4:
                        AddressBook.DeleteName();
                        break;

                    case 5:
                        AddressBook.ViewTheDetails();
                        break;

                    case 6:
                        AddressBook.PersonSearch();
                        break;

                    case 7:
                        AddressBook.SortEntriesAlphabetically();
                        break;

                    case 8:
                        AddressBook.SortByCityStateZip();
                        break;

                    default:

                        Console.WriteLine("Enter valid choice.");
                        break;

                }

            }
        
        }
    }
}

              
               
         
      


               