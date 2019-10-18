# Code Challenge 03 Array Search Binary

## Array Search Binary
*Author: Kyungrae Kim*

---

### Problem Domain
Write a function called 'BinarySearch' which takes in 2 parameters: a sorted array and the search key. Return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

---

### Inputs and Expected Outputs

| Input | Expected Output |
| :----------- | :----------- |
| [4, 8, 15, 16, 23, 42], 4 | 0 |
| [11, 22, 33, 44, 55, 66, 77], 90 | -1 |
| [4], 4 | 0 |
| [4, 4], 4 | 0 |
| [ ], 4 | -1 |

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
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/array-shift/challenges/SearchBinary/SearchBinary/Program.cs

---

### Whiteboard Visual
![array-binary-search](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/array-shift/assets/array-shift.jpg)

---

### Change Log
1.0: *Code Challenge 03 Completed, Initial submission* - 18 Oct 2019  