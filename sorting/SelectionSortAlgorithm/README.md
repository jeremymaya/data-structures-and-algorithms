# Sorting Algorithm - Selection Sort

Author: Kyungrae Kim

---

## Selection Sort

### What is Selection Sort?

### Advantages

### Disadvantages

### Big O

|  | Worst | Best | Average | Space |
|:-|:-:|:-:|:-:|:-:|
| SelectionSort() | O(n^2) | O(n^2) | O(n^2) | O(1) |

---

## Implementation

### SelectionSort

```c#
public int[] SelectionSort(int[] arr)
{
    int n = arr.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int min = i;

        for (int j = i + 1; j < n; j++)
            if (arr[j] < arr[min])
                min = j;
        
        Swap(arr, min, i);
    }

    return arr;
}
```

---

## References

* [Code Fellows - Selection Sort](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-26/solutions/BLOG)
* [Wikipedia - Quicksort](https://en.wikipedia.org/wiki/Quicksort)
* [GeeksForGeeks - Quick Sort](https://www.geeksforgeeks.org/quick-sort/)
* [tutorialpoints - Selection Sort Algorithm](https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm)
* [Interview Cake - Selection Sort](https://www.interviewcake.com/concept/python/selection-sort)

---

## Change Log

* 2.0: *Quick Sort re-implemented* - 31 December 2020
* 1.0: *Code Challenge 28 completed, Initial Submission* - 24 November 2019
