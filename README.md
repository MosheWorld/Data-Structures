# Data-Structures
This file will contain all the data structures exists, from simple arrays to complex AVL trees and more.
Every data structure will be implemented in generics, and it will be written in C# in regular console applications.

## Stack & Queue

- Stacks – LIFO ( Last in first out ).
    - Very efficient, good to use when the order doesn't matter.
    - There are different ways to implement stack, not only one way.
- Queues – FIFO ( First in first out )
    - Average "waiting time" for jobs is identical for FIFO and LIFO. Maximum time varies (FIFO minimizes max waiting time).
    - Harder to implement than implement stack, we will use it when the order is necessary.
- Stacks and Queues can be implemented by simple static array, or dynamic array, also with linked lists.

## Linked List

- Single link – Each elements links to the next one.
- Double link – Each elements links to the next and previous elements.
- Better approach with memory than regular static array.
- Methods like insert or delete are way more simple than arrays.
- Randomly allocated at memory which means getting element from linked list can take bad complexity. `O(n)`
- Less good with memory usage since we require more fields to save for each node.



 - Hash Table.
 - Binary Search Tree.
 - AVL Tree.
 - Min Heap & Max Heap.