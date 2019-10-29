# Code Challenge 11 Queue With Stacks

## Queue With Stacks
*Author: Kyungrae Kim*

---

### Problem Domain
Create a brand new `PseudoQueue` class. This class will internally utilize 2 Stack objects. Afterwards, implement the following methods:
1. Enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
2. Dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.

---

### Inputs and Expected Outputs
#### Enqueue(value)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| [10] -> [15] -> [20] | 5 | [5] -> [10] -> [15] -> [20] |
|   | 5 | [5] |
#### Dequeue()
| Input | Expected Output  | Internal State|
| :----------- |:-- |:----------- |
| [5] -> [10] -> [15] -> [20] | 20 | [5] -> [10] -> [15] |
| [5] -> [10] -> [15] | 15 | [5] -> [10] |

---

### Approach
#### Enqueue(value)
1. While stackOne is not empty, pop values from stackOne and push the values to stackTwo
2. Push the argument value to stackOne
3. While stackTwo is not empty, pop values from stackTwo and push the values to stackOne
#### Dequeue()
1. If stackOne is not empty, pop stackOne
2. Return the popped value

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| Enqueue(value) | O(n) | O(1) |
| Dequeue() | O(1) | O(1) |

---

### Solution
#### Enqueue(value)
```C#
public void Enqueue(int value)
{
    while(stackOne.Count != 0)
    {
        stackTwo.Push(stackOne.Pop());
    }

    stackOne.Push(value);

    while (stackTwo.Count != 0)
    {
        stackOne.Push(stackTwo.Pop());
    }
}
```
#### Dequeue()
```C#
public int Dequeue()
{
    int value = (int)stackOne.Pop();
    return value;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/challenges/QueueWithStacks/QueueWithStacks/Classes/PseudoQueue.cs

---

### Whiteboard Visual
![queue-with-stack](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/queue-with-stacks.jpg)

---

### Change Log
1.0: *Code Challenge 11 Started, Initial submission* - 28 Oct 2019  
