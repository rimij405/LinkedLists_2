using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE20___Linked_Lists_Again
{
	// implement a singly linked list
	class LinkedList
	{
		// attributes
		private Node head = null; // initially nothing in the list
		private int count = 0;

		// get data from an item in the list.
		public string GetData(int index)
		{
			// If index is invalid or list is empty.
			if (index < 0 || index >= count || head == null)
			{
				return null;
			}
			// If index is first index.
			else if (index == 0)
			{
				return head.Data;
			}
			// If index is within bounds.
			else
			{
				Node current = head;

				// Loop through the LinkedList.
				for (int i = 0; i < index; i++)
				{
					// If the next node is NOT null.
					if (current.Next != null)
					{
						// Move to the next node in the list.
						current = current.Next;
					}
					// If the next node is null.
					else
					{
						return null;
					}
				}

				return current.Data;
			}
		}

		// add an item to the list
		public void Add(string str)
		{
			// create the new node
			Node newNode = new Node(str);

			// special case - nothing in the list
			if (head == null)
			{
				head = newNode;
				count++;
				return;
			}

			// if we get here there's something in the list
			Node current = head;
			while (current.Next != null)
			{
				// move to next node in the list
				current = current.Next;
			}

			// now at end of the list
			current.Next = newNode; // add the new node at the end of the list
			count++;
		}

		// insert a new item, before the selected item.
		public void Insert(string data, int index)
		{
			// If list is empty or if index is greater than or equal to the last index.
			if (head == null || index >= (count - 1))
			{
				// Add.
				Add(data);
				return;
			}
			// If the index is less than or equal to the first index.
			else if (index <= 0)
			{
				Node insert = new Node(data);
				insert.Next = head;
				head = insert;
				count++;
				return;
			}
			// If index is within bounds.
			else
			{
				// Loop through to the node previous (index - 1).
				Node previous = head;
				for (int i = 0; i < (index - 1); i++)
				{
					// If the next node is NOT null.
					if (previous.Next != null)
					{
						// Move to the next node in the list.
						previous = previous.Next;
					}
					else
					{
						// At this point, you've reached the end. Just add.
						Add(data);
						return;
					}
				}

				// Create new node.
				Node insert = new Node(data);

				// Assign the previous node's temp.Next to temp.
				insert.Next = previous.Next;

				// Reassign the previous node's next to new node.
				previous.Next = insert;

				// Increment the count.
				count++;
			}
		}

		// insert a new item, before the selected item.
		public void InsertSorted(string data)
		{
			// If list is empty.
			if (head == null)
			{
				// Add.
				Add(data);
				return;
			}
			else if (String.Compare(data, head.Data) < 0)
			{
				Node insert = new Node(data);
				insert.Next = head;
				head = insert;
				count++;
				return;
			}
			// If list is not empty.
			else
			{
				Node current = head;

				while (current.Next != null)
				{
					if (String.Compare(data, current.Next.Data) < 0)
					{
						// Insert before the current.
						Node insert = new Node(data);
						insert.Next = current.Next;
						current.Next = insert;
						count++;
						return;
					}
					else if (String.Compare(data, current.Next.Data) > 0)
					{
						// Go to the next node.
						current = current.Next;
					}
					else //if (String.Compare(data, current.Next.Data) == 0)
					{
						// Go to the next node.
						current = current.Next;
						
						// Insert the node.
						Node insert = new Node(data);
						insert.Next = current.Next;
						current.Next = insert;
						count++;
						return;
					}
				}

				// If it hasn't been returned, insert it here.
				// Insert the node.
				Node insertLast = new Node(data);
				insertLast.Next = current.Next;
				current.Next = insertLast;
				count++;
				return;
			}
		}

		// clear the list, removing all data.
		public void Clear()
		{
			// remove all references to any data.
			head = null; // Other nodes will be handled by garbage collection.

			// reset the count.
			count = 0;
		}

		// traverse the list, printing all data
		public void Traverse()
		{
			// special case - no list
			if (head == null)
			{
				Console.WriteLine("No data in the list");
				return;
			}

			// loop through all of the items in the list
			Node current = head;
			while (current.Next != null)
			{
				// list the current node
				Console.WriteLine(current);

				// move to next node
				current = current.Next;
			}

			// still need to list the last node in the list
			Console.WriteLine(current);
		}
	}
}
