using DataStructures.Algs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Apps
{
    class BinaryTreeApp
    {
        static void Main()
        {
            BinaryTree<int> tree = InitializeTree();
            Console.WriteLine("Tree Size: " + tree.Size);
            Console.WriteLine("does tree cotains 4 :" + tree.Contains(4));
            try
            {
                tree.Add(7);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            tree.InOrderTraversal();

            tree.Root.Print();

            Console.WriteLine("\nRemove Case-1 : Leaf node (3)");
            tree.Remove(3);
            Console.WriteLine("Tree Size: " + tree.Size);
            tree.Root.Print();

            Console.WriteLine("\nRemove Case-2 : Delete node that has just left node (2)");
            tree.Remove(2);
            Console.WriteLine("Tree Size: " + tree.Size);
            tree.Root.Print();

            Console.WriteLine("\nRemove Case-3 : Delete node that has right node but it does not have left node (5)");
            tree.Remove(5);
            Console.WriteLine("Tree Size: " + tree.Size);
            tree.Root.Print();

            Console.WriteLine("\nRemove Case-4 : Delete node that has right node which has a left node (7)");
            tree.Remove(7);
            Console.WriteLine("Tree Size: " + tree.Size);
            tree.Root.Print();

            Console.ReadKey();
        }

        static BinaryTree<int> InitializeTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(4);
            tree.Add(2);
            tree.Add(7);
            tree.Add(1);
            tree.Add(3);
            tree.Add(5);
            tree.Add(6);
            tree.Add(10);
            tree.Add(8);
            tree.Add(9);
            return tree;
        }
    }
}
