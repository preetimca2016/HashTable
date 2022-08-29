using System;

namespace BinarySearchTreeNameSpace
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary tree Search");
            Console.WriteLine("Enter 1 for AddNode");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    BinaryTree.AddNode(56);
                    BinaryTree.AddNode(30);
                    BinaryTree.AddNode(70);
                    break;                   
            }


        }
    }
}