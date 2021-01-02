# Sorting Algorithm - Quick Sort

Author: Kyungrae Kim

---

## Quick Sort

### What is Quick Sort?

**Quick Sort** is a Divide and Conquer algorithm which works by dividing the input into two smaller arrays: one with small items and the other with large items. Then, it recursively sorts both the smaller lists.

### Advantages

* Fast - On average, the quick sort runs in O(n log n) time
* Parallelizable - Quick Sort divides the input into two sections, each of which can be sorted at the same time in parallel

### Disadvantages

* Slow Worst- Case

### Big O

|  | Worst | Best | Average | Space |
|:-|:-:|:-:|:-:|:-:|
| QuickSort() | O(n^2) | O(n log n) | O(n log n) | O(log n) |

---

## Implementation

### QuickSort

```c#
public static int[] QuickSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int position = Partition(arr, left, right);

        QuickSort(arr, left, position - 1);
        QuickSort(arr, position + 1, right);
    }

    return arr;
}
```

### Partition

```c#
static int Partition(int[] arr, int left, int right)
{
    int pivot = arr[right];
    int low = left - 1;

    for (int i = left; i < right; i++)
    {
        if (arr[i] <= pivot)
        {
            low++;
            Swap(arr, i, low);
        }
    }

    Swap(arr, right, low + 1);

    return low + 1;
}
```

### Swap

```c#
static void Swap(int[] arr, int i, int low)
{
    int temp = arr[i];
    arr[i] = arr[low];
    arr[low] = temp;
}
```

---

## References

* [Code Fellows - Quick Sort](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-28/)
* [Wikipedia - Quicksort](https://en.wikipedia.org/wiki/Quicksort)
* [GeeksForGeeks - Quick Sort](https://www.geeksforgeeks.org/quick-sort/)
* [tutorialpoints - Quicksort Algorithm](https://www.interviewcake.com/concept/python/quicksort?)
* [Interview Cake - Binary Search Algorithm](https://www.interviewcake.com/concept/python/binary-search?)
* [LeetCode - Binary Search (Learn)](https://leetcode.com/explore/learn/card/binary-search/)
* [LeetCode - Binary Search](https://leetcode.com/problems/binary-search/)

---

## Change Log

* 2.0: *Quick Sort re-implemented* - 31 December 2020
* 1.0: *Code Challenge 28 completed, Initial Submission* - 24 November 2019
