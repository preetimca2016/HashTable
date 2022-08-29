using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeNameSpace
{
    public class BinarySearchTreeNode<K>
    {
        public K key;
        public BinarySearchTreeNode<K> Right;
        public BinarySearchTreeNode<K> Left;
        public BinarySearchTreeNode(K key)
        {
            this.key = key;
            Right = null;
            Left = null;
        }
    }
}
