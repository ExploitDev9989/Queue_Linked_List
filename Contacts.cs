using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Linked_List
{
    public class Contacts
    {
        public string name;
        public Contacts? Next;


        public Contacts(string name)
        {
            this.name = name;
            Next=null;
        }

    }
}
