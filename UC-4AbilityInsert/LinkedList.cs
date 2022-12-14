using System;
using System.Collections.Generic;
using System.Text;

namespace UC_4AbilityInsert
{
    public class LinkedList
    {
        public Node head;
        public void Add(int id)
        {
            Node node = new Node(id);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;



            }
            Console.WriteLine("{0} is inserted int linked list", node.id);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.id + "");
                temp = temp.next;
            }
        }
        public Node InsertAtParticularPosition(int position,int id)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(id);
                newNode.next = this.head;
                head = newNode;
                
            }
            else 
            {
                while (position-- !=0) 
                {
                if (position==1) 
                    {
                    Node node=new Node(id);
                        node.next = this.head.next;
                        head.next = node;
                        break;

                    }
                   head=head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");

                }
                Console.WriteLine("inserted value is:" + head);
                return head;
            }
        }
 }  }

   
