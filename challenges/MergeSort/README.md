# Code Challenge 27 Merge Sort

## Merge Sort
*Author: Kyungrae Kim*

---

### Problem Domain
Visually show the output of processing the following input array using Merge Sort method:  
`[8,4,23,42,16,15]`

Insertion Sort Psudocode
```
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
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
| InsertionSort(int[] arr) | O(nLogn) | O(n) |

---

### Solution
#### MergeSort
```C#
public static int[] MergeSort(int[] arr)
{
    int n = arr.Length;

    if (n > 1)
    {
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i = 0; i < n; i++)
        {
            if (i < mid)
            {
                left[i] = arr[i];
            }
            else
            {
                right[i - mid] = arr[i];
            }
        }

        MergeSort(left);
        MergeSort(right);
        Merge(left, right, arr);
    }

    return arr;
}
```
#### Merge
```C#
public static void Merge(int[] left, int[] right, int[] arr)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right [j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        if (i == left.Length)
        {
            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
        else
        {
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
        }
    }
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/MergeSort/MergeSort/Program.cs

---

### Whiteboard Visual
![insertion-sort](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/merge-sort.jpg)

---

### Change Log
1.0: *Code Challenge 27 completed, Initial Submission* - 24 Nov 2019
