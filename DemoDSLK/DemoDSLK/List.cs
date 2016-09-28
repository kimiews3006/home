using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDSLK
{
    class List<D>
    {
        Element<D> head;
        public List()
        {
            head = null;
        }
        public void addfirst(Element <D> e)
        {
            e.Next = head;
            this.head = e;
         }
        public void printList()
        {
            Element<D> pointer = head;
            while(pointer !=null)
            {
                Console.WriteLine(pointer.Data);
                pointer = pointer.Next;
            }
        }
            
    }
}
