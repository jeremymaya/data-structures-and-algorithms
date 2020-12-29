# Stacks and Queues

Author: Kyungrae Kim

---

## Stack

### What is Stack?

**Stack** is a linear data structure which adds or removes data in **Last In First Out (LIFO)** manner. It is also an abstract data structure (ADT) which is defined by a set of behaviors and not how the behavior is implemented.

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

### Strength - Stack

* Fast operations

### Big O - Stack

|| Worst Case |
|:-|:-:|
| Space | O(n) |
| Push | O(1) |
| Pop | O(1) |
| Peek | O(1) |

---

## Implementation - Stack

Below implementation uses a dynamic array.

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

    if (IsEmpty())
        return default;

    Top = count == 1 ? default : _stack[count - 1];

    T pop = _stack[count - 1];
    _stack.Remove(pop);

    return pop;
}
```

### Peek - Stack

```c#
public T Peek()
{
    int count = _stack.Count;

    if (IsEmpty())
        return default;

    return _stack[count - 1];
}
```

### IsEmpty - Stack

```c#
public bool IsEmpty()
{
    if (_stack.Count == 0)
        return true;

    return false;
}
```

---

## Queue

### What is Queue?

**Queue** is a linear data structure which adds or removes data in **First In First Out (FIFO)** manner. It is also an abstract data structure (ADT) which is defined by a set of behaviors and not how the behavior is implemented.

Since queue is also an ADT, it can be implemented by using Array, Structure, Pointer, and Linked List.

```text
Enqueue                     Dequeue
 +---+     +---+---+---+     +---+
 |   |     |   |   |   |     |   |
 | 5 |---> | 4 | 3 | 2 |---> | 1 |
 |   |     |   |   |   |     |   |
 +---+     +---+---+---+     +---+
```

### Strength - Queue

* Fast operations

### Big O - Queue

|| Worst Case |
|:-|:-:|
| Space | O(n) |
| Enqueue | O(1) |
| Dequeue | O(1) |
| Peek | O(1) |

---

## Implementation - Queue

Below implementation uses a pointer.

### Enqueue

```c#
public void Enqueue(T value)
{
    Node<T> node = new Node<T>(value);

    if (Front == null)
    {
        Front = node;
        Rear = node;
    }
    else
    {
        Rear.Next = node;
        Rear = node;
    }
}
```

### Dequeue

```c#
public T Dequeue()
{
    if (IsEmpty())
        return default;

    Node<T> temp = Front;
    Front = Front.Next;
    temp.Next = null;

    return temp.Value;
}
```

### Peek - Queue

```c#
public T Peek()
{
    return Front.Value;
}
```

### IsEmpty - Queue

```c#
public bool IsEmpty()
{
    return Front == null;
}
```

---

## Link to Code

* [StackAndQueue Library - Stack](StackAndQueue/Stack.cs)
* [StackAndQueue Library - Queue](StackAndQueue/Queue.cs)

---

## References

* [Code Fellows - Stacks and Queues](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-10/resources/stacks_and_queues.html)
* [tutorialpoint - Stack](https://www.tutorialspoint.com/data_structures_algorithms/stack_algorithm.htm)
* [tutorialpoint - Queue](https://www.tutorialspoint.com/data_structures_algorithms/dsa_queue.htm)
* [Interview Cake - Stack](https://www.interviewcake.com/concept/python/stack?)
* [Interview Cake - Queue](https://www.interviewcake.com/concept/python/queue?)
* [LeetCode - Queue &  Stack](https://leetcode.com/explore/learn/card/queue-stack/)
* [GeeksForGeeks - Abstract Data Types](https://www.geeksforgeeks.org/abstract-data-types/)

---

## Change Log

* 2.0: *Stack and Queue implemented* - 23 December 2020
* 1.0: *Code Challenge 13 Completed, Initial submission* - 03 November 2019  
