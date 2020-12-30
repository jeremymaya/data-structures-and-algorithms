using System;
using System.Collections.Generic;

namespace Trees
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
        }

        public BinaryTree(T value)
        {
            Root = new Node<T>(value);
        }

        public List<T> PreOrder(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            List<T> values = new List<T>();
            PreOrder(root, values);
            return values;
        }

        private void PreOrder(Node<T> root, List<T> values)
        {
            if (root == null)
                return;
            
            values.Add(root.Value);
            PreOrder(root.Left, values);
            PreOrder(root.Right, values);
        }

        public List<T> InOrder(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            List<T> values = new List<T>();
            InOrder(root, values);
            return values;            
        }

        private void InOrder(Node<T> root, List<T> values)
        {
            if (root == null)
                return;
            
            InOrder(root.Left, values);
            values.Add(root.Value);
            InOrder(root.Right, values);
        }


        public List<T> PostOrder(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            List<T> values = new List<T>();
            PostOrder(root, values);
            return values;            
        }

        private void PostOrder(Node<T> root, List<T> values)
        {
            if (root == null)
                return;
            
            PostOrder(root.Left, values);
            PostOrder(root.Right, values);
            values.Add(root.Value);
        }

        public List<T> BreadthFirst(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            List<List<T>> values = new List<List<T>>();
            BreadthFirst(root, values, 0);
            return MergeLists(values);
        }

        private void BreadthFirst(Node<T> node, List<List<T>> values, int level)
        {
            if (node == null)
                return;

            if (values.Count == level)
                values.Add(new List<T>());

            values[level].Add(node.Value);

            BreadthFirst(node.Left, values, level + 1);
            BreadthFirst(node.Right, values, level + 1);
        }

        private List<T> MergeLists(List<List<T>> values)
        {
            List<T> merged = new List<T>();

            foreach (List<T> list in values)
                foreach (T item in list)
                    merged.Add(item);

            return merged;
        }
    }
}
