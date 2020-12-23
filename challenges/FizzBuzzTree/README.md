# Code Challenge 16 FizzBuzz Tree

## FizzBuzz Tree
*Author: Kyungrae Kim*

---

### Problem Domain
Write a function called FizzBuzzTree which takes a tree as an argument.  
Without utilizing any of the built-in methods available to your language, determine weather or not the value of each node is divisible by 3, 5 or both, and change the value of each of the nodes:
* If the value is divisible by 3, replace the value with “Fizz”
* If the value is divisible by 5, replace the value with “Buzz”
* If the value is divisible by 3 and 5, replace the value with “FizzBuzz”

Return the tree with its new values.

---

### Inputs and Expected Outputs
| Input | Expected Output |
| :----------- |:----------- |
| tree | tree with new values (Fizz, Buzz, or FizzBuzz) |

---

### Approach
1. Create a non-resursive method that creates a reference node to the Root and returns a tree with new values after invoking the resursive helper method FizzBuzzTree()
2. From the recursive helper method that:
    1. Checks if the node value meets any of FizzBuzz conditions and update the value accordingly
    2. Invokes FizzBuzz method until there is no more LeftChild node
    3. Invokes FizzBuzz method until there is no more RightChild node

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| FizzBuzzTree(tree) | O(n) | O(1) |

---

### Solution
#### FizzBuzz(tree)
```C#
public static BinaryTree<object> FizzBuzzTree(BinaryTree<object> tree)
{
    Node<object> node = tree.Root;

    FizzBuzzTree(tree, node);

    return tree;
}
```

#### FizzBuzz(tree, node) - Helper Function
```C#
static void FizzBuzzTree(BinaryTree<object> tree, Node<object> node)
{
    if (Convert.ToInt32(node.Value) % 15 == 0)
    {
        node.Value = "FizzBuzz";
    }
    else if (Convert.ToInt32(node.Value) % 3 == 0)
    {
        node.Value = "Fizz";
    }
    else if (Convert.ToInt32(node.Value) % 5 == 0)
    {
        node.Value = "Buzz";
    }

    if (node.LeftChild != null)
    {
        FizzBuzzTree(tree, node.LeftChild);
    }
    if (node.RightChild != null)
    {
        FizzBuzzTree(tree, node.RightChild);
    }
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/FizzBuzzTree/FizzBuzzTree/Program.cs

---

### Whiteboard Visual
![fizzbuzz-tree](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/fizzbuzz-tree-rotated.jpg)

---

### Change Log
1.0: *Code Challenge 16 completed, Initial Submission* - 10 Nov 2019
