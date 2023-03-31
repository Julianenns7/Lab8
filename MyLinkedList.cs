using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class MyLinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; }
        public LinkedList()
        {
            
        }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            newNode.Value = value;
            Node head = this.Head;
            newNode.Next = Head;
            this.Head = newNode;
            this.Count++;
            
        }

        public void AddLast(string value) 
        {
            Node newNode = new Node(value);

            newNode.Value = value;

            if (head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                Head = Head.Next;
                this.Count--;
            }
        }

        public void RemoveLast() 
        {
            if 
        }

        public void GetValue() { }
    }

   
}
