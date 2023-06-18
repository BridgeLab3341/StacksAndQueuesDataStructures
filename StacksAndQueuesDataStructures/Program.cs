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
                Console.WriteLine("Choose Option to Perform\n1.Push the Code\n2.Exit");
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
                        flag= false;
                        break;
                }
            }
        }
    }
}
