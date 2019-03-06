# Ex.3 Implementing generic stack and dynamic array data type

## Task 1: Generic types
- Update the previous implementation of Stack with a use of generic type.
- Initialize stack of strings and stack of ints and try them out.
## Task 2: Indexers and properties
- Implement a dynamic array class:
	- Data will be stored as nullable integer array.
	- Constructor with implicit maxSize (e.g. 5).
	- ToString method returns **all** of the **items** inside of the array.
	- Implement a method that sums the numbers inside of the array, the resulting sum is passed into method as **out** parameter.
	- Implement a method that adds a number from selected index to number passed into a method as **reference**.
	- State property, that mirrors the current state of the array.
	- Indexer: 
		- getter - obvious,
		- setter - array can grow if neccessary.
	- Max size property:
		- getter - obvious,
		- setter - array can't shrink, an attempt throws exception.
	- Current size property:
		- getter - obvious
## Task 3: Testing application
- Read two arguments from command line:
	- size of the dynamic array
	- seed mode
- Prints the array and it's sum.
- Iteratively sets elements of the array to **null** and prints the current size and state.

### Expected output for params **5** and **0**
    Seed mode: Random.
    This is how the array looks like: 1, 0, 1, 7, 6,
    This is the sum of array elements: 15
    ------------------------------------------------------
    Current state of array is Full
    Current size of array is 5
    ------------------------------------------------------
    Current state of array is PartiallyFilled
    Current size of array is 4
    ------------------------------------------------------
    Current state of array is PartiallyFilled
    Current size of array is 3
    ------------------------------------------------------
    Current state of array is PartiallyFilled
    Current size of array is 2
    ------------------------------------------------------
    Current state of array is PartiallyFilled
    Current size of array is 1
    ------------------------------------------------------
    Current state of array is Empty
    Current size of array is 0
# Class diagram for Dynamic array
![alt text](https://github.com/Polyster/pl2/blob/master/exercises/03/ConsoleApp/DynamicArrayDiagram.png)
# Seed mode enum
![alt text](https://github.com/Polyster/pl2/blob/master/exercises/03/ConsoleApp/SeedModeEnum.png)
