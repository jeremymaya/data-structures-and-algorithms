using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<object> tree = new BinaryTree<object>(1);

            tree.Root.LeftChild = new Node<object>(2);
            tree.Root.LeftChild.LeftChild = new Node<object>(4);
            tree.Root.LeftChild.RightChild = new Node<object>(5);

            tree.Root.RightChild = new Node<object>(3);
            tree.Root.RightChild.LeftChild = new Node<object>(6);
            tree.Root.RightChild.RightChild = new Node<object>(7);

            Console.WriteLine(String.Join(", ", tree.BreadthFirst(tree.Root)));

            BinaryTree<object> treeNew = FizzBuzz(tree);

            Console.WriteLine(String.Join(", ", treeNew.BreadthFirst(treeNew.Root)));


        }

        static BinaryTree<object> FizzBuzz(BinaryTree<object> tree)
        {
            Node<object> node = tree.Root;

            FizzBuzz(tree, node);

            return tree;
        }

        private static void FizzBuzz(BinaryTree<object> tree, Node<object> node)
        {
            if (Convert.ToInt32(node.Value) % 3 == 0)
            {
                node.Value = "Fizz";
            }

            if (node.LeftChild != null)
            {
                FizzBuzz(tree, node.LeftChild);
            }

            if (node.RightChild != null)
            {
                FizzBuzz(tree, node.RightChild);
            }
        }
    }
}
