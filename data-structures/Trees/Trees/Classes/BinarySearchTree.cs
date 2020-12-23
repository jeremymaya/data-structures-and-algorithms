using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {

        public Node<int> Root { get; set; }

        /// <summary>
        /// Constructor method that creates a BinarySearchTree object with a root node
        /// </summary>
        /// <param name="value"></param>
        public BinarySearchTree(int value)
        {
            Root = new Node<int>(value);
        }

        /// <summary>
        /// Contructor method that creates an empty BinarySearchTree object
        /// </summary>
        public BinarySearchTree()
        {

        }

        /// <summary>
        /// A recursive method that:
        /// 1. If BinarySearchTree instance is empty, creates a new node
        /// 2. If the parameter value is less than the value of a node, invoke Add method again from the LeftChild node
        /// 3. If the parameter value is less than the value of a node, invoke Add method again from the RightChild node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// A recursive method that:
        /// 1. If BinarySearchTree instance is empty, return false
        /// 2. If the parameter value is less than the value of a node, invoke Contains method again and return a result
        /// 3. If the parameter value is less than the value of a node, invoke Contains method again and return a result
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
