using System.Globalization;

namespace Queue_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactManager manager = new ContactManager();
            manager.AddContact("John Doe");
            manager.AddContact("Jane Smith");
            manager.AddContact("Alice Johnson");
            manager.AddContact("Bob Brown");

            Console.WriteLine("Enter a name to add to the queue: ");
            string addcontact = Console.ReadLine();
            addcontact = addcontact.Trim();
            manager.AddContact(addcontact);
            manager.PrintList();
            Console.WriteLine("press anykey to dequeue:  ");
            Console.ReadKey();
            Console.WriteLine();
            // Dequeue the first contact
            manager.DequeueContact();
            Console.WriteLine("After dequeuing the first contact:");
            manager.PrintList();



        }
    }
}

