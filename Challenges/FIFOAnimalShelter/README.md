# Code Challenge 12 FIFO Animal Shelter

## FIFO Animal Shelter
*Author: Kyungrae Kim*

---

### Problem Domain
Create a class called `AnimalShelter` which holds only dogs and cats. The shelter operates using a first-in, first-out approach.

Implement the following methods:
1. Enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
2. Dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

---

### Inputs and Expected Outputs
#### Enqueue(animal)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| [Cat] -> [Dog] | Dog` | [Dog`] -> [Cat] -> [Dog] |
#### Dequeue(pref)
| Input | Expected Output  | Internal State|
| :----------- |:-- |:----------- |
| [Cat] -> [Dog] | "cat" | [Cat] |

---

### Approach
#### Enqueue(animal)
1. While stackOne is not empty, pop animals from stackOne then push to stackTwo
2. Push the parameter animal to stackOne
3. While stackTwo is not empty, pop animals from stackTwo and push the animals to stackOne
#### Dequeue()
1. If pref is "dog", while peek of stackOne is not a dog, pop animmals from stackOne then push to stackTwo
2. If pref is "cat", while peek of stackOne is not a cat, pop animmals from stackOne then push to stackTwo
3. If pref is not "dog" or "cat", return null
4. Pop an animal from stackOne then save it as a variable animal
5. Pop animmals from stackTwo then push to stackOne
6. Return the variable animal

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| Enqueue(animal) | O(n) | O(1) |
| Dequeue(pref) | O(n) | O(1) |

---

### Solution
#### Enqueue(value)
```C#
public void Enqueue(Animal animal)
{
    while (stackOne.Count != 0)
    {
        stackTwo.Push(stackOne.Pop());
    }

    stackOne.Push(animal);

    while (stackTwo.Count != 0)
    {
        stackOne.Push(stackTwo.Pop());
    }
}
```
#### Dequeue()
```C#
public Animal Dequeue(string pref)
{
    if(pref == "dog")
    {
        while (stackOne.Peek().GetType() != typeof(Dog))
        {
            stackTwo.Push(stackOne.Pop());
        }
    }
    else if (pref == "cat")
    {
        while (stackOne.Peek().GetType() != typeof(Cat))
        {
            stackTwo.Push(stackOne.Pop());
        }
    }
    else if (pref != "dog" || pref != "cat")
    {
        return null;
    }

    Animal animal = stackOne.Pop();

    while (stackTwo.Count != 0)
    {
        stackOne.Push(stackTwo.Pop());
    }

    return animal;
}
```

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/challenges/FIFOAnimalShelter/FIFOAnimalShelter/Classes/AnimalShelter.cs

---

### Whiteboard Visual
![fifo-animal-shelter](https://github.com/jeremymaya/data-structures-and-algorithms-c-sharp/blob/master/assets/fifo-animal-shleter.jpg)

---

### Change Log
1.0: *Code Challenge 12 completed, Initial submission* - 30 Oct 2019
