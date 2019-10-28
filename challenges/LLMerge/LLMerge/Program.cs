using System;
using System.Collections.Generic;
using LLMerge.Classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList ExampleOneListOne = new LinkedList();
            ExampleOneListOne.Append(1);
            ExampleOneListOne.Append(3);
            ExampleOneListOne.Append(2);

            LinkedList ExampOneListTwo = new LinkedList();
            ExampOneListTwo.Append(5);
            ExampOneListTwo.Append(9);
            ExampOneListTwo.Append(4);

            //var exampleOne = ExampleOneListOne.MergeLists(ExampleOneListOne, ExampOneListTwo);

            LinkedList ExampleTwoListOne = new LinkedList();
            ExampleTwoListOne.Append(1);
            ExampleTwoListOne.Append(3);

            LinkedList ExampleTwoListTwo = new LinkedList();
            ExampleTwoListTwo.Append(5);
            ExampleTwoListTwo.Append(9);
            ExampleTwoListTwo.Append(4);

            var exampleTwo = ExampleTwoListOne.MergeLists(ExampleTwoListOne, ExampleTwoListTwo) ;

            LinkedList ExampleThreeListOne = new LinkedList();
            ExampleThreeListOne.Append(1);
            ExampleThreeListOne.Append(3);
            ExampleThreeListOne.Append(2);

            LinkedList ExampleThreeListTwo = new LinkedList();
            ExampleThreeListTwo.Append(5);
            ExampleThreeListTwo.Append(9);
            ExampleThreeListTwo.Append(4);
        }
    }
}
