using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class Node
    {
        // Linked lists contain a chain of nodes which store the data they contain and a pointer to the next node
        public Node next;
        public Object data;
    }
    public class LL
    {
        private Node head;
        private int size;

        public void printFirstNode()
        {
            Node current = head;
            // Verify that I actually have content present in the list
            if (head != null)
            {
                Console.WriteLine(current.data);
            }
            else
            {
                Console.WriteLine("List is empty.");
            }
            
        }
        public void AddFront(Object incomingData)
        {
            // First, increase the size of the linked list
            size++;

            var node = new Node();
            node.data = incomingData;

            // Now, I'm going to check to see if this is the first item we are inserting
            if(head == null)
            {
                // Head hasn't been assigned, so assign it
                head = node;
                Console.WriteLine("Added first node with data: " + node.data);
            }
            else
            {
                // Set the next node to the head node's next item
                node.next = head.next;
                // Set the head's next to the current node
                head.next = node;
                Console.WriteLine("Added new node with data: " + node.data);
            }
        }
        public void AddEnd(Object incomingData)
        {

            var node = new Node();
            node.data = incomingData;

            // Now, I'm going to check to see if this is the first item we are inserting
            if (head == null)
            {
                // Head hasn't been assigned, so assign it
                head = node;
                Console.WriteLine("Added first node with data: " + node.data);
            }
            else
            {
                // Create a cursor node to hold the data as I move through
                var currentLocation = new Node();

                currentLocation.next = head;

                // There's a bit more grace in moving through the list a set number of times instead of 
                for (int nodeCount = 0; nodeCount <= size; nodeCount++)
                {
                    if(currentLocation.next == null)
                    {
                        Console.WriteLine("Current Location's Data: " + currentLocation.data);
                        currentLocation.next = node;
                    }
                    else
                    {
                        Console.WriteLine("Current Location's Data: " + currentLocation.data);
                        currentLocation = currentLocation.next;
                    }
                }

                // The cursor is now at a position where the next node is null                
                Console.WriteLine("Added new node with data: " + node.data);
                size++;
            }
        }
        public void Length()
        {
            Console.WriteLine("The current length is: " + size);
        }

        public void printNodes()
        {
            // Start at the head
            Node currentLocation = head;
            int nodeCount = 0;
            
            // If there isn't another node, just print this node and don't go into a loop.
            if(currentLocation.next == null)
            {
                Console.WriteLine("Data: " + currentLocation.data);
            }
            else
            {
                // Cycle through nodes until the next node isn't null
                while (currentLocation != null && nodeCount != size)
                {
                    Console.WriteLine("Data: " + currentLocation.data);
                    currentLocation = currentLocation.next;

                    // To ensure I'm not getting stuck in a loop, only proceed through the list up to the length 
                    nodeCount++;
                }                
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Linked List");

            LL list1 = new LL();

            // Check the length before anything is added
            list1.Length();

            // Create the first add.
            list1.AddFront("Apples");

            // Add second data element
            list1.AddFront("Pears");

            // Output the current size of the list
            list1.Length();
            list1.printNodes();

            list1.AddEnd("Sun!");
            list1.printNodes();
            list1.Length();

            // Add a ReadKey just to see the output of a successful run
            Console.ReadKey();

        }
    }
}
