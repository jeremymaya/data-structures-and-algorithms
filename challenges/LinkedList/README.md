# Code Challenge 06 Linked List Insertions

## Linked List Insertions
*Author: Kyungrae Kim*

---

### Problem Domain
Write the following methods:
1. `.append(value)` which adds a new node with the given `value` to the end of the list
2. `.insertBefore(value, newVal)` which add a new node with the given `newValue` immediately before the first `value` node
3. `.insertAfter(value, newVal)` which add a new node with the given `newValue` immediately after the first `value` node

---

### Inputs and Expected Outputs
#### .append(value)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 5 | head -> [1] -> [3] -> [2] -> [5] -> X |
| head -> X | 1 | head -> [1] -> X |
#### .insertBefore(value, newValue)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 3, 5 | head -> [1] -> [5] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 1, 5 | head -> [5] -> [1] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 4, 5 | Exception |
#### .insertAfter(value, newValue)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 3, 5 | head -> [1] -> [3] -> [5] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 1, 5 | head -> [1] -> [5] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 4, 5 | Exception |

---

### Approach
#### .append(value)
1. Determine the middle index
2. Create a new int array
3. Use a for loop to iterate over the new int array and assign a value with the following condition
    1. If i < middle, value of the new array at index i euqals to the value of the old array at index i
    2. If i == middle, value of the new array at index i equal to the value to be added
    3. If i > middle, value of the new array at index i euqals to the value of the old array at index  i - 1
4. Return the new int array

---

### Efficiency
N/A

---

### Solution
```C#
public static int[] insertShiftArray(int[] arr, int num)
{
    int[] newArr = new int[(arr.Length + 1)];
    double middle= Math.Ceiling(arr.Length / 2.0);

    for (int i = 0; i <= arr.Length; i++)
    {
        if (i < middle)
        {
            newArr[i] = arr[i];
        }
        else if (i == middle)
        {
            newArr[i] = num;
        }
        else if (i > middle)
        {
            newArr[i] = arr[i - 1];
        }
    }
    return newArr;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/ArrayShift/ArrayShift/Program.cs

---

### Whiteboard Visual
![array-shift](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/array-shift.jpg)

---

### Change Log
1.0: *Code Challenge 02 Completed, Initial submission* - 17 Oct 2019  
