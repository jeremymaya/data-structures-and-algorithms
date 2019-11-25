# Code Challenge 28 Qucik Sort

## Quick Sort
*Author: Kyungrae Kim*

---

### Problem Domain
Visually show the output of processing the following input array using Qucik Sort method:  
`[8,4,23,42,16,15]`

Insertion Sort Psudocode
```
ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```

---

### Inputs and Expected Outputs
| Input | Expected Output |
| :----------- |:----------- |
| [8,4,23,42,16,15] | [4,8,15,16,23,42] |
| [20,18,12,8,5,-2] | [-2,5,8,12,18,20] |
| [5,12,7,5,5,7] | [5,5,5,7,7,12] |
| [2,3,5,7,13,11] | [2,3,5,7,11,13] |

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| InsertionSort(int[] arr) | O(n^2) | O(n) |

---

### Solution
```C#

```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/QuickSort/QuickSort/Program.cs

---

### Whiteboard Visual
![insertion-sort](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/quick-sort.jpg)

---

### Change Log
1.0: *Code Challenge 28 completed, Initial Submission* - 24 Nov 2019
