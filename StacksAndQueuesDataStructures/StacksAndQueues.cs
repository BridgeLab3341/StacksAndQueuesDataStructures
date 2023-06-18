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
        public void Peak()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack Is Empty");
            }
            Console.WriteLine("{0} is in the top of the Stack",this.top.data);
        }
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is in the top of the Stack",this.top.data);
            this.top = this.top.next;
        }
        
    }
}
