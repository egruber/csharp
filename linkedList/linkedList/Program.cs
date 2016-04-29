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
                Console.WriteLine("Added first Node");
            }
            else
            {
                // Set the next node to the head node's next item
                node.next = head.next;
                // Set the head's next to the current node
                head.next = node;
            }
        }
        public void Length()
        {
            Console.WriteLine("The current length is: " + size);
        }

        public void printNodes()
        {
            // Start at the head
            Node current_location = head;
            
            // If there isn't another node, just print this node and don't go into a loop.
            if(current_location.next == null)
            {
                Console.WriteLine("Data: " + current_location.data);
            }
            else
            {
                // Cycle through nodes until the next node isn't null
                while (current_location.next != null)
                {
                    Console.WriteLine("Data: " + current_location.data);
                    current_location = current_location.next;
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
            string data = "Apples";
         
            // Create the first add.
            list1.AddFront(data);

            // Add second data element
            data = "Pears";
            list1.AddFront(data);

            // Output the current size of the list
            list1.Length();
            list1.printNodes();

            // Add a ReadKey just to see the output of a successful run
            Console.ReadKey();

        }
    }
}
