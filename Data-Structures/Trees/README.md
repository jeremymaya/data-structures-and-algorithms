# Data Structure and Algorithm

## Trees

*Author: Kyungrae Kim*  

---

### Problem Domain
#### Node
Create a Node class with the following properties:
* Value
* LeftChild
* RightChild

#### BinaryTree
Create a BinaryTree class with the following methods:
1. `PreOrder` which returns an array of the values, ordered appropriately
2. `InOrder` which returns an array of the values, ordered appropriately
3. `PostOrder` which returns an array of the values, ordered appropriately
4. `BreadthFirst` which takes a Binary Tree as its unique input

#### BinarySearchTree
Create a BinarySearchTree class with the following methods:
1. `Add(value)` that accepts a value, and adds a new node with that value in the correct location in the binary search tree
2. `Contains(value)` that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once

---

### Inputs and Expected Outputs

---

### Approach
#### BinaryTree
##### PreOrder(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method PreOrder()
2. From the recursive helper method that:
   1. Adds Root node to the call stack then adds to a generic list
   2. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
##### InOrder(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method InOrder()
2. From the recursive helper method that:
   1. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   2. Adds Root node to the call stack then adds to a generic list
   3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
##### PostOrder(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method PostOrder()
2. From the recursive helper method that:
   1. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   2. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
   3. Adds Root node to the call stack then adds to a generic list
##### BreadthFirst(node)
1. Create a non-resursive method that creates and return a generic list to store nodes from resursive helper method PreOrder()
2. From the recursive helper method that:
   1. Adds Root node to the call stack then adds to a generic list
   2. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
   3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
#### BinarySearchTree
##### Add(node, value)
1. If BinarySearchTree instance is empty, creates a new node
2. If the parameter value is less than the value of a node, invoke Add method again from the LeftChild node
3. If the parameter value is less than the value of a node, invoke Add method again from the RightChild node
##### Contains(node, value)
1. If BinarySearchTree instance is empty, return false
2. If the parameter value is less than the value of a node, invoke Contains method again and return a result
3. If the parameter value is less than the value of a node, invoke Contains method again and return a result

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| PreOrder(node) | O(n) | O(1) |
| InOrder(node) | O(n) | O(1) |
| PostOrder(node) | O(n) | O(1) |
| BreadthFirst(node) | O(w) | O1) |
| Add(node, value) | O(n) | O1) |
| Contains(node, value) | O(n) | O1) |

---

### Solution
#### BinaryTree
##### PreOrder(node)
```C#
public List<T> PreOrder(Node<T> node)
{
    List<T> traversal = new List<T>();

    PreOrder(node, traversal);

    return traversal;
}
```
##### PreOrder(node, list) - Helper Function
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
##### InOrder(node)
```C#
public List<T> InOrder(Node<T> node)
{
    List<T> traversal = new List<T>();

    InOrder(node, traversal);

    return traversal;
}
```
##### InOrder(node, list) - Helper Function
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
##### PostOrder(node)
```C#
public List<T> PostOrder(Node<T> node)
{
    List<T> traversal = new List<T>();

    PostOrder(node, traversal);

    return traversal;
}
```
##### InOrder(node, list) - Helper Function
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
##### BreadthFirst(node)
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
#### BinaryTree
##### Add(node, value)
```C#
public Node<int> Add(Node<int> node, int value)
{
    if (node == null)
    {
        return new Node<int>(value);
    }
    else if (node.Value > value)
    {
        node.LeftChild = Add(node.LeftChild, value);
    }
    else if (node.Value < value)
    {
        node.RightChild = Add(node.RightChild, value);
    }

    return node;
}
```
##### Contains(node, value)
```C#
public bool Contains(Node<int> node, int value)
{
    if (node == null)
    {
        return false;
    }
    else if (node.Value == value)
    {
        return true;
    }
    else if (node.Value > value)
    {
        return Contains(node.LeftChild, value);
    }
    else if (node.Value < value)
    {
        return Contains(node.RightChild, value);
    }

    return false;
}
```

---

### Link to Code
* [Binary Tree](https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/Data-Structures/Trees/Trees/Classes/BinaryTree.cs)
* [Binary Search Tree](https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/Data-Structures/Trees/Trees/Classes/BinarySearchTree.cs)

---

### Credits
* [Code Fellows](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-15/resources/Trees.html)
* [JournalDev](https://www.journaldev.com/23086/binary-search-tree-bst-search-insert-remove)

### Change Log
1.0: *Code Challenge 15 and 17 completed* - 09 Nov 2019  
