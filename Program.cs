using System;
using BinarySearchTree.Models;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch, dataValue;

            BinaryTree binaryTree = new BinaryTree();

            do
            {
                Console.WriteLine("--- BINARY SEARCH TREE  ----");
                Console.WriteLine("\n");
                Console.WriteLine("1 - Insert");
                Console.WriteLine("2 - Show Tree In Order Traversal");
                Console.WriteLine("3 - Exit");
                Console.Write("Choose one option: ");
                ch = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Inform a number to insert: ");
                        dataValue = Int32.Parse(Console.ReadLine());
                        binaryTree.Insert(dataValue);
                        break;
                    case 2:
                        Console.WriteLine("Showing Tree in Order Traversal");
                        binaryTree.inOrderTraversal();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Choose an available option!");
                        break;
                }
            } while (ch != 3);
        }
    }
}
