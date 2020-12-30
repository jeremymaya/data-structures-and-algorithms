using System;
using System.Collections.Generic;

namespace Trees
{
    public class BinarySearchTree<T>
    {
        private HashSet<T> Values { get; set; }
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        {
            Values = new HashSet<T>();
        }

        public BinarySearchTree(T value)
        {
            Values = new HashSet<T> { value };
            Root = new Node<T>(value);
        }

        public void Add(T value)
        {
            if (Contains(value))
                throw new Exception("The value is already present in the tree.");
            else
                Values.Add(value);

            Node<T> parent = Root;
            Node<T> child= Root;

            while (parent != null)
            {
                child = parent;
                parent = Comparer<T>.Default.Compare(value, parent.Value) < 0 ? parent.Left : parent.Right;
            }

            if (Root == null)
                Root = new Node<T>(value);
            else if (Comparer<T>.Default.Compare(value, child.Value) < 0)
                child.Left= new Node<T>(value);
            else
                child.Right = new Node<T>(value);
        }

        public bool Contains(T value)
        {
            if (Values.Contains(value))
                return true;

            return false;
        }

        public List<T> PreOrder(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            Stack<Node<T>> stack = new Stack<Node<T>>();
            List<T> values = new List<T>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                Node<T> current = stack.Pop();
                values.Add(current.Value);

                if (current.Right != null)
                    stack.Push(current.Right);

                if (current.Left != null)
                    stack.Push(current.Left);
            }

            return values;
        }

        public List<T> InOrder(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            Stack<Node<T>> stack = new Stack<Node<T>>();
            List<T> values = new List<T>();

            Node<T> current = root;

            while (current != null || stack.Count != 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                current = stack.Pop();
                values.Add(current.Value);
                current = current.Right;
            }

            return values;
        }

        public List<T> PostOrder(Node<T> root)
        {
            if (root == null)
                return new List<T>();

            Stack<Node<T>> stack = new Stack<Node<T>>();
            List<T> values = new List<T>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                Node<T> current = stack.Pop();
                values.Insert(0, current.Value);

                if (current.Left != null)
                    stack.Push(current.Left);

                if (current.Right != null)
                    stack.Push(current.Right);
            }

            return values;
        }
    }
}
