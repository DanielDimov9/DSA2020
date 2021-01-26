using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    public static class BinarySearchTreeTester
    {
        public static void RunTest()
        {
            BinarySearchTree<string> tree = new BinarySearchTree<string>();

            tree.Insert("IBM");

            tree.Insert("VUM");

            tree.Insert("Google");

            tree.Insert("Adobe");

            tree.Insert("Microsoft");

            tree.PrintTreeDFS(); // Google Microsoft VUM

            Console.WriteLine(tree.Contains("VUM")); // True

            Console.WriteLine(tree.Contains("IBM")); // False

            tree.Remove("VUM");

            Console.WriteLine(tree.Contains("VUM")); // False

            tree.PrintTreeDFS(); // Google Microsoft
        }
    }
}
