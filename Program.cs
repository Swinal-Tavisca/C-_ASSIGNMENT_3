using System;

namespace ASSIGNMENT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            do
            {
                Console.WriteLine("ENTER YOUR OPTION");
                Console.WriteLine("1. QUEUE");
                Console.WriteLine("2. STACK");
                Console.WriteLine("3. LINKLIST");
                Console.WriteLine("4. EXIT");
                int option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    Queues queue_object = new Queues();
                    
                    queue_object.Queues1();
                    
                }
                else if(option==2)
                {
                    Stacks stack_object = new Stacks();
                    stack_object.Stacks1();

                }
                else if(option==3)
                {
                    Linked_List link_object = new Linked_List();
                    link_object.LinkedList1();

                }
                else if(option==4)
                {
                    flag = 1;
                }
            } while (flag == 0);
            

        }
    }
}
