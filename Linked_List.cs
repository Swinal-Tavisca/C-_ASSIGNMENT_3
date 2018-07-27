using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT3
{
    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            return;
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            Console.WriteLine("ADDED : {0}", data);
            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
            return;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
            Console.WriteLine("ADDED : {0}", data);
            return;
        }
    }

    class Linked_List:Common_Operations
    {
        public override void add()
        {
            int flag = 0;
            do
            {
                Console.WriteLine("1. ADD BEGUNING");
                Console.WriteLine("2. ADD ENDING");
                Console.WriteLine("3. DISPLAY");
                Console.WriteLine("4. EXIT");
                int option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    LinkedList ll = new LinkedList();
                    ll.AddFirst("Hello");
                    ll.AddFirst("Magical");
                    ll.AddFirst("World");
                }
                else if(option==2)
                {
                    LinkedList ll = new LinkedList();
                    ll.AddLast("Hello");
                    ll.AddLast("Magical");
                    ll.AddLast("World");
                }
                else if(option==3)
                {
                    LinkedList ll = new LinkedList();
                    ll.printAllNodes();
                }
                else if(option==4)
                {
                    flag = 1;
                }

            } while (flag == 0);
            //throw new NotImplementedException();
        }

        public void LinkedList1()
        {
            
            int flag = 0;
            do
            {
                Console.WriteLine("*********LINK LIST*********");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. EXIT");
                int option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    Linked_List add_object = new Linked_List();
                    add_object.add();
                }
                else if(option==2)
                {
                    flag = 1;

                }
                
            } while (flag == 0);

        }

        public override void remove()
        {
            throw new NotImplementedException();
        }
    }
}
