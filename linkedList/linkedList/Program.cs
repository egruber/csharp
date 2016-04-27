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
        public void Add(Object incomingData)
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
                // Since it's not the first item, I need to add it to the end

                
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
            
            // Display an empty list
            //list1.printFirstNode();

            // Create the first add.
            list1.Add(data);
            list1.printFirstNode();


            // Add a ReadKey just to see the output of a successful run
            Console.ReadKey();

        }
    }
}
