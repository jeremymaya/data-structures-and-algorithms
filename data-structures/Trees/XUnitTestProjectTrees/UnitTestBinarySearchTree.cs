using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace XUnitTestProjectTrees
{
    public class UnitTestBinarySearchTree
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyTree()
        {
            BinarySearchTree<char> binarySearchTree = new BinarySearchTree<char>();

            Assert.NotNull(binarySearchTree);
        }

        [Fact]
        public void CanSuccessfullyInstantiateATreeWithASingleRoot()
        {
            BinarySearchTree<string> binarySearchTree = new BinarySearchTree<string>("test");

            Assert.NotNull(binarySearchTree);
            Assert.Equal("test", binarySearchTree.Root.Value);
        }

        [Fact]
        public void CanSuccessfullyAddALeftChildAndRightchildToASingleRootNode()
        {
            BinarySearchTree<char> binarySearchTree = new BinarySearchTree<char>();

            binarySearchTree.Root = new Node<char>('a');
            binarySearchTree.Root.Left = new Node<char>('b');
            binarySearchTree.Root.Right = new Node<char>('c');

            Assert.Equal('a', binarySearchTree.Root.Value);
            Assert.Equal('b', binarySearchTree.Root.Left.Value);
            Assert.Equal('c', binarySearchTree.Root.Right.Value);
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPreorderTraversal()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>
            {
                Root = new Node<int>(1)
                {
                    Left = new Node<int>(2),
                    Right = new Node<int>(3)
                }
            };

            Assert.Equal(new List<int> { 1, 2, 3 }, binarySearchTree.PreOrder(binarySearchTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAnInorderTraversal()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>
            {
                Root = new Node<int>(1)
                {
                    Left = new Node<int>(2),
                    Right = new Node<int>(3)
                }
            };

            Assert.Equal(new List<int> { 2, 1, 3 }, binarySearchTree.InOrder(binarySearchTree.Root));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromAPostorderTraversal()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>
            {
                Root = new Node<int>(1)
                {
                    Left = new Node<int>(2),
                    Right = new Node<int>(3)
                }
            };

            Assert.Equal(new List<int> { 2, 3, 1 }, binarySearchTree.PostOrder(binarySearchTree.Root));
        }
        
        [Fact]
        public void CanSuccessfullyAddValuesToATree()
        {
            BinarySearchTree<char> binarySearchTree = new BinarySearchTree<char>();

            binarySearchTree.Add('a');
            binarySearchTree.Add('b');
            binarySearchTree.Add('c');

            Assert.Equal('a', binarySearchTree.Root.Value);
            Assert.Equal('b', binarySearchTree.Root.Right.Value);
            Assert.Equal('c', binarySearchTree.Root.Right.Right.Value);
        }

        [Fact]
        public void ThrowsAnExceptionWhenDuplicateValuesIsAddedToATree()
        {
            BinarySearchTree<char> binarySearchTree = new BinarySearchTree<char>();

            binarySearchTree.Add('a');
            binarySearchTree.Add('b');
            binarySearchTree.Add('c');

            var expected = Assert.Throws<Exception>(() => binarySearchTree.Add('a'));

            Assert.Equal("The value is already present in the tree.", expected.Message);
        }

        [Fact]
        public void CanSuccessfullyCheckIfTheTreeContainsAValue()
        {
            BinarySearchTree<char> binarySearchTree = new BinarySearchTree<char>();

            binarySearchTree.Add('a');
            binarySearchTree.Add('b');
            binarySearchTree.Add('c');

            Assert.True(binarySearchTree.Contains('a'));
            Assert.True(binarySearchTree.Contains('b'));
            Assert.True(binarySearchTree.Contains('c'));
            Assert.False(binarySearchTree.Contains('d'));
        }

        [Fact]
        public void CanSuccessfullyReturnACollectionFromABreadthFirstTraversal()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>
            {
                Root = new Node<int>(2)
                {
                    Left = new Node<int>(7),
                    Right = new Node<int>(5)
                }
            };

            binarySearchTree.Root.Left.Left = new Node<int>(2);
            binarySearchTree.Root.Left.Right = new Node<int>(6);
            binarySearchTree.Root.Left.Right.Left = new Node<int>(5);
            binarySearchTree.Root.Left.Right.Right = new Node<int>(11);

            binarySearchTree.Root.Right.Right = new Node<int>(9);
            binarySearchTree.Root.Right.Right.Left = new Node<int>(4);

            Assert.Equal(new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 }, binarySearchTree.BreadthFirst(binarySearchTree.Root));
        }
    }
}
