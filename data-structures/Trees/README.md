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

---

## Link to Code

* [Trees Library - Binary Tree](Trees/BinaryTree.cs)
* [Trees Library - Binary Search Tree](Trees/BinarySearchTree.cs)

---

## References

* [Code Fellows - Trees](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-15/resources/Trees.html)
* [Code Fellows - Implementation: Trees](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-15/LAB)
* [Code Fellows - Breadth-First Traversal](https://codefellows.github.io/common_curriculum/data_structures_and_algorithms/Code_401/class-17/)
* [Interview Cake - Binary Tree](https://www.interviewcake.com/concept/python/binary-tree?)
* [LeetCode - Binary Tree](https://leetcode.com/explore/learn/card/data-structure-tree/)
* [LeetCode - Binary Search Tree](https://leetcode.com/explore/learn/card/introduction-to-data-structure-binary-search-tree/)
* [LeetCode - N-ary Tree](https://leetcode.com/explore/learn/card/introduction-to-data-structure-binary-search-tree/)
* [LeetCode - Binary Tree Preorder Traversal](https://leetcode.com/problems/binary-tree-preorder-traversal/)
* [LeetCode - Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/)
* [LeetCode - Binary Tree Postorder Traversal](https://leetcode.com/problems/binary-tree-postorder-traversal/)
* [LeetCode - Insert into a Binary Search Tree](https://leetcode.com/problems/insert-into-a-binary-search-tree/)
* [DONT CODE TIRED - Testing for Thrown Exceptions in xUnit.net](http://dontcodetired.com/blog/post/Testing-for-Thrown-Exceptions-in-xUnitnet)

---

## Change Log

* 2.0: *Binary Tree and Binary Search Tree with traversals implemented* - 27 December 2020
* 1.0: *Code Challenge 15 and 17 completed* - 09 November 2019
