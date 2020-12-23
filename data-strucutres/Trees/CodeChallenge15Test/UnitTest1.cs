using System;
using System.Collections.Generic;
using Trees.Classes;
using Xunit;

namespace CodeChallenge15Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyTree()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();

            Assert.Null(testTree.Root);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithASingleRootNode()
        {
            BinaryTree<int> testTree = new BinaryTree<int>(1);

            Assert.Equal(1, testTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddALeftChildAndRightChildToASingleRootNode()
        {
            BinaryTree<int> testTree = new BinaryTree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(2, testTree.Root.LeftChild.Value);
            Assert.Equal(3, testTree.Root.RightChild.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPreorderTraversal()
        {
            BinaryTree<int> testTree = new BinaryTree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(new List<int> { 1, 2, 3 }, testTree.PreOrder(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAnInorderTraversal()
        {
            BinaryTree<int> testTree = new BinaryTree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(new List<int> { 2, 1, 3 }, testTree.InOrder(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPostorderTraversal()
        {
            BinaryTree<int> testTree = new BinaryTree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(new List<int> { 2, 3, 1 }, testTree.PostOrder(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromABreadthFirstTraversal()
        {
            BinaryTree<int> testTree = new BinaryTree<int>(2);

            testTree.Root.LeftChild = new Node<int>(7);
            testTree.Root.LeftChild.LeftChild = new Node<int>(2);
            testTree.Root.LeftChild.RightChild = new Node<int>(6);
            testTree.Root.LeftChild.RightChild.LeftChild = new Node<int>(5);
            testTree.Root.LeftChild.RightChild.RightChild = new Node<int>(11);

            testTree.Root.RightChild = new Node<int>(5);
            testTree.Root.RightChild.RightChild = new Node<int>(9);
            testTree.Root.RightChild.RightChild.LeftChild = new Node<int>(4);

            Assert.Equal(new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 }, testTree.BreadthFirst(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyBinarySearchTree()
        {
            BinarySearchTree testTree = new BinarySearchTree();

            Assert.Null(testTree.Root);
        }

        [Fact]
        public void CanSuccessfullyInstantiateABinarySearchTreeWithASingleRootNode()
        {
            BinarySearchTree testTree = new BinarySearchTree(10);

            Assert.Equal(10, testTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddAValuesToBinarySearchTree()
        {
            BinarySearchTree testTree = new BinarySearchTree(10);
            testTree.Add(testTree.Root, 5);
            testTree.Add(testTree.Root, 15);
            testTree.Add(testTree.Root, 3);
            testTree.Add(testTree.Root, 6);

            Assert.Equal(6, testTree.Root.LeftChild.RightChild.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnTrueWhenTheValuesIsInBinarySearchTree()
        {
            BinarySearchTree testTree = new BinarySearchTree(10);
            testTree.Add(testTree.Root, 5);
            testTree.Add(testTree.Root, 15);
            testTree.Add(testTree.Root, 3);
            testTree.Add(testTree.Root, 6);

            Assert.True(testTree.Contains(testTree.Root, 3));
        }

        [Fact]
        public void CanSuccessfullyReturnFalseWhenTheValuesIsNotInBinarySearchTree()
        {
            BinarySearchTree testTree = new BinarySearchTree(10);
            testTree.Add(testTree.Root, 5);
            testTree.Add(testTree.Root, 15);
            testTree.Add(testTree.Root, 3);
            testTree.Add(testTree.Root, 6);

            Assert.False(testTree.Contains(testTree.Root, 1));
        }
    }
}
