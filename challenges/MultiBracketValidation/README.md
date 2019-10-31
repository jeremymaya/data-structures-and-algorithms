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
1. Set a search range:
    1. left = 0
	2. right = length of the array - 1
2. Find the middle index
3. Compare the search key against a value of at the middle index
	1. If the value == search key, return the middle index value
	2. If the value < search key, right = middle index value - 1 and repeat from step 2
	3. If the value > search key, left = middle index value + 1 and repeat from step 2

---

### Efficiency
N/A

---

### Solution
```C#
public static int SearchBinary(int[] arr, int num)
{
    int left = 0;
    int right = arr.Length - 1;
    int index = -1;
    while(left <= right)
    {
        int mid = (left + right) / 2;
        Console.WriteLine(mid);
        if (arr[mid] == num)
        {
            index = mid;
            right = -1;
        }
        else if (arr[mid] > num)
        {
            right = mid - 1;
        }
        else if (arr[mid] < num)
        {
            left = mid + 1;
        }
    }
    return index;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/SearchBinary/SearchBinary/Program.cs

---

### Whiteboard Visual
![array-binary-search](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/array-binary-search.jpg)

---

### Change Log
1.0: *Code Challenge 03 Completed, Initial submission* - 18 Oct 2019  
