# Code Challenge 30 Hashtable

## Hashtable
*Author: Kyungrae Kim*

---

### Problem Domain
Implement a Hashtable with the following methods:
1. `add`: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
2. `get`: takes in the key and returns the value from the table.
3. `contains`: takes in the key and returns a boolean, indicating if the key exists in the table already.
4. `hash`: takes in an arbitrary key and returns an index in the collection.

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| Add | O(n) | O(1) |
| Get | O(n) | O(1) |
| Contains | O(n) | O(1) |
| Hash | O(n) | O(1) |

---

### Solution
#### Add
```C#
public void Add(string key, string value)
{
    int index = Hash(key);
    Node newNode = new Node(key, value);

    if (Table[index] == null)
    {
        Table[index] = newNode;
    }
    else
    {
        Node current = Table[index];
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = new Node(key, value);
    }
}
````
#### Get
```C#
public Node Get(string key)
{
    int index = Hash(key);
    Node current = Table[index];

    while (current != null)
    {
        if (current.Key == key)
        {
            return current;
        }
        current = current.Next;
    }

    return null;
}
```
#### Contains
```C#
public bool Contains(string key)
{
    int index = Hash(key);
    Node current = Table[index];

    while (current != null)
    {
        if (current.Key == key)
        {
            return true;
        }
        current = current.Next;
    }

    return false;
}
```
#### Hash
```C#
public int Hash(string key)
{
    int hash = 0;

    foreach (int character in key)
    {
        hash += character;
    }

    return hash * 599 % 1014;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/Data-Structures/HashtableImplementation/HashtableImplementation/Program.cs

---

### Whiteboard Visual
![hashtable](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/hashtable.jpg)

---

### Change Log
1.0: *Code Challenge 30 Completed, Second Submission* - 28 Nov 2019
1.0: *Code Challenge 30 started, Initial Submission* - 25 Nov 2019
