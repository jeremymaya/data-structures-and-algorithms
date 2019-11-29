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

            BinaryTree<int> exampleTwoTreeOne = new BinaryTree<int>(150);
            exampleTwoTreeOne.Root.LeftChild = new Node<int>(100);
            exampleTwoTreeOne.Root.LeftChild.LeftChild = new Node<int>(160);
            exampleTwoTreeOne.Root.LeftChild.RightChild = new Node<int>(75);
            exampleTwoTreeOne.Root.RightChild = new Node<int>(250);
            exampleTwoTreeOne.Root.RightChild.LeftChild = new Node<int>(350);

            BinaryTree<int> exampleTwoTreeTwo = new BinaryTree<int>(42);
            exampleTwoTreeTwo.Root.LeftChild = new Node<int>(75);
            exampleTwoTreeTwo.Root.LeftChild.LeftChild = new Node<int>(250);
            exampleTwoTreeTwo.Root.LeftChild.RightChild= new Node<int>(350);
            exampleTwoTreeTwo.Root.RightChild = new Node<int>(100);
            exampleTwoTreeTwo.Root.RightChild.RightChild = new Node<int>(150);

            List<int> exampleOne = TreeIntersection(eaxampleOneTreeOne, exampleOneTreeTwo);
            Console.WriteLine($"[{string.Join(",", exampleOne)}]");

            List<int> exampleTwo = TreeIntersection(exampleTwoTreeOne, exampleTwoTreeTwo);
            Console.WriteLine($"[{string.Join(",", exampleTwo)}]");
        }

        /// <summary>
        /// A method that calls a recusrive method to iterate through the two trees and compares values to return the matching values only
        /// </summary>
        /// <param name="treeOne"></param>
        /// <param name="treeTwo"></param>
        /// <returns></returns>
        public static List<int> TreeIntersection(BinaryTree<int> treeOne, BinaryTree<int> treeTwo)
        {
            List<int> listOne = new List<int>();
            TreeIntersection(treeOne.Root, listOne);
            List<int> listTwo = new List<int>();
            TreeIntersection(treeTwo.Root, listTwo);

            int outer;
            int inner;

            if (listOne.Count > listTwo.Count)
            {
                outer = listOne.Count;
                inner = listTwo.Count;
            }
            else
            {
                outer = listTwo.Count;
                inner = listOne.Count;
            }


            List<int> listThree = new List<int>();
            for (int i = 0; i < outer; i++)
            {
                for (int j = 0; j < inner; j++)
                {
                    if (listOne[i] == listTwo[j])
                    {
                        listThree.Add(listOne[i]);
                    }
                }
            }

            return listThree ;
        }

        /// <summary>
        /// Resursive method that iterates through a tree in PreOrder
        /// </summary>
        /// <param name="node">Root node</param>
        /// <param name="list">List to hold the node value</param>
        static void TreeIntersection(Node<int> node, List<int> list)
        {
            list.Add(node.Value);
            if (node.LeftChild != null)
            {
                TreeIntersection(node.LeftChild, list);
            }
            if (node.RightChild != null)
            {
                TreeIntersection(node.RightChild, list);
            }
        }
    }
}
