using System;
using System.Collections.Generic;
using Xunit;
using FizzBuzzTree;
using FizzBuzzTree.Classes;

namespace CodeChallenge16Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyTree()
        {
            BinaryTree<object> testTree = new BinaryTree<object>();

            Assert.Null(testTree.Root);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithASingleRootNode()
        {
            BinaryTree<object> testTree = new BinaryTree<object>(1);

            Assert.Equal(1, testTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithAString()
        {
            BinaryTree<object> testTree = new BinaryTree<object>("Fizz");

            Assert.Equal("Fizz", testTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddALeftChildAndRightChildToASingleRootNode()
        {
            BinaryTree<object> testTree = new BinaryTree<object>(1);
            testTree.Root.LeftChild = new Node<object>(2);
            testTree.Root.RightChild = new Node<object>(3);

            Assert.Equal(2, testTree.Root.LeftChild.Value);
            Assert.Equal(3, testTree.Root.RightChild.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromABreadthFirstTraversal()
        {
            BinaryTree<object> testTree = new BinaryTree<object>(1);

            testTree.Root.LeftChild = new Node<object>(2);
            testTree.Root.LeftChild.LeftChild = new Node<object>(4);
            testTree.Root.LeftChild.RightChild = new Node<object>(15);

            testTree.Root.RightChild = new Node<object>(3);
            testTree.Root.RightChild.LeftChild = new Node<object>(6);
            testTree.Root.RightChild.RightChild = new Node<object>(5);

            Assert.Equal(new List<object> { 1, 2, 3, 4, 15, 6, 5 }, testTree.BreadthFirst(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnANewFizzBuzzTree()
        {
            BinaryTree<object> testTree = new BinaryTree<object>(1);

            testTree.Root.LeftChild = new Node<object>(2);
            testTree.Root.LeftChild.LeftChild = new Node<object>(4);
            testTree.Root.LeftChild.RightChild = new Node<object>(15);

            testTree.Root.RightChild = new Node<object>(3);
            testTree.Root.RightChild.LeftChild = new Node<object>(6);
            testTree.Root.RightChild.RightChild = new Node<object>(5);

            BinaryTree<object> fizzBuzzTestTree = Program.FizzBuzzTree(testTree);

            Assert.Equal(new List<object> { 1, 2, "Fizz", 4, "FizzBuzz", "Fizz", "Buzz" }, fizzBuzzTestTree.BreadthFirst(fizzBuzzTestTree.Root));
        }
    }
}
