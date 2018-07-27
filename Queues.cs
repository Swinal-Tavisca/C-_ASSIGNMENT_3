using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT3
{
    public class Queues: Common_Operations,Queue_Interface
    {
        public void Queues1()
        {
            int flag = 0;
            index = 0;
            do
            {
                Console.WriteLine("**************QUEUE*************");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. REMOVE");
                Console.WriteLine("3. DISPLAY");
                Console.WriteLine("4. SORT");
                Console.WriteLine("5. EXIT");
                int options = int.Parse(Console.ReadLine());
                if (options == 1)
                {
                    Queues queue_object = new Queues();
                    queue_object.add();

                }
                else if (options == 2)
                {
                    Queues queue_object = new Queues();
                    queue_object.remove();
                }
                else if(options == 3)
                {
                    Queues queue_object = new Queues();
                    queue_object.display();
                }
                else if(options==4)
                {
                    Queues queue_object = new Queues();
                    queue_object.ds_sort();
                }
                else if (options == 5)
                {
                    flag = 1;
                }

            } while (flag == 0);

        }
        public override void add()
        {
            Console.WriteLine("ENTER NUMBER OF ELEMENTS TO BE ADDED");
            int num = int.Parse(Console.ReadLine());
            int result = is_full(index+num);
            if(result==0)
            {
                Console.WriteLine("SIZE TOO HIGH");
                return;
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    arr[index] = int.Parse(Console.ReadLine());
                    index++;
                }
            }
           
            return;
            //throw new NotImplementedException();
        }
        public int is_empty()
        {
            if(index==0)
            {
                Console.WriteLine("QUEUE IS EMPTY");
                return 1;
            }
            else
            {
                Console.WriteLine("QUEUE IS NOT EMPTY");
                return 0;
            }
            
            //throw new NotImplementedException();
        }
        public int is_full(int num)
        {
            if (num > arr.Length)
            {
                return 0;
            }
            else
            {
                return 1;
            }
           // throw new NotImplementedException();
        }
        public int peek()
        {
            Console.WriteLine("PEEK ELEMENT = {0}", arr[index]);
            return arr[index];
           // throw new NotImplementedException();
        }
        public override void remove()
        {
            int temp = arr[0];

            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            
           
            //throw new NotImplementedException();
        }

        
    }
}
