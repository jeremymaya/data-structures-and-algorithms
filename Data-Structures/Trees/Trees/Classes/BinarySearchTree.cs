using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {

        public Node<int> Root { get; set; }

        public BinarySearchTree(int value)
        {
            Root = new Node<int>(value);
        }

        public BinarySearchTree()
        {

        }

        public Node<int> Add(Node<int> node, int value)
        {
            if(node == null)
            {
                return new Node<int>(value);
            }

            if (value < node.Value)
            {
                node.LeftChild = Add(node.LeftChild, value);
            } else if (value > node.Value)
            {
                node.RightChild = Add(node.RightChild, value);
            }

            return node;
        }

        public void Conntains()
        {

        }
    }
}
