using StacksAndQueuesDataStructures;

namespace StacksAndQueuesDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform\n1.Push the Code\n2.Peek and Pop\n3.Enqueu the Queues\n4.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                StacksAndQueues stack=new StacksAndQueues();
                switch (option)
                {
                    case 1:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                        case 2:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Peak();
                        stack.Pop();
                        stack.Display();
                        break;
                    case 3:
                        Queues queues=new Queues();
                        queues.Enqueue(56);
                        queues.Enqueue(30);
                        queues.Enqueue(70);
                        queues.Display();
                        break;
                        case 4:
                        flag= false;
                        break;
                }
            }
        }
    }
}
