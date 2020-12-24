# Stacks and Queues

Author: Kyungrae Kim

---

## Stack

### What is Stack?

Stack is a linear data structure which adds or removes data in Last In First Out (LIFO) manner. It is also an abstract data structure which is defined by a set of behaviors and not how the behavior is implemented.

Stack can be implemented using a Linked List or a Dynamic Array.

```text
     +---+          +---+
push | 5 |- .    . >| 4 | pop
     +---+   '  '   +---+
             v  |
         +-----------+
     top |     3     |
         +-----------+
         |     2     |
         +-----------+
         |     1     |
         +-----------+
```

### Strength

* Fast operations

### Big O

|| Worst Case |
|:-|:-:|
| Space | O(n) |
| Push | O(1) |
| Pop | O(1) |
| Peek | O(1) |

---

## Implementation

### Push

```c#
```

### Pop

```c#
```

### Peek

```c#
```

---

## Link to Code

[StackAndQueue Library](StackAndQueue/StackAndQueue.cs)

---

## References

* [Code Fellows - Stacks and Queues](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-10/resources/stacks_and_queues.html)
* [tutorialpoints - Stack](https://www.tutorialspoint.com/data_structures_algorithms/stack_algorithm.htm)
* [Interview Cake - Stack](https://www.interviewcake.com/concept/python/stack?)
* [GeeksForGeeks - Abstract Data Types](https://www.geeksforgeeks.org/abstract-data-types/)

---

## Change Log

* 2.0: *Stack and Queue implemented* - 23 December 2020
* 1.0: *Code Challenge 13 Completed, Initial submission* - 03 November 2019  
