# Code Challenge 08 Linked List Merge

## Linked List Merge
*Author: Kyungrae Kim*  
*Pair Partner: Matthew Heyert*  

---

### Problem Domain
Write a function called 'mergeLists' which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). Use of the Node class and all the properties on the Linked List class as well as the methods created in previous challenges are allowed.

---

### Inputs and Expected Outputs

| Input 1 | Input 2 | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [2] -> [4] -> X |
| head -> [1] -> [3] -> X | head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [4] -> X |
| head -> [1] -> [3] -> [2] -> X | head -> [5] -> [9] -> X | head -> [1] -> [5] -> [3] -> [9] -> [2] -> X |

---

### Approach
1. Check if Heads for list1 and list2 exist
    1. If Head == null, create a new linked list
    2. Else, continue to step 2
2. Create a new linked list
3. Set the following variables:
    1. Node current1 = Head of list1
    2. Node current2 = Head of list2
    3. Node zip = Head of the new linked list
    4. int count = 0
3. While current2 does not equal to null,
    1. If count = 0, zip = current1
	2. If count is even and not 0, zip.next = current1, current1 = current1.Next
	3. If count is odd, zip.next = current2, current2 = current2.Next
    4. Increment count by 1
4. Set zip = Head of the new linked list
5. Return zip

---

### Efficiency
N/A

---

### Solution
```C#

```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/LLMerge/LLMerge/Program.cs

---

### Whiteboard Visual
![array-binary-search](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/array-binary-search.jpg)

---

### Change Log
1.0: *Code Challenge 03 Completed, Initial submission* - 24 Oct 2019
