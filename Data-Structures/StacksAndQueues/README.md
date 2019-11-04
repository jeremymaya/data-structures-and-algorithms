# Data Structure and Algorithm

## Stacks and Queues
*Author: Kyungrae Kim*  

---

### Problem Domain
Create a Node class with the following properties:
* Value
* Next

Create a Stack class with the following properties:
* Top

Write the following methods:
1. `Push(value)` which takes any value as an argument and adds a new node with that value to the `Top` of the stack with an O(1) Time performance
2. `Pop()` that does not take any argument, removes the node from the top of the stack, and returns the node’s value
3. `Peek()` that does not take an argument and returns the value of the node located on top of the stack, without removing it from the stack
4. `IsEmpty()` that does not take an argument, and returns a boolean indicating whether or not the stack is empty

Create a Queue class with the following properties:
* Front

Write the following methods:
1. `Queue(value)` which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance
2. `Deqeue()` that does not take any argument, removes the node from the front of the queue, and returns the node’s value
3. `Peek()` that does not take an argument and returns the value of the node located in the front of the queue, without removing it from the queue
4. `IsEmpty()` that does not take an argument, and returns a boolean indicating whether or not the queue is empty

---

### Inputs and Expected Outputs
#### Push(value)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Top -> [1] -> X | 2 | Top -> [2] -> [1] -> X |
#### Pop()
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Top -> [2] -> [1] -> X |  | 2 |
#### Peek()
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Top -> [2] -> [1] -> X |  | 2 |
#### IsEmpty()
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Top -> [2] -> [1] -> X |  | false |
#### QueueTheValue(value)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Front -> [1] -> X | 2 | Front -> [1] -> [2] -> X |
#### Dequeue()
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Fron -> [1] -> [2] -> X |  | 1 |
#### Peek()
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Front -> [1] -> [2] -> X |  | 1 |
#### IsEmpty()
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| Front -> [1] -> [2] -> X |  | false |

---

### Approach
#### Push(value)
1. Check if Top is null
    1. If true, Set Top equal to a new node created with the parameter value
    2. Else, proceed to step 2
2. Create a new node called topNext and reference the Top node
3. Create a new node called newTop with the parameter value
4. Set Top equal to newTop
5. Set Top.Next to topNext
#### Pop()
1. Check if Top is null
    1. If true, return "Stack is empty" message
2. Create a variable called value and set it equal to Top.Value
3. Set Top equal to Top.Next
4. Return the value
#### Peek()
1. Check if Top is null
    1. If true, return "Stack is empty" message
2. Create a variable called value and set it equal to Top.Value
3. Return the value
#### IsEmpty()
1. Create a variable called empty
2. Check if Top is null
   1. If true, set empty to true
   2. Return the empty
3. Else, return the empty
#### Queue(value)
1. Check if Front is null
    1. If true, Set Front equal to a new node created with the parameter value
    2. Else, proceed to step 2
2. Create a new node called pointer and reference the Front node
3. Create a new node called newQueue with the parameter value
4. While pointer.Next does not equal to null
   1. Set pointer equal to ponter.Next
5. Set pointer.Next to newQueue
#### Dequeue()
1. Check if Front is null
    1. If true, return "Queue is empty" message
2. Create a variable called value and set it equal to Front.Value
3. Set Front equal to Front.Next
4. Return the value
#### Peek()
1. Check if Front is null
    1. If true, return "Queue is empty" message
2. Create a variable called value and set it equal to Front.Value
3. Return the value
#### IsEmpty()
1. Create a variable called empty
2. Check if Front is null
   1. If true, set empty to true
   2. Return the empty
3. Else, return the empty

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| Push(value) | O(1) | O(1) |
| Pop() | O(1) | O(1) |
| Peek() for stack | O(1) | O(1) |
| IsEmpty() for stack | O(1) | O(1) |
| Queue(value) | O(n) | O(1) |
| Dequeue() | O(1) | O(1) |
| Peek() for Queue | O(1) | O(1) |
| IsEmpty for Queue| O(1) | O(1) |

---

### Solution
#### Push(value)
```C#
public void Push(int value)
{
    if(Top == null)
    {
        Top = new Node(value);
    }
    else
    {
        Node topNext = Top;
        Node newTop = new Node(value);
        Top = newTop;
        Top.Next = topNext;
    }
}
```

#### Pop()
```C#
public int Pop()
{
    if(Top == null)
    {
        Console.WriteLine("Stack is empty");
    }
    int value = Top.Value;
    Top = Top.Next;

    return value;
}
```

#### Peek() for Stack
```C#
public int Peek()
{
    if (Top == null)
    {
        Console.WriteLine("Stack is empty");
    }
    int value = Top.Value;
 
    return value;
}
```

#### IsEmpty() for Stack
```C#
public bool IsEmpty()
{
    bool empty = false;
    if(Top == null)
    {
        empty = true;
        return empty;
    }
    return empty;
}
```

#### Queue(value)
```C#
public void QueueTheValue(int value)
{
    if(Front == null)
    {
        Front = new Node(value);
    }
    else
    {
        Node pointer = Front;
        Node newQueue = new Node(value);

        while (pointer.Next != null)
        {
            pointer = pointer.Next;
        }
        pointer.Next = newQueue;
    }
}
```

#### Dequeue()
```C#
public int Dequeue()
{
    if (Front == null)
    {
        Console.WriteLine("Queue is empty");
    }
    int value = Front.Value;
    Front = Front.Next;

    return value;
}
```

#### Peek() for Queue
```C#
public int Peek()
{
    if (Front == null)
    {
        Console.WriteLine("Queue is empty");
    }
    int value = Front.Value;

    return value;
}
```

#### IsEmpty() for Queue
```C#
public bool IsEmpty()
{
    bool empty = false;
    if (Front == null)
    {
        empty = true;
        return empty;
    }
    return empty;
}
```

---

### Link to Code
#### Stack
https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/Data-Structures/StacksAndQueues/StacksAndQueues/Classes/Stack.cs
#### Queue
https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/Data-Structures/StacksAndQueues/StacksAndQueues/Classes/Queue.cs
---

### Whiteboard Visual
#### Linked List Insertions
![stack-and-queue]()

---

### Change Log
1.0: *Code Challenge 13 Completed, Initial submission* - 03 Nov 2019  
