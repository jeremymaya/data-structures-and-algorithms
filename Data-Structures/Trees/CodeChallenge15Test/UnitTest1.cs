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
            Tree<int> testTree = new Tree<int>();

            Assert.Null(testTree.Root);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithASingleRootNode()
        {
            Tree<int> testTree = new Tree<int>(1);

            Assert.Equal(1, testTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddALeftChildAndRightChildToASingleRootNode()
        {
            Tree<int> testTree = new Tree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(2, testTree.Root.LeftChild.Value);
            Assert.Equal(3, testTree.Root.RightChild.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPreorderTraversal()
        {
            Tree<int> testTree = new Tree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(new List<int> { 1, 2, 3 }, testTree.PreOrder(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAnInorderTraversal()
        {
            Tree<int> testTree = new Tree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(new List<int> { 2, 1, 3 }, testTree.InOrder(testTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPostorderTraversal()
        {
            Tree<int> testTree = new Tree<int>(1);
            testTree.Root.LeftChild = new Node<int>(2);
            testTree.Root.RightChild = new Node<int>(3);

            Assert.Equal(new List<int> { 2, 3, 1 }, testTree.PostOrder(testTree.Root));
        }
    }
}
