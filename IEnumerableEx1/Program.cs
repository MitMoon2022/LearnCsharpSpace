//IEnumerable
//This time, you have to create Contact and PhoneBook classes in the right way that will allow 
//you to run the Main method we provided.

//Contacts = new List<Contact>{
//                new Contact("Andre", "435797087"),
//                new Contact("Lisa", "435677087"),
//                new Contact("Dine", "3457697087"),
//                new Contact("Sofi", "4367697087")
//            };
using System;
using System.Collections.Generic;
using System.Collections;

namespace IEnumerableEx1
{
    class Contact
    {
        // solution
        public string Name { get; set; }
        public string Phone { get; set; }
        public void Call()
        {
            System.Console.WriteLine("Calling to {0}. Phone number is {1}", Name, Phone);
        }
        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        // solution
    }

    class PhoneBook : IEnumerable<Contact>
    {

        public List<Contact> Contacts;
        public PhoneBook()
        {
            Contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }
        // solution
        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        // solution
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Start of Program!");
            PhoneBook MyPhoneBook = new PhoneBook();
            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
            Console.ReadKey();
        }
    }
}