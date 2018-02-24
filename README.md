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

## Hash Tables

- Similar to implementation of dictionary, contains key and value arguments.
- Every value is being hashed with hash function which is mathematical calculation.
- Key is reduced by taking the remainder of `H(value) mod m` (where `m` is the size of the hash table and `H` is the hashing function).
- Two distinct keys will occasionally hash to the same value, causing a collision.
- There are different ways to handle collision, one way is to put the new value next free available place in hash table, and second way to handle collision is to use linked list to save the values.

## Binary Search Trees

- Each node has a value, *All* the values in the left subtree are smaller than the node's value, *All* those in the right side of the node are bigger.
- Searching is `O(log(n))`.
- The minimum value is at the most left node in the tree, the maximum value is in the most right node in the tree.
- The best tree height can be `log(n)` and the worse height of the tree can be `n`, depend on the order of insertion of values.

## AVL Tree

- The height of the tree is always `log(n)`.
- Every time the balance is broken while performing insertion or deletion the tree will rotate his leafs and will keep the balance.
- Harder to implement than BST.

## Heap

- Simple data structure to keep the chosen value ( min heap or max heap ) to be at the top of the structure.
- Heap can be drawn like a tree but it's actually implemented by simple array.
- The positions of the parent and children of the key at position `k` is for the parent. The left child of `k` sits in position `2k` and the right child in `2k + 1`.
- Harder to maintain since every movement of "node" is actually moving it from array, and it breaks the structure.
- Searching will take `log(n)`.
- All we know in a min heap is that the child is larger than the parent, we don't know about the relationship between the children, Same way about max heap.
- To insert an item we add it at the end of the array, and then bubble it up if it's smaller that its parent (switch between the parent and the child), until we reach a smaller parent or the root of the tree. This insertion in `O(log(n))`.
- The minimum of the tree is the root. To extract it, we remove the root, and replace it with the last element in the array (bottom right most leaf). We then check if it's smaller than both its children. If not, we perform a swap with the smallest child, and bubble the swap down recursively all the way until the criteria is met. This is called *"heapify"*. This operation requires `O(log(n))`.
- To build a heap from an array, we iterate from the last element to the first and call heapify on each, This costs about `O(n)`.

## Graphs

- A Graph is comprised of vertices `V` (the points) and edges `E` (the lines connecting the points).
- Assume `n` is the number of vertices and `m` is the number of edges.
- Directed graphs: A road that cars can drive in one way.
- Undirected graphs: A road that cars can drive in both directions.
- Data structures:
    - This can be implemented by simple linked list which the key is the number of the node, and the list of the node is the vertices it's connected to.
    - Also can be implemented by actual graph with list of pointers to other nodes, and actually travel on the graph and on the pointers, harder implementation.