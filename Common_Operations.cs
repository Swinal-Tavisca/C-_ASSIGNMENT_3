using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT3
{
    public abstract class Common_Operations
    {
        public static int[] arr = new int[10];
        public static int index=0;
        public object Arrays { get; private set; }

        public abstract void add();
        public  abstract void remove();
        
        public void display()
        {
            Console.WriteLine("MY DATASTRUCTURE ELEMENTS :");
            for(int i=0;i<index;i++)
            {
                Console.Write("   {0}   ", arr[i]);
            }
        }
        public void ds_sort()
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]!=0)
                {
                    Console.Write("   {0}   ", arr[i]);
                }

                
            }
        }

    }
}
