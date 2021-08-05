using System;

namespace AddressBookSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System");

           AddressBook.EnterDetails();
            AddressBook obj = new AddressBook();
            obj.ViewTheDetails();
            Console.ReadLine();
        }
    }
}
