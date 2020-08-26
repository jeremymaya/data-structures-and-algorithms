# Code Challenge 32 Tree Intersection

## Tree Intersection
*Author: Kyungrae Kim*

---

### Problem Domain
Find common values in 2 binary trees by writing a function called `tree_intersection` that takes two binary tree parameters and return a set of values found in both trees.

---

### Inputs and Expected Outputs
| Input | Expected Output |
| :----------- |:----------- |
| TreeOne and TreeTwo | Matching values |

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| TreeIntersection() | O(n^2) | O(n) |

---

### Solution
#### TreeIntersection
```C#
public static List<int> TreeIntersection(BinaryTree<int> treeOne, BinaryTree<int> treeTwo)
{
    List<int> listOne = new List<int>();
    TreeIntersection(treeOne.Root, listOne);
    List<int> listTwo = new List<int>();
    TreeIntersection(treeTwo.Root, listTwo);

    int outer;
    int inner;

    if (listOne.Count > listTwo.Count)
    {
        outer = listOne.Count;
        inner = listTwo.Count;
    }
    else
    {
        outer = listTwo.Count;
        inner = listOne.Count;
    }


    List<int> listThree = new List<int>();
    for (int i = 0; i < outer; i++)
    {
        for (int j = 0; j < inner; j++)
        {
            if (listOne[i] == listTwo[j])
            {
                listThree.Add(listOne[i]);
            }
        }
    }

    return listThree ;
}
```
#### TreeIntersection (Resursive helper method)

```C#
static void TreeIntersection(Node<int> node, List<int> list)
{
    list.Add(node.Value);
    if (node.LeftChild != null)
    {
        TreeIntersection(node.LeftChild, list);
    }
    if (node.RightChild != null)
    {
        TreeIntersection(node.RightChild, list);
    }
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/TreeIntersection/TreeIntersection/Program.cs

---

### Whiteboard Visual
![tree-intersection](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/tree-intersection.jpg)

---

### Change Log
1.0: *Code Challenge 32 completed, Second Submission* - 29 Nov 2019
1.0: *Code Challenge 32 completed, Initial Submission* - 27 Nov 2019