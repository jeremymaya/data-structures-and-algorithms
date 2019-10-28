# Data Structure and Algorithm

## Linked List
*Author: Kyungrae Kim*  
*Pair Partner: Alistair Blake*

---

### Problem Domain
Write the following methods:
1. `.append(value)` which adds a new node with the given `value` to the end of the list
2. `.insertBefore(value, newVal)` which add a new node with the given `newValue` immediately before the first `value` node
3. `.insertAfter(value, newVal)` which add a new node with the given `newValue` immediately after the first `value` node
4. `.kthFromEnd(k)` which return the node’s value that is `k` from the end of the linked list

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
#### .kthFromEnd(k)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> [8] -> X | 0 | 2 |
| head -> [1] -> [3] -> [2] -> [8] -> X | 2 | 3 |
| head -> [1] -> [3] -> [2] -> [8] -> X | 6 | Exception |

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
#### .kthFromEnd(k)
1. Check if Head exists
    1. If Head == null, create a new linked list
    2. Else, continue to step 2
2. Create the following:
	1. 'current' node from Head to save the Head reference
	2. 'argument' node that will save the node reference to parameter k
	3. variable countList that will track number of the linked list's node
3. Iterate through a linked list using current and count the number of nodes using the countList while value at node next to current does not equal to null
	2. If countList == k, set argument node equal to current
4. Create a variable countNum that will track number of the linked list's node starting from the argument node while node next to current does not equal to null
5. Iterate through the linked list using arguement node and count the number of node using the countNum
6. Reset the current node to Head and iterate through the linked list less than to (k - countNum)
7. Return the valye of the current node

---

### Efficiency
Follwings methods have O(n) efficiency due to the usage of a while loop:
* .append(value)
* .insertBefore(value, newValue)
* .insertAfter(value, newValue)

Follwings method have O(n^2) efficiency due to the usage of two while loops:
* .kthFromEnd(k)


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
#### .kthFromEnd(k)
```C#
public int KthFromEnd(int num)
{
    Node current = Head;
    Node argument = null;
    int countList = 0;

    while (current.Next != null)
    {
        if (countList == num)
        {
            argument = current;
        }
        current = current.Next;
        countList++;
    }

    if (countList != 0)
    {
        int countNum = 0;
        while (argument.Next != null)
        {
            argument = argument.Next;
            countNum++;
        }

        current = Head;
        for (int i = 0; i < num - countNum; i++)
        {
            current = current.Next;
        }
        return current.Value;
    }
    return current.Value;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/LinkedList/LinkedList/Classes/Node.cs

---

### Whiteboard Visual
#### Linked List Insertions
![linked-list-insertions](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/linked-list-insertions.jpg)
#### Linked List kth From the End
![k-th-value-from-the-end](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/k-th-value-from-the-end.jpg)

---

### Credit
[Carnegie Mellon University](https://www.cs.cmu.edu/~adamchik/15-121/lectures/Linked%20Lists/linked%20lists.html)

---

### Change Log
1.0: *Code Challenge 06 Completed, Initial submission* - 22 Oct 2019  
