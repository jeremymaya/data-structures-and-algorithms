using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace XUnitTestProjectTrees
{
    public class UnitTestBinaryTree
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyTree()
        {
            BinaryTree<char> binaryTree = new BinaryTree<char>();

            Assert.NotNull(binaryTree);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithASingleRoot()
        {
            BinaryTree<string> binaryTree = new BinaryTree<string>("test");

            Assert.NotNull(binaryTree);
            Assert.Equal("test", binaryTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddALeftChildAndRightchildToASingleRootNode()
        {
            BinaryTree<char> binaryTree = new BinaryTree<char>();

            binaryTree.Root = new Node<char>('a');
            binaryTree.Root.Left = new Node<char>('b');
            binaryTree.Root.Right = new Node<char>('c');

            Assert.Equal('a', binaryTree.Root.Value);
            Assert.Equal('b', binaryTree.Root.Left.Value);
            Assert.Equal('c', binaryTree.Root.Right.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPreorderTraversal()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>
            {
                Root = new Node<int>(1)
                {
                    Left = new Node<int>(2),
                    Right = new Node<int>(3)
                }
            };

            Assert.Equal(new List<int> { 1, 2, 3 }, binaryTree.PreOrder(binaryTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAnInorderTraversal()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>
            {
                Root = new Node<int>(1)
                {
                    Left = new Node<int>(2),
                    Right = new Node<int>(3)
                }
            };

            Assert.Equal(new List<int> { 2, 1, 3 }, binaryTree.InOrder(binaryTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPostorderTraversal()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>
            {
                Root = new Node<int>(1)
                {
                    Left = new Node<int>(2),
                    Right = new Node<int>(3)
                }
            };

            Assert.Equal(new List<int> { 2, 3, 1 }, binaryTree.PostOrder(binaryTree.Root));
        }
    }
}
