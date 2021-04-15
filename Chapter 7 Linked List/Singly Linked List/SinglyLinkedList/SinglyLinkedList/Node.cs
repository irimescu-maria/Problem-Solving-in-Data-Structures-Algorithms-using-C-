using System;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;


            public Node(int v, Node n)
            {
                value = v;
                next = n;
            }

            public Node(int v)
            {
                value = v;
                next = null;
            }
        }


        //head is used to store the firt element of the list
        private Node head;
        private int count = 0;

        public int size()
        {
            return count;
        }

        // Empty field
        public bool Empty
        {
            get { return count == 0; }
        }

        // Insert the element at the head
        public void addHead(int value)
        {
            head = new Node(value, head);
            count++;
        }

        // Insert of an element at the end
        public void addTail(int value)
        {
            Node newNode = new Node(value, null);
            Node curr = head;
            if (head == null)
                head = newNode;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }

        // Traversing Linked List
        public void print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + "");
                temp = temp.next;
            }
        }

        // Sorted Insert
        public void sortedList(int value)
        {
            Node newNode = new Node(value, null);
            Node curr = head;

            if (curr == null || curr.value > value)
            {
                newNode.next = head;
                head = newNode;
                return;
            }

            while (curr.next != null && curr.next.value < value)
            {
                curr = curr.next;
            }

            newNode.next = curr.next;
            curr.next = newNode;
        }

         // Search element in a linked list
         public bool isPresent(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if(temp.value == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        // Delete element from the linked list
        // Delete First element in a linked list
        public int DeleteHead()
        {
            if(Empty)
            {
                throw new System.InvalidOperationException("Empty List Exception");
            }
            int value = head.value;
            head = head.next;
            count--;
            return value;
        }

        // Delete node from the linked list given its value
        public bool deleteNode(int delValue)
        {
            Node temp = head;
            if(Empty)
            {
                throw new InvalidOperationException("EmptyListException");
            }

            if(delValue == head.value)
            {
                head = head.next;
                count--;
                return true;
            }

            while (temp.next != null)
            {
                if(temp.next.value == delValue)
                {
                    temp.next = temp.next.next;
                    count--;
                    return true;
                }
                temp = temp.next;
            }

            return false;
        }
    }
}
