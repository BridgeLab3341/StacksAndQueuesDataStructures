using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesDataStructures
{
    public class StacksAndQueues
    {
        private Node top;
        public StacksAndQueues()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)    
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is Pushed to Stack",value);
        }
        public void Display()
        {
            Node temp=this.top;
            while(temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp= temp.next;
            }
        }
    }
}
