using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Linked_List
{
    internal class ContactManager
    {
        private Contacts? head = null;
        private Contacts? tail = null;

        public void AddContact(string name)
        {
            Contacts newContact = new Contacts(name);
            // if list is empty
            if (head == null)
            {
                head = newContact;
                tail = newContact;
                return;
            }
            tail.Next = newContact;
            tail = newContact;
        }
        public void DequeueContact()
        {
            if (head == null)
            {
                Console.WriteLine("The contact list is empty.");
                return;
            }
            head = head.Next;
            if (head == null)
            {
                tail = null; // If the list becomes empty, reset tail as well
            }
        }
        public void PrintList()
        {
            Contacts? current = head;
            while (current != null)
            {
                Console.Write(current.name + (current.Next != null ? " -> " : ""));
                current = current.Next;
            }
            Console.WriteLine(" -> null");
        }
    }
}
