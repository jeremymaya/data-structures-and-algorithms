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
            if (node == null)
            {
                return new Node<int>(value);
            }
            else if (node.Value > value)
            {
                node.LeftChild = Add(node.LeftChild, value);
            }
            else if (node.Value < value)
            {
                node.RightChild = Add(node.RightChild, value);
            }

            return node;
        }

        public bool Contains(Node<int> node, int value)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.Value == value)
            {
                return true;
            }
            else if (node.Value > value)
            {
                return Contains(node.LeftChild, value);
            }
            else if (node.Value < value)
            {
                return Contains(node.RightChild, value);
            }

            return false;
        }
    }
}
