using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 4 3 1 9 8 6 7 15 10
            BinaryTree bt = new BinaryTree();
            bt.Add(5);
            bt.Add(9);
            bt.Add(4);
            bt.Add(3);
            bt.Add(8);
            bt.Add(15);
            bt.Add(1);
            bt.Add(6);
            bt.Add(10);
            bt.Add(7);
            bt.Print();
            Console.WriteLine();
            bt.PrintSorted();

        }
    }
}
