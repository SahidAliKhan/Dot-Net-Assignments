using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class SinglyLinkedListNodeDemo
    {
        internal int data;
        internal SinglyLinkedListNodeDemo next;

        public SinglyLinkedListNodeDemo(int d)
        {
            data = d;
            next = null;
        }
    }

    public class DoublyLinkedListNodeDemo
    {
        internal int data;
        internal DoublyLinkedListNodeDemo head;
        internal DoublyLinkedListNodeDemo prev;
        internal DoublyLinkedListNodeDemo next;

        public DoublyLinkedListNodeDemo(int d)
        {
            data = d;
            prev = null;
            next = null;
        }

    }

    public class UserSingleLinkedList
    {
        SinglyLinkedListNodeDemo head;


        void InsertNodeInFront(UserSingleLinkedList list, int dataToInsert)
        {
            SinglyLinkedListNodeDemo node = new SinglyLinkedListNodeDemo(dataToInsert);
            node.next = list.head;
            list.head = node;

        }

        void InsertAtTheEnd(UserSingleLinkedList list, int dataToInsert)
        {
            SinglyLinkedListNodeDemo node = new SinglyLinkedListNodeDemo(dataToInsert);
            if (list.head == null)
            {
                list.head = node;
                return;
            }
            SinglyLinkedListNodeDemo node1 = GetLastNode(list);
            node1.next = node;

        }

        private SinglyLinkedListNodeDemo GetLastNode(UserSingleLinkedList list)
        {
            SinglyLinkedListNodeDemo tempnode = list.head;
            while (tempnode != null)
            {
                tempnode = tempnode.next;
            }
            return tempnode;
        }

        void InsertAfter(SinglyLinkedListNodeDemo prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("This cannot be null");
                return;

            }
            SinglyLinkedListNodeDemo newnode = new SinglyLinkedListNodeDemo(data);
            newnode.next = prevNode.next;
            prevNode.next = newnode;
        }

        void DeleteByFindingData(UserSingleLinkedList list, int dataToDelete)
        {

            SinglyLinkedListNodeDemo temp = list.head;
            SinglyLinkedListNodeDemo prev = null;
            if (temp != null && temp.data == dataToDelete)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
    }

    public class UserDoubleLinkedList
    {
        internal DoublyLinkedListNodeDemo head;
        void InsertNodeInFront(UserDoubleLinkedList list, int dataToInsert)
        {
            DoublyLinkedListNodeDemo node = new DoublyLinkedListNodeDemo(dataToInsert);
            node.next = list.head;
            list.head = node;
            node.prev = null;
            if (list.head != null)
            {
                list.head.prev = node;
                list.head.prev = node;
                list.head.prev = node;
            }


        }

        void DeleteByFindingData(UserDoubleLinkedList list, int data)
        {
            DoublyLinkedListNodeDemo temp = list.head;
            if (temp != null && temp.data == data)
            {
                list.head = temp;
                list.head.prev = temp.next;
                list.head.prev = null;
            }
            while (temp != null && temp.data != data)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;

            }
        }



        void InsertAfter(DoublyLinkedListNodeDemo prevnode, int data)
        {
            if (prevnode == null)
            {
                Console.WriteLine("cannot be null");
                return;

            }



            DoublyLinkedListNodeDemo newnode = new DoublyLinkedListNodeDemo(data);
            newnode.next = prevnode.next;
            prevnode.next = newnode;
            newnode.prev = prevnode;
            if (newnode.next != null)
            {
                newnode.next.prev = newnode;
            }

        }
        void InsertAtTheEnd(DoublyLinkedListNodeDemo list, int dataToInsert)
        {
            DoublyLinkedListNodeDemo node = new DoublyLinkedListNodeDemo(dataToInsert);
            if (list.head == null)
            {
                list.prev = null;
                list.head = node;
                return;
            }
            DoublyLinkedListNodeDemo node1 = GetLastNode(list);
            node1.next = node;
            node.prev = node1;

        }

        private DoublyLinkedListNodeDemo GetLastNode(DoublyLinkedListNodeDemo list)
        {
            DoublyLinkedListNodeDemo tempnode = list.head;
            while (tempnode != null)
            {
                tempnode = tempnode.next;

            }
            return tempnode;
        }
    }
}