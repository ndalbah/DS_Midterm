# Data Structures - Midterm (Sorting, Recursion, Data Structures)
## Part 1
### Sorting algorithm
Create a Console Application in C# that implements the given sorting algorithm, which consists of two steps:
1. Preparing the array before sorting.
2. Sorting the array.
 
Ensure that your implementation follows the logic shown in the resources and produces the
correct sorted output.

## Part 2
### Recursion
Create a Console Application in C# that implements the function Recursive (string) based on the following execution steps
<img width="1332" height="740" alt="Screenshot 2025-10-07 183347" src="https://github.com/user-attachments/assets/377741cd-905f-4057-886b-cbb8864f29f5" />

> [!NOTE]
> You can use the method Substring(int, int, int) of class String

## Part 3
### Implement a Data Structure
Create a Console Application in C# that provides an Array-Based Implementation of a hybrid data structure MIN_MAX
that combines the usefulness of both a QUEUE (FIFO) and a STACK (LIFO), it provides
constant time retrieval of both the minimum and maximum elements in it. 

The minimum
element is retrieved from the Front and the maximum element is retrieved from the back.
It helps to access the min/max elements in a faster way.

1. Create a class MIN_MAX, add the following fields:
   - ```int [ ] array```
   - ```int front```
   - ```int last```
   - ```int count```

Implement with the following operations and write the complexity O of each
operation in the comments

2. void Add (int item): We always insert at the back of the array. Then, move the item forward to find its good position to keep the array sorted.
3. int Remove_MIN (): Remove and return the FRONT element.
4. int Remove_MAX (): Remove and return the LAST element.
5. Item Peek_MIN( ): Return the FRONT element.
6. Item Peek_MAX( ): Return the LAST element.
7. bool isEmpty()
8. bool isFull()
