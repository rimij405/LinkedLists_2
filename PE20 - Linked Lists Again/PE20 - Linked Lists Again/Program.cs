using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE20___Linked_Lists_Again
{
	// test class
	class Program
	{
		static void Main(string[] args)
		{
			// create a linked list
			LinkedList list = new LinkedList();

			// populate the list
			Console.WriteLine("InsertSorted: { f, b, a, d, g }");
			list.InsertSorted("f");
			list.InsertSorted("b");
			list.InsertSorted("a");
			list.InsertSorted("d");
			list.InsertSorted("g");

			// traverse the list
			list.Traverse();
			Console.ReadLine();

			// add some more.
			Console.WriteLine("InsertSorted: { c, h, e }");
			list.InsertSorted("c");
			list.InsertSorted("h");
			list.InsertSorted("e");

			// traverse the list
			list.Traverse();
			Console.ReadLine();

			Console.WriteLine("Get Data from element #5 (index 4): " + list.GetData(4));
			Console.ReadLine();
		}
	}
}
