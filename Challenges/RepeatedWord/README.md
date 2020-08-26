# Code Challenge 31 Repeated Word

## Repeated Word
*Author: Kyungrae Kim*

---

### Problem Domain
Find the first repeated word in a book by writing a function that accepts a lengthy string parameter. The function should return the first word to occur more than once in that provided string.

---

### Inputs and Expected Outputs
| Input | Expected Output |
| :----------- |:----------- |
| "Once upon a time, there was a brave princess who..." | "a" |
| "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..." | "it" |
| "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..." | "summer" |

---

### Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| RepeatedWord | O(n) | O(n) |

---

### Solution
```C#
public static string RepeatedWord(string phrase)
{
    string[] words = phrase.Split(' ');

    Hashtable hashtable = new Hashtable();

    for (int i = 0; i < words.Length; i++)
    {
        // Source: https://www.geeksforgeeks.org/removing-punctuations-given-string/
        string word = Regex.Replace(words[i].ToLower(), @"[^\w\d\s]", "");

        if (hashtable.Contains(word))
        {
            return hashtable.Get(word).Value;
        }

        hashtable.Add(word, word);
    }

    return "No Repeated Word";
}
````

---

### Link to Code
https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/challenges/RepeatedWord/RepeatedWord/Program.cs

---

### Whiteboard Visual
![repeated-word](https://github.com/jeremymaya/data-structures-and-algorithms-c-/blob/master/assets/repeated-word.jpg)

---

### Credit
[GeeksforGeeks](https://www.geeksforgeeks.org/removing-punctuations-given-string/)

### Change Log
1.0: *Code Challenge 31 started, Initial Submission* - 28 Nov 2019
