using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection.Classes
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        /// <summary>
        /// Constructor method that creates a BinaryTree object with a root node
        /// </summary>
        /// <param name="value"></param>
        public BinaryTree(T value)
        {
            Root = new Node<T>(value);
        }

        /// <summary>
        /// Contructor method that creates an empty BinarySearchTree object
        /// </summary>
        public BinaryTree()
        {

        }
    }
}
