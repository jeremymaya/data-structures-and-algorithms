# Code Challenge 02 Array Shift

## Insert Shift Array
*Author: Kyungrae Kim*

---

### Problem Domain
Write a function called `insertShiftArray` which takes in an array and the value to be added. Return an array with the new value added at the middle index.

---

### Inputs and Expected Outputs

| Input | Expected Output |
| :----------- | :----------- |
| [2 , 4, 6, 8], 5 | [2 , 4, 5, 6, 8] |
| [4, 8, 15, 23, 42], 16 | [4, 8, 15, 16, 23, 42] |
| [ ], 2 | [2] |
| [1], 4 | [1, 4] |

---

### Approach
1. Determine the middle index
2. Create a new int array
3. Use a for loop to iterate over the new int array and assign a value with the following condition
    a. If i < middle, value of the new array at index i euqals to the value of the old array at index i
	b. If i == middle, value of the new array at index i equal to the value to be added
	c. If i > middle, value of the new array at index i euqals to the value of the old array at index  i - 1
4. Return the new int array

### Efficiency
N/A

---

### Solution
```C#
public static int[] insertShiftArray(int[] arr, int num)
{
    int[] newArr = new int[(arr.Length + 1)];
    double middle= Math.Ceiling(arr.Length / 2.0);

    for (int i = 0; i <= arr.Length; i++)
    {
        if (i < middle)
        {
            newArr[i] = arr[i];
        }
        else if (i == middle)
        {
            newArr[i] = num;
        }
        else if (i > middle)
        {
            newArr[i] = arr[i - 1];
        }
    }
    return newArr;
}
```

---

### Link to Code



---

### Whiteboard Visual
![Image 1](https://via.placeholder.com/750x500)


---

### Change Log
1.1: *Code Challenge 02 Completed, Initial submission* - 17 Oct 2019  