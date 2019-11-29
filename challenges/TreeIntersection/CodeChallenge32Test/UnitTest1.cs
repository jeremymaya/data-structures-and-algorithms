using System;
using System.Collections.Generic;
using TreeIntersection.Classes;
using Xunit;
using TreeIntersection;

namespace CodeChallenge32Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanCompareSameOneNode()
        {
            BinaryTree<int> testOneTreeOne = new BinaryTree<int>(150);
            BinaryTree<int> testOneTreeTwo = new BinaryTree<int>(150);
            List<int> exampleOne = Program.TreeIntersection(testOneTreeOne, testOneTreeTwo);

            Assert.Equal("[150]", $"[{string.Join(",", exampleOne)}]");
        }

        [Fact]
        public void CanCompareDifferentOneNode()
        {
            BinaryTree<int> testOneTreeOne = new BinaryTree<int>(150);
            BinaryTree<int> testOneTreeTwo = new BinaryTree<int>(100);
            List<int> exampleOne = Program.TreeIntersection(testOneTreeOne, testOneTreeTwo);

            Assert.NotEqual("[150]", $"[{string.Join(",", exampleOne)}]");
        }

        [Fact]
        public void CanCompareProvidedExample()
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

            List<int> exampleOne = Program.TreeIntersection(eaxampleOneTreeOne, exampleOneTreeTwo);

            Assert.Equal("[100,160,125,175,200,350,500]", $"[{string.Join(",", exampleOne)}]");
        }

        [Fact]
        public void CanCompareDifferentTreeSize()
        {
            BinaryTree<int> exampleTwoTreeOne = new BinaryTree<int>(150);
            exampleTwoTreeOne.Root.LeftChild = new Node<int>(100);
            exampleTwoTreeOne.Root.LeftChild.LeftChild = new Node<int>(160);
            exampleTwoTreeOne.Root.LeftChild.RightChild = new Node<int>(75);
            exampleTwoTreeOne.Root.RightChild = new Node<int>(250);
            exampleTwoTreeOne.Root.RightChild.LeftChild = new Node<int>(350);

            BinaryTree<int> exampleTwoTreeTwo = new BinaryTree<int>(42);
            exampleTwoTreeTwo.Root.LeftChild = new Node<int>(75);
            exampleTwoTreeTwo.Root.LeftChild.LeftChild = new Node<int>(250);
            exampleTwoTreeTwo.Root.LeftChild.RightChild = new Node<int>(350);
            exampleTwoTreeTwo.Root.RightChild = new Node<int>(100);
            exampleTwoTreeTwo.Root.RightChild.RightChild = new Node<int>(150);

            List<int> exampleTwo = Program.TreeIntersection(exampleTwoTreeOne, exampleTwoTreeTwo);

            Assert.Equal("[150,100,75,250,350]", $"[{string.Join(",", exampleTwo)}]");
        }
    }
}
