﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UC_5DeleteElement
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
        public void poplast(int id) 
        {
        Node temp=this.tail;
            temp = tail;
            if (tail!=null) 
            {
                
                
                temp = tail;
                tail= tail.next;
                temp = null;
            }
        }
}   }
