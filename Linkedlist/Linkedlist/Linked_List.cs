using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class Linked_List<T>
    {
        public Node<T> head;
        //add method
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted", node.data);
        }
        //Append Method
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        //Insert method
        public void Insert(int pos, T data)
        {
            Node<T> node = new Node<T>(data);
            if (pos < 1)
                Console.WriteLine("Invalid Position");
            else if (pos == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;

                while (pos > 2)
                {
                    temp = temp.next;
                    pos--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

        //Remove First Element
        internal Node<T> RemoveFirst()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        //Remove Last Element
        internal Node<T> RemoveLast()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<T> newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        //Search Method
        public bool Search(int value)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        //display method
        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
