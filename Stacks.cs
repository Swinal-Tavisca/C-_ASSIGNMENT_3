using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT3
{
    public class Stacks : Common_Operations, Stack_Interface
    {
        public void Stacks1()
        {
            int flag = 0;
            index = 0;
            do
            {
                Console.WriteLine("*************STACK*************");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. REMOVE");
                Console.WriteLine("3. DISPLAY");
                Console.WriteLine("4. SORT");
                Console.WriteLine("5. EXIT");
                int option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    Stacks add_object = new Stacks();
                    add_object.add();
                }
                else if(option==2)
                {
                    Stacks remove_object = new Stacks();
                    remove_object.remove();
                }
                else if(option==3)
                {
                    Stacks remove_object = new Stacks();
                    remove_object.display();
                }
                else if(option==4)
                {
                    Stacks remove_object = new Stacks();
                    remove_object.ds_sort();
                }
                else if(option==5)
                {
                    flag = 1;
                }
            } while (flag == 0);
        }

        public override void add()
        {
            Console.WriteLine("ENTER NUMBER OF ELEMENTS TO BE PUSHED");
            int num = int.Parse(Console.ReadLine());
            int result = is_full(index + num);
            if (result == 0)
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
            //throw new NotImplementedException();
        }

        public override void remove()
        {
            Console.WriteLine("ENTER THE NUMBER OF ELEMENTS TO BE POPED");
            int number = int.Parse(Console.ReadLine());
            for(int i=index;i>number;i--)
            {
                if(is_empty()==1)
                {
                    break;
                }
                arr[i] = 0;
                index--;
            }
            //throw new NotImplementedException();
        }
        public int is_empty()
        {
            if (index == 0)
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
        public void top()
        {
            Console.WriteLine(arr[index]);
           // throw new NotImplementedException();
        }
    }
}
