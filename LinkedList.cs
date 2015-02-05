using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LinkedList
{
    public LinkedList()
    {
        name = "Default List Title";
        head = null;
    } // end default constructor

    public LinkedList(string listTitle)
    {
        name = listTitle;
        head = null;
    } // end overloaded constructor
    
    public void InsertAtEnd(int toAdd)
    {
        if (head == null) // if the list is empty
        {
            head = new Node(toAdd); // create a new Node and assign it to head
        } // end if

        else // there is at least one element in the list
        {
            Node curr = head; // point a temporary Node reference to head
            
            // step through the list
            while(curr.Next != null) 
            {
                curr = curr.Next;
            } // end while
            curr.Next = new Node(toAdd);
        } // end else
    } // end InsertAtEnd

    public void InsertAtBeginning(int toAdd)
    {
        Node curr = head; // point a temporary Node to head
        head = new Node(toAdd); // reassign head to the new Node
        head.Next = curr; // point the new Node's next Node to curr (old head)
    } // end InsertAtBeginning()

    // RemoveFromEnd deletes the last link in the linked list by making it null
    public void RemoveFromEnd()
    {
        if (!IsEmpty()) // the list is not empty
        {
            if (!IsEmpty())
            {
                if (head.Next == null) // there is only one element in the list
                {
                    head = null; // remove it
                } // end if

                else
                {
                    // temporary Nodes
                    Node curr = head;
                    Node prev = curr;

                    while (curr.Next != null) // traverse to the end of the list
                    {
                        prev = curr;
                        curr = curr.Next;
                    } // end while

                    curr = null; // null out the last Node
                    prev.Next = null; // make sure the next to last Node's Next reference is null too
                } // end else
            } // end if
        } // end if(!IsEmpty())

        else
        {
            Console.WriteLine("There is nothing to remove");
        } // end else
    } // end RemoveFromEnd()

    // RemoveFromBeginning removes the first Node in the list
    public void RemoveFromBeginning()
    {
        if (!IsEmpty())
        {
            head = head.Next;
        } // end if

        else
        {
            Console.WriteLine("There is nothing to remove");
        } // end else
    } // end RemoveFromBeginning()


    // Print method to output list contents into Console
    public void Print()
    {
        Console.WriteLine(name);
        if (!IsEmpty())
        {
            Node curr = head;
            while (curr != null)
            {
                Console.WriteLine(curr.Data); // print the current Node's data                
                curr = curr.Next;
            } // end while
        } // end if

        else
        {
            Console.WriteLine("The list is empty");
        } // end else
    } // end Print()

    // a private function to determine if the list is empty based on whether
    // head is null or not
    private bool IsEmpty()
    {
        if (head == null)
        {
            return true;
        } // end if

        else
        {
            return false;
        } // end else
    } // end isEmpty()

    // Node struct encapsulated in the LinkedList class makes up each link in
    // the list
    private class Node
    {
        // default Node constructor, for inserting at end of list
        public Node(int dataValue) 
        {
            Data = dataValue;
            Next = null;
        } // end default Node constructor

        // overloaded Node constructor used for inserting in a list where the next Node is known
        public Node(int dataValue, Node nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        } // end overloaded Node constructor

        public Node Next { get; set; } // accessor and mutator for variable next
        public int Data { get; set; } // accessor and mutator for variable data

        private Node next;
        private int data;
        
    } // end Node class

    private Node head; // the start of the list
    private string name; // name of the list
} // end LinkedList class 

