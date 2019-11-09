using System;
using System.Collections.Generic;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool MultiHBracketValidation(string input)
        {
            var bracketsOpening = new List<string>();
            var bracketsClosing = new List<string>();

            bool balanced = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "{" ||
                    input[i].ToString() == "(" ||
                    input[i].ToString() == "[")
                {
                    bracketsOpening.Add(input[i].ToString());
                }
                else if (input[i].ToString() == "}" ||
                        input[i].ToString() == ")" ||
                        input[i].ToString() == "]")
                {
                    bracketsClosing.Add(input[i].ToString());
                }
            }

            if (bracketsOpening.Count == bracketsClosing.Count)
            {
                for (int i = 0; i < bracketsOpening.Count; i++)
                {
                    if (bracketsOpening[i] == "{" && bracketsClosing[i] == "}")
                    {
                        balanced = true;
                    }
                    else if (bracketsOpening[i] == "(" && bracketsClosing[i] == ")")
                    {
                        balanced = true;
                    }
                    else if (bracketsOpening[i] == "[" && bracketsClosing[i] == "]")
                    {
                        balanced = true;
                    }
                }
                if (input.Contains("{)") ||
                    input.Contains("{]") ||
                    input.Contains("(}") ||
                    input.Contains("(]") ||
                    input.Contains("[}") ||
                    input.Contains("[)"))
                {
                    balanced = false;
                }
            }

            return balanced;
        }
    }
}
