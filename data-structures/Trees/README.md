# Trees

Author: Kyungrae Kim

---

## Binary Tree

### What is Binary Tree?

**Binary Tree** is a subset of **Graph** data structure used for data storage purposes. A binary tree has a special condition that each node can have at most two children, usually called `Left` and `Right`.

```text
               ROOT
              (100)
              /    \ EDGE
LEFT CHILD (50)    (200) RIGHT CHILD
           /  \    /
        (25) (75) (155)
       <-----LEAVES----->     
```

A **balanced or “perfect” binary tree** is one where *every non-leaf node has exactly two children*. The maximum width for a perfect binary tree, is `2^(h-1)`, where `h` is the height of the tree. Height can be calculated as `log n`, where `n` is the number of nodes.

```text
              (100)
              /    \
           (50)    (200)
           /  \    /    \
        (25) (75) (155) (30)
```

### Strength

* Has the benefits of both an **ordered array** and a **linked list**
  * Search is as quick as in a sorted array
  * Insertion or Deletion operation are as fast as in linked list

### Big O - Binary Tree

|| Worst Case |
|:-|:-:|
| Search | O(n) |
| Insertion | O(n)|
| Deletion | O(n) |

* The Big O space complexity for a node insertion using breadth first insertion will be **O(w)**, where `w` is the largest width of the tree. For example, in the above tree, `w` is 4.

---

## Binary Search Tree

### What is Binary Search Tree?

A Binary Search Tree (BST) is a type of tree, where nodes are organized in the following manner:

* All values that are smaller than the root are placed to the left
* All values that are larger than the root are placed to the right

```text
               (23)
              /    \
            (8)    (42)
           /  \    /
         (4) (16) (27)
```

### Big O - Binary Search Tree

|| Worst Case |
|:-|:-:|
| Search | O(h) |
| Insertion | O(h)|
| Deletion | O(h) |

* In a balanced tree, the height of the tree is `log(n)`. In an unbalanced tree, the worst case height of the tree is `n`.
* The Big O space complexity of a BST search would be **O(1)**. During a search, we are not allocating any additional space.

---

## Traversals

### Depth-First

In a Depth-First traversal, exploring the data structure in depth is prioritized - go as deep as possible down one path before backing up and trying a different one. It uses a stack for the traversal.

Advantages:

* Depth-first traversal on a binary tree generally requires less memory than breadth-first
* Can be easily implemented with recursion

Disadvantages:

* Doesn't necessarily find the shortest path to a node, while breadth-first search does

### Breadth-First

In a Breadth-First traversal, exploring the data structure in breadthward motion - explore all the nodes one step away, then all the nodes two steps away, etc. It uses queue for the traversal.

Advantages:

* Finds the shortest path between the starting point and any other reachable node

Disadvantages:

* Generally requires more memory than a Depth-First.

---

## Implementation

### PreOrder - Recursive

```c#
public List<T> PreOrder(Node<T> root)
{
    if (root == null)
        return new List<T>();

    List<T> values = new List<T>();
    PreOrder(root, values);
    return values;
}

private void PreOrder(Node<T> root, List<T> values)
{
    if (root == null)
        return;
    
    values.Add(root.Value);
    PreOrder(root.Left, values);
    PreOrder(root.Right, values);
}
```

### PreOrder - Iterative

```c#
public List<T> PreOrder(Node<T> root)
{
    if (root == null)
        return new List<T>();

    Stack<Node<T>> stack = new Stack<Node<T>>();
    List<T> values = new List<T>();

    stack.Push(root);

    while (stack.Count != 0)
    {
        Node<T> current = stack.Pop();
        values.Add(current.Value);

        if (current.Right != null)
            stack.Push(current.Right);

        if (current.Left != null)
            stack.Push(current.Left);
    }

    return values;
}
```

### InOrder - Recursive

```c#
public List<T> InOrder(Node<T> root)
{
    if (root == null)
        return new List<T>();

    List<T> values = new List<T>();
    InOrder(root, values);
    return values;            
}

private void InOrder(Node<T> root, List<T> values)
{
    if (root == null)
        return;
    
    InOrder(root.Left, values);
    values.Add(root.Value);
    InOrder(root.Right, values);
}
```

### InOrder - Iterative

```c#
public List<T> InOrder(Node<T> root)
{
    if (root == null)
        return new List<T>();

    Stack<Node<T>> stack = new Stack<Node<T>>();
    List<T> values = new List<T>();

    Node<T> current = root;

    while (current != null || stack.Count != 0)
    {
        while (current != null)
        {
            stack.Push(current);
            current = current.Left;
        }

        current = stack.Pop();
        values.Add(current.Value);
        current = current.Right;
    }

    return values;
}
```

### PostOrder - Recursive

```c#
public List<T> PostOrder(Node<T> root)
{
    if (root == null)
        return new List<T>();

    List<T> values = new List<T>();
    PostOrder(root, values);
    return values;            
}

private void PostOrder(Node<T> root, List<T> values)
{
    if (root == null)
        return;
    
    PostOrder(root.Left, values);
    PostOrder(root.Right, values);
    values.Add(root.Value);
}
```

### PostOrder - Iterative

```c#
public List<T> PostOrder(Node<T> root)
{
    if (root == null)
        return new List<T>();

    Stack<Node<T>> stack = new Stack<Node<T>>();
    List<T> values = new List<T>();

    stack.Push(root);

    while (stack.Count != 0)
    {
        Node<T> current = stack.Pop();
        values.Insert(0, current.Value);

        if (current.Left != null)
            stack.Push(current.Left);

        if (current.Right != null)
            stack.Push(current.Right);
    }

    return values;
}
```

### BreadthFirst - Recursive

```c#
public List<T> BreadthFirst(Node<T> root)
{
    if (root == null)
        return new List<T>();

    List<List<T>> values = new List<List<T>>();
    BreadthFirst(root, values, 0);
    return MergeLists(values);
}

private void BreadthFirst(Node<T> node, List<List<T>> values, int level)
{
    if (node == null)
        return;

    if (values.Count == level)
        values.Add(new List<T>());

    values[level].Add(node.Value);

    BreadthFirst(node.Left, values, level + 1);
    BreadthFirst(node.Right, values, level + 1);
}
```

### BreadthFirst - Iterative

```c#
public List<T> BreadthFirst(Node<T> root)
{
    if (root == null)
        return new List<T>();

    List<T> values = new List<T>();
    Queue<Node<T>> queue = new Queue<Node<T>>();

    queue.Enqueue(root);

    while (queue.Count != 0)
    {
        Node<T> node = queue.Dequeue();

        if (node.Left != null)
            queue.Enqueue(node.Left);
        if (node.Right != null)
            queue.Enqueue(node.Right);

        values.Add(node.Value);
    }

    return values;
}
```

### Add - BST, Iterative

```c#
public void Add(T value)
{
    if (Contains(value))
        throw new Exception("The value is already present in the tree.");
    else
        Values.Add(value);

    Node<T> parent = Root;
    Node<T> child= Root;

    while (parent != null)
    {
        child = parent;
        parent = Comparer<T>.Default.Compare(value, parent.Value) < 0 ? parent.Left : parent.Right;
    }

    if (Root == null)
        Root = new Node<T>(value);
    else if (Comparer<T>.Default.Compare(value, child.Value) < 0)
        child.Left= new Node<T>(value);
    else
        child.Right = new Node<T>(value);
}
```

---

## Link to Code

* [Trees Library - Binary Tree](Trees/BinaryTree.cs)
* [Trees Library - Binary Search Tree](Trees/BinarySearchTree.cs)

---

## References

* [Code Fellows - Trees](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-15/resources/Trees.html)
* [Code Fellows - Implementation: Trees](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-15/LAB)
* [Code Fellows - Breadth-First Traversal](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-17/)
* [tutorialpoints - Depth First Traversal](https://www.tutorialspoint.com/data_structures_algorithms/depth_first_traversal.htm)
* [tutorialpoints - Breadth First Traversal](https://www.tutorialspoint.com/data_structures_algorithms/breadth_first_traversal.htm)
* [Interview Cake - Binary Tree](https://www.interviewcake.com/concept/python/binary-tree?)
* [LeetCode - Binary Tree](https://leetcode.com/explore/learn/card/data-structure-tree/)
* [LeetCode - Binary Search Tree](https://leetcode.com/explore/learn/card/introduction-to-data-structure-binary-search-tree/)
* [LeetCode - N-ary Tree](https://leetcode.com/explore/learn/card/introduction-to-data-structure-binary-search-tree/)
* [LeetCode - Binary Tree Preorder Traversal](https://leetcode.com/problems/binary-tree-preorder-traversal/)
* [LeetCode - Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/)
* [LeetCode - Binary Tree Postorder Traversal](https://leetcode.com/problems/binary-tree-postorder-traversal/)
* [LeetCode - Insert into a Binary Search Tree](https://leetcode.com/problems/insert-into-a-binary-search-tree/)
* [LeetCode - Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/)
* [DONT CODE TIRED - Testing for Thrown Exceptions in xUnit.net](http://dontcodetired.com/blog/post/Testing-for-Thrown-Exceptions-in-xUnitnet)

---

## Change Log

* 2.0: *Binary Tree and Binary Search Tree with traversals implemented* - 27 December 2020
* 1.0: *Code Challenge 15 and 17 completed* - 09 November 2019
