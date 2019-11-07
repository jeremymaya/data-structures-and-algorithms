﻿using System;
using System.Collections.Generic;

namespace Trees.Classes
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        public Tree()
        {

        }

        ///
        public List<T> PreOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            PreOrder(node, traversal);

            return traversal;
        }

        private void PreOrder(Node<T> node, List<T> traversal)
        {
            traversal.Add(node.Value);

            if(node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }

        public List<T> InOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            InOrder(node, traversal);

            return traversal;
        }

        private void InOrder(Node<T> node, List<T> traversal)
        {
            if(node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }

            traversal.Add(node.Value);

            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }
        }

        public List<T> PostOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            PostOrder(node, traversal);

            return traversal;
        }

        private void PostOrder(Node<T> node, List<T> traversal)
        {
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }

            traversal.Add(node.Value);
        }
    }
}