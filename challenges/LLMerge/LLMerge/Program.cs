using System;
using System.Collections.Generic;
using LLMerge.Classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList listOne = new LinkedList();
            listOne.Append(1);
            listOne.Append(3);
            listOne.Append(2);

            LinkedList listTwo = new LinkedList();
            listTwo.Append(5);
            listTwo.Append(9);
            listTwo.Append(4);

            var test = listOne.MergeLists(listOne, listTwo);
            Console.WriteLine(test.Value);
            Console.WriteLine(test.Next.Value);
            Console.WriteLine(test.Next.Next.Value);
        }
    }
}
