using System;

namespace BinarySearchTreeNameSpace
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary tree Search");
            Console.WriteLine("Enter 1 for AddNode");
            Console.WriteLine("Enter 2 for GetSizeOfTree");
            Console.WriteLine("Enter 3 SearchNode");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    BinaryTree.AddNode(56);
                    BinaryTree.AddNode(30);
                    BinaryTree.AddNode(70);
                    break;
                case 2:
                    int Size = BinaryTree.GetSize();
                    Console.WriteLine(Size);
                    break;
                case 3:
                    bool result = BinaryTree.SearchKey(63);
                    Console.WriteLine(result);
                    break;

            }


        }
    }
}