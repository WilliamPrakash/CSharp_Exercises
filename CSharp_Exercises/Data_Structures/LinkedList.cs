using System;
namespace CSharp_Exercises.Data_Structures
{
	public class LinkedList
	{
		public Node head;
		public LinkedList(int firstNodeData)
		{
			head = new Node(firstNodeData);
		}

		public void add(int data)
		{
			Node current = head;
			while (current.next != null)
			{
				current.next = current.next.next;
			}
			Console.WriteLine(current);
			current.next = new Node(data);
			Console.WriteLine(this);

		}

	}

	public class Node
	{
		public int data;
		public Node next;
		public Node(int x)
		{
			data = x;
			next = null;
		}
	}
}

