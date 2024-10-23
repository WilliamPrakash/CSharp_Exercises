using System;
namespace CSharp_Exercises.Data_Structures
{
	public class LinkedList
	{
		public Node head;
		public int size;
		public LinkedList(int firstNodeData)
		{
			head = new Node(firstNodeData);
			size++;
		}

		public void add(int data) // Adds to end
		{
			Node current = head;
			while (current.next != null)
			{
				current = current.next;
			}
			current.next = new Node(data);
			size++;
		}

		public void addAt(int data, int index) // Adds new node to index slot
		{

		}

		public void remove() // Removes from end
		{
			Node current = head;
            while (current.next.next != null)
            {
				current = current.next;
            }
			Console.WriteLine(current);
			current.next = null;
			size--;
        }

		public void removeAt(int index) // Remove at index (0 based)
		{
			/* this doesn't take into account cases where the index isn't in the linked list */
			Node current = head;
			int i = 0;
			// iterate over linked list, while keeping track of index
			while (i < index-1) // -1 so we get to the index before the one we wanna remove
			{
				current = current.next;
				i++;
			}
			current.next = current.next.next;
            Console.WriteLine(current);
        }

	}

	public class Node
	{
		public int data;
		public Node? next;
		public Node(int x)
		{
			data = x;
			next = null;
		}
	}
}

