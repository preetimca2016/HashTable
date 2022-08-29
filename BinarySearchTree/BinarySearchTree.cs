using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeNameSpace
{
    public class BinarySearchTree<k> where k : IComparable
    {
        public BinarySearchTreeNode<k> Root;

        public void AddNode(k key)
        {
            Root = AddRecursively(Root, key);
        }
        public k GetRoot { get { return Root.key; } }   
        public k getRootLeft { get { return Root.Left.key; } }
        public k getRootRight { get { return Root.Right.key; } }
        private BinarySearchTreeNode<k> AddRecursively(BinarySearchTreeNode<k> Current, k key)
        {
            if (Current == null)    
                return new BinarySearchTreeNode<k>(key);
            int CompareResult = key.CompareTo(Current.key);
            if (CompareResult == 0)
                return Current;
            if (CompareResult < 1)
                Current.Left = AddRecursively(Current.Left, key);
            else
                Current.Right = AddRecursively(Current.Right, key); 
            return Current;
        }
        public int GetSize()
        {
            return this.getSizeRecursively(Root);
        }
        private int getSizeRecursively(BinarySearchTreeNode<k> Current)
        {
            return Current == null ? 0 : 1 + this.getSizeRecursively(Current.Left) + this.getSizeRecursively(Current.Right);
        }
        public bool SearchKey(k key)
        {
            return SearchRecursively(Root, key);
        }
        private bool SearchRecursively(BinarySearchTreeNode<k> Current, k key)
        {
            if (Current == null)
                return false;
            if (Current.key.CompareTo(key) == 0)
                return true;
            else
                return SearchRecursively(Current.Left, key) || SearchRecursively(Current.Right, key);
        }

    }
}
