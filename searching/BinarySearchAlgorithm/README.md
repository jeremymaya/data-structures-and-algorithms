# Binary Search

Author: Kyungrae Kim

---

## What is Binary Search?

A **binary search algorithm** finds an item in a **sorted list** in O(log n) time which works on the principle of divide and conquer. It repeatedly divides the search internal in half to find a matching item.

### Advantages

* Binary search is a fast search algorithm - a linear search algorithm finds an time in O(n) time

### Big O

|  | Time | Space |
|:-|:-:|:-:|
| BinarySearch() | O(log n) | O(1) |

* Time Complexity: O(log n)
* Space Complexity: O(1)

---

## Implementation

```c#
public static int BinarySearch(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        int pivot = left + (right - left) / 2;

        if (nums[pivot] == target)
            return pivot;

        if (target < nums[pivot])
            right = pivot - 1;
        else
            left = pivot + 1;
    }

    return -1;
}
```

---

## References

* [Code Fellows - Binary Search](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-03/)
* [tutorialpoints - Binary Search](https://www.tutorialspoint.com/data_structures_algorithms/binary_search_algorithm.htm)
* [Interview Cake - Binary Search Algorithm](https://www.interviewcake.com/concept/python/binary-search?)
* [LeetCode - Binary Search (Learn)](https://leetcode.com/explore/learn/card/binary-search/)
* [LeetCode - Binary Search](https://leetcode.com/problems/binary-search/)

---

## Change Log

* 2.0: *BinarySearch re-implemented* - 30 December 2020
* 1.0: *Code Challenge 03 Completed, Initial submission* - 18 October 2019  
