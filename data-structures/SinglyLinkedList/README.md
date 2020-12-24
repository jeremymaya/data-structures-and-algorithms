# Singly Linked List

![build](https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/workflows/build/badge.svg)

Author: Kyungrae Kim

---

## Linked List

### What is Linked List?

Linked List is a linear data structure made of a sequence of `Nodes` that are linked to each other. Each `Node` are linked together by the reference field.

```text
+-------+---+   +-------+---+   +-------+---+
| Value | *-+-->| Value | *-+-->| Value | *-+-->NULL
+-------+---+   +-------+---+   +-------+---+
    NODE            NODE           NODE
    HEAD
```

### Strength

* Allows for fast operations on the ends
* Dynamic data structure - flexible in size

### Weakness

* Costly lookup
* Not cache-friendly

### Big O

|| Worst Case |
|:-|:-:|
| Space | O(n) |
| Prepend | O(1) |
| Append | O(1) |
| Lookup | O(n) |
| Insert | O(n) |
| Delete | O(n) |

---

## Implementation

### Prepend

```c#
public void Prepend(T value)
{
    Node<T> current = new Node<T>(value)
    {
        Next = Head
    };

    Head = current;
}
```

### Append

```c#
public void Append(T value)
{
    if (Head == null)
    {
        Prepend(value);
        return;
    }

    Node<T> previous = TraverseToEnd();
    Node<T> current = new Node<T>(value);

    previous.Next = current;
}
```

### Lookup

```c#
public bool Lookup(T value)
{
    Node<T> current = Head;

    while (current != null)
    {
        if (current.Value.Equals(value))
            return true;

        current = current.Next;
    }

    return false;
}
```

### Insert

```c#
public void InsertAtIndex(int index, T value)
{
    if (index == 0)
    {
        Prepend(value);
        return;
    }

    Node<T> previous = GetNodeFromIndex(index - 1);

    if (previous == null)
        return;

    Node<T> current = new Node<T>(value);
    Node<T> next = previous.Next;

    current.Next = next;
    previous.Next = current;
}
```

### Delete

```c#
public void DeleteAtIndex(int index)
{
    Node<T> current = GetNodeFromIndex(index);

    if (current == null)
        return;

    Node<T> previous = GetNodeFromIndex(index - 1);
    Node<T> next = current.Next;

    if (previous != null)
        previous.Next = next;
    else
        Head = next;
}
```

---

## Link to Code

[LinkedList Library](SinglyLinkedList/LinkedList.cs)

---

## References

* [Code Fellows - Linked List](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-05/resources/singly_linked_list.html)
* [What’s a Linked List, Anyway pt1](https://medium.com/basecs/whats-a-linked-list-anyway-part-1-d8b7e6508b9d)
* [What’s a Linked List, Anyway pt2](https://medium.com/basecs/whats-a-linked-list-anyway-part-2-131d96f71996)
* [tutorialpoints - Linked List](https://www.tutorialspoint.com/data_structures_algorithms/linked_list_algorithms.htm)
* [Interview Cake - Linked List](https://www.interviewcake.com/concept/python/linked-list?)

---

## Change Log

* 2.0: *Singly Linked List implemented* - 23 December 2020
* 1.0: *Code Challenge 06 Completed, Initial submission* - 22 October 2019  
