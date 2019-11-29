using System;
using System.Collections.Generic;
using TreeIntersection.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> eaxampleOneTreeOne = new BinaryTree<int>(150);
            eaxampleOneTreeOne.Root.LeftChild = new Node<int>(100);
            eaxampleOneTreeOne.Root.LeftChild.LeftChild = new Node<int>(75);
            eaxampleOneTreeOne.Root.LeftChild.RightChild = new Node<int>(160);
            eaxampleOneTreeOne.Root.LeftChild.RightChild.LeftChild = new Node<int>(125);
            eaxampleOneTreeOne.Root.LeftChild.RightChild.RightChild = new Node<int>(175);
            eaxampleOneTreeOne.Root.RightChild = new Node<int>(250);
            eaxampleOneTreeOne.Root.RightChild.LeftChild = new Node<int>(200);
            eaxampleOneTreeOne.Root.RightChild.RightChild = new Node<int>(350);
            eaxampleOneTreeOne.Root.RightChild.RightChild.LeftChild = new Node<int>(300);
            eaxampleOneTreeOne.Root.RightChild.RightChild.RightChild = new Node<int>(500);

            BinaryTree<int> exampleOneTreeTwo = new BinaryTree<int>(42);
            exampleOneTreeTwo.Root.LeftChild = new Node<int>(100);
            exampleOneTreeTwo.Root.LeftChild.LeftChild = new Node<int>(15);
            exampleOneTreeTwo.Root.LeftChild.RightChild = new Node<int>(160);
            exampleOneTreeTwo.Root.LeftChild.RightChild.LeftChild = new Node<int>(125);
            exampleOneTreeTwo.Root.LeftChild.RightChild.RightChild = new Node<int>(175);
            exampleOneTreeTwo.Root.RightChild = new Node<int>(600);
            exampleOneTreeTwo.Root.RightChild.LeftChild = new Node<int>(200);
            exampleOneTreeTwo.Root.RightChild.RightChild = new Node<int>(350);
            exampleOneTreeTwo.Root.RightChild.RightChild.LeftChild = new Node<int>(4);
            exampleOneTreeTwo.Root.RightChild.RightChild.RightChild = new Node<int>(500);

            List<int> exampleOne = TreeIntersection(eaxampleOneTreeOne, exampleOneTreeTwo);
            Console.WriteLine($"[{string.Join(",", exampleOne)}]");
        }

        public static List<int> TreeIntersection(BinaryTree<int> treeOne, BinaryTree<int> treeTwo)
        {
            List<int> list = new List<int>();
            TreeIntersection(treeOne.Root, treeTwo.Root, list);
            return list;
        }

        static void TreeIntersection(Node<int> nodeOne, Node<int> nodeTwo, List<int> list)
        {
            if (nodeOne.Value == nodeTwo.Value)
            {
                list.Add(nodeTwo.Value);
            }
            if (nodeOne.LeftChild != null || nodeTwo.LeftChild != null)
            {
                TreeIntersection(nodeOne.LeftChild, nodeTwo.LeftChild, list);
            }
            if (nodeOne.RightChild != null || nodeTwo.RightChild != null)
            {
                TreeIntersection(nodeOne.RightChild, nodeTwo.RightChild, list);
            }
        }
    }
}
