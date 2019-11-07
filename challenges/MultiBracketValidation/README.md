# Code Challenge 13 Multi Bracket Validation

## Multi Bracket Validation
*Author: Kyungrae Kim*

---

### Problem Domain
Write a function called public static bool MultiBracketValidation(string input). This function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:
* Round Brackets : ()
* Square Brackets : []
* Curly Brackets : {}

---

### Inputs and Expected Outputs

| Input | Expected Output |
| :----------- | :----------- |
| \{\} | True |
| \{\}()\{\}| True|
| ()[[Extra Characters]] | True |
| ()\{\}[[]] | True |
| \{\}\{Code\}\[Fellows\](()) | True |
| [(\{\}] | False |
| (]( | False|
| {(}) | False|

---

### Approach

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| MultiBracketValidation(string input) | O(n) | O(1) |

---

### Solution
```C#
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
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/MultiBracketValidation/MultiBracketValidation/Program.cs

---

### Whiteboard Visual
![multi-bracket-validation](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/multi-bracket-validation.jpg)

---

### Change Log
1.0: *Code Challenge 13 Completed, Initial submission* - 31 Oct 2019  
