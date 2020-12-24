# Stacks and Queues

Author: Kyungrae Kim

---

## Stack

### What is Stack?

Stack is a linear data structure which adds or removes data in Last In First Out (LIFO) manner. It is also an abstract data structure (ADT) which is defined by a set of behaviors and not how the behavior is implemented.

Since stack is an ADT, it can be implemented by using Array, Structure, Pointer, and Linked List.

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
public void Push(T value)
{
    Top = value;

    _stack.Add(value);
}
```

### Pop

```c#

public T Pop()
{
    int count = _stack.Count;

    if (count == 0)
        return default;

    Top = count == 1 ? default : _stack[count - 1];

    T pop = _stack[count - 1];
    _stack.Remove(pop);

    return pop;
}
```

### Peek

```c#
public T Peek()
{
    int count = _stack.Count;

    if (count == 0)
        return default;

    return _stack[count - 1];
}
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
