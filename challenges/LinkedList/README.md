# Code Challenge 06 Linked List Insertions

## Linked List Insertions
*Author: Kyungrae Kim*

---

### Problem Domain
Write the following methods:
1. `.append(value)` which adds a new node with the given `value` to the end of the list
2. `.insertBefore(value, newVal)` which add a new node with the given `newValue` immediately before the first `value` node
3. `.insertAfter(value, newVal)` which add a new node with the given `newValue` immediately after the first `value` node

---

### Inputs and Expected Outputs
#### .append(value)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 5 | head -> [1] -> [3] -> [2] -> [5] -> X |
| head -> X | 1 | head -> [1] -> X |
#### .insertBefore(value, newValue)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 3, 5 | head -> [1] -> [5] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 1, 5 | head -> [5] -> [1] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 4, 5 | Exception |
#### .insertAfter(value, newValue)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 3, 5 | head -> [1] -> [3] -> [5] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 1, 5 | head -> [1] -> [5] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 4, 5 | Exception |

---

### Approach
#### .append(value)
1. Check if Head exists
    1. If Head == null, create a new linked list
    2. Else, continue to step 2
2. Create 'current' node from Head to save the Head reference
3. Iterate through a linked list using current while a node next to current does not equal to null
4. Append a new node by creating a node with parameter value next to the current node
#### .insertBefore(value, newValue)
1. Check if Head exists
    1. If Head == null, create a new linked list
    2. Else, continue to step 2
2. Create 'previous' node
3. Create 'current' node from Head to save the Head reference
4. For each iteration, set previous equal to current to keep the current reference
5. Iterate through a linked list using current while value at current does not equal to parameter value
5. Append a new node by create a new node next to the current node
#### .insertAfter(value, newValue)
1. Check if Head exists
    1. If Head == null, create a new linked list
    2. Else, continue to step 2
2. Create 'current' node from Head to save the Head reference
3. Iterate through a linked list using current while value at current does not equal to parameter value
4. Insert a new node by creating a node with parameter newValue next to the current node


---

### Efficiency
Above methods have O(n) efficiency due to the usage of a while loop

---

### Solution
#### .append(value)
```C#
public void Append(int value)
{
    Node newNode = new Node(value);
    if (Head == null)
    {
        Head = newNode;
    }
    else
    {
        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node(value);
    }
}
```
#### .insertBefore(value, newValue)
```C#
public void InsertBefore(int value, int newValue)
{
    Node newNode = new Node(value);
    if (Head == null)
    {
        Head = newNode;
    }
    else
    {
        Node previous = null;
        Node current = Head;
        while (current.Value != value)
        {
            previous = current;
            current = current.Next;
        }
        if(previous == null)
        {
            Head = new Node(newValue);
        }
        else
        {
            previous.Next = new Node(newValue);
        }
    }
}
```
#### .insertAfter(value, newValue)
```C#
public void InsertAfter(int value, int newValue)
{
    Node newNode = new Node(value);
    if (Head == null)
    {
        Head = newNode;
    }
    else
    {
        Node current = Head;
        while (current.Value != value)
        {
            current = current.Next;
        }
        current.Next = new Node(newValue);
    }
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/LinkedList/LinkedList/Classes/Node.cs

---

### Whiteboard Visual
![linked-list-insertions](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/linked-list-insertions.jpg)

---

### Credit
Carnegie Mellon University  
https://www.cs.cmu.edu/~adamchik/15-121/lectures/Linked%20Lists/linked%20lists.html

### Change Log
1.0: *Code Challenge 06 Completed, Initial submission* - 22 Oct 2019  
