# Data Structure and Algorithm

## Trees

*Author: Kyungrae Kim*  

---

### Problem Domain
Create a Node class with the following properties:
* Value
* LeftChild
* RightChild

Create a BinaryTree class with the following methods:
1. `PreOrder` which returns an array of the values, ordered appropriately
2. `InOrder` which returns an array of the values, ordered appropriately
3. `PostOrder` which returns an array of the values, ordered appropriately
4. `BreadthFirst` which takes a Binary Tree as its unique input

Create a BinarySearchTree class with the following methods:
1. `Add(value)` that accepts a value, and adds a new node with that value in the correct location in the binary search tree
2. `Contains(value)` that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once

---

### Inputs and Expected Outputs

---

### Approach
#### PreOrder(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method PreOrder()
2. From the recursive helper method that:
   1. Adds Root node to the call stack then adds to a generic list
   2. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
#### InOrder(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method InOrder()
2. From the recursive helper method that:
   1. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   2. Adds Root node to the call stack then adds to a generic list
   3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
#### PostOrder(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method PostOrder()
2. From the recursive helper method that:
   1. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   2. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
   3. Adds Root node to the call stack then adds to a generic list
#### BreadthFirst(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method PreOrder()
2. From the recursive helper method that:
   1. Adds Root node to the call stack then adds to a generic list
   2. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| PreOrder(node) | O(n) | O(1) |
| InOrder(node) | O(n) | O(1) |
| PostOrder(node) | O(n) | O(1) |
| BreadthFirst(node) | O(w) | O1) |

---

### Solution
#### PreOrder(node)
```C#
public List<T> PreOrder(Node<T> node)
{
    List<T> traversal = new List<T>();

    PreOrder(node, traversal);

    return traversal;
}
```
#### PreOrder(node, list) - Helper Function
```C#
private void PreOrder(Node<T> node, List<T> traversal)
{
    traversal.Add(node.Value);

    if(node.LeftChild != null)
    {
        PreOrder(node.LeftChild, traversal);
    }
    if(node.RightChild != null)
    {
        PreOrder(node.RightChild, traversal);
    }
}
```
#### InOrder(node)
```C#
public List<T> InOrder(Node<T> node)
{
    List<T> traversal = new List<T>();

    InOrder(node, traversal);

    return traversal;
}
```
#### InOrder(node, list) - Helper Function
```C#
private void InOrder(Node<T> node, List<T> traversal)
{
    if(node.LeftChild != null)
    {
        InOrder(node.LeftChild, traversal);
    }

    traversal.Add(node.Value);

    if (node.RightChild != null)
    {
        InOrder(node.RightChild, traversal);
    }
}
```
#### PostOrder(node)
```C#
public List<T> PostOrder(Node<T> node)
{
    List<T> traversal = new List<T>();

    PostOrder(node, traversal);

    return traversal;
}
```
#### InOrder(node, list) - Helper Function
```C#
private void PostOrder(Node<T> node, List<T> traversal)
{
    if (node.LeftChild != null)
    {
        PreOrder(node.LeftChild, traversal);
    }
    if (node.RightChild != null)
    {
        PreOrder(node.RightChild, traversal);
    }

    traversal.Add(node.Value);
}
```
#### BreadthFirst(node)
```C#
public List<T> BreadthFirst(Node<T> node)
{
    Queue<Node<T>> breadth = new Queue<Node<T>>();
    List<T> values = new List<T>();

    breadth.Enqueue(node);

    while(breadth.TryPeek(out node))
    {
        Node<T> front = breadth.Dequeue();
        values.Add(front.Value);

        if (front.LeftChild != null)
        {
            breadth.Enqueue(front.LeftChild);
        }

        if (front.RightChild != null)
        {
            breadth.Enqueue(front.RightChild);
        }
    }
    return values;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/Data-Structures/Trees/Trees/Classes/Tree.cs

---

### Change Log
1.0: *Code Challenge 15 Started* - 07 Nov 2019  
