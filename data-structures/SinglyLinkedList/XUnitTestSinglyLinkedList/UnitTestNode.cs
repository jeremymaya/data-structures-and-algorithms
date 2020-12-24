using Xunit;
using SinglyLinkedList;

namespace XUnitTestSinglyLinkedList
{
    public class UnitTestNode
    {
        [Fact]
        public void CanInstantiateNodeWithInt()
        {
            int expected = 0;
            Node<int> node = new Node<int>(expected);
            var actual = node.Value;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInstantiateNodeWithChar()
        {
            char expected = 'a';
            Node<char> node = new Node<char>(expected);
            var actual = node.Value;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInstantiateNodeWithString()
        {
            string expected = "hello";
            Node<string> node = new Node<string>(expected);
            var actual = node.Value;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInstantiateNodeWithArr()
        {
            int[] expected = new int[] { };
            Node<int[]> node = new Node<int[]>(expected);
            var actual = node.Value;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NextIsNull()
        {
            Node<int> node = new Node<int>(0);
            var actual = node.Next;

            Assert.Null(actual);
        }
    }
}
