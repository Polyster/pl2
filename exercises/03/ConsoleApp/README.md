# Ex.3 Implementing generic stack and dynamic array data type

## Task 1: Generic types
- Update the previous implementation of Stack with a use of generic type.
- Initialize stack of strings and stack of ints and try them out.
## Task 2: Indexers and properties
- Implement a dynamic array class:
	- Data will be stored as nullable integer array.
	- Constructor with implicit maxSize (e.g. 5).
	- ToString method returns **all** of the **items** inside of the array.
	- Implement a method that sums the numbers inside of the array, the resulting sum is passed into method as out parameter.
	- Implement a method that adds a number from selected index to number passed into a method as reference.
	- State property, that mirrors the current state of the array.
	- Indexer: 
		- getter - obvious,
		- setter - data backing field can grow if neccessary.
	- Current size property:
		- getter - obvious,
		- setter - data backing field can't shrink, an attempt throws exception.
## Task 3: Testing application
- Read two arguments from command line:
	- size of the dynamic array
	- seed mode
- Prints the array and it's sum.
- Iteratively sets elements of the array to **null** and prints the current size and state.
# Class diagram for Dynamic array
![alt text](https://github.com/Polyster/pl2/blob/master/exercises/03/ConsoleApp/DynamicArrayDiagram.png)

# Seed mode enum
![alt text](https://github.com/Polyster/pl2/blob/master/exercises/03/ConsoleApp/SeedModeEnum.png)
