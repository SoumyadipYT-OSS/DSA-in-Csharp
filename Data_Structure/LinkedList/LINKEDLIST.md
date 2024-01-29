# Linked List

![MasterHead](https://i1.faceprep.in/Companies-1/types-of-linked-list.png)

<img width="850" height="400" src="https://scaler-topics-articles-md.s3.us-west-2.amazonaws.com/traversal-operation-of-linked-list.gif">

<span style = "font-size: 20px; font-family: Arial"><strong> What is Linked List? </strong></span> <br>
A linked list is a linear data structure where each element is a separate object, known as a node. Each node contains some data and points 
to the next node in the structure, forming a swquence.

This structure allows for efficient insertion or removal of elements from any position as only the link is needed to be modified to point 
to some other element.


<strong> The Node </strong> <br>
Each node in its basic contains has two portions: the data, and references to the next node in the sequences.
In, C#(sharp) we define Node as a structure that has the data and the reference pointer information. <br>
![ScreenshotNodeCreate](https://github.com/SoumyadipYT-OSS/DSA-in-Csharp/assets/94290293/847ea71d-b676-40bd-a3af-3bbf9bac9420) 
<br>

<strong> • Advantages over an array </strong> <br>
	- Not fixed in size: Linked lists are ot fixed in size unlike that of arrays, hence they can grow and shrink depending on the data to be inserted.
    Only the amount of memory required to store the data is used. <br>
	- Efficient Insertion and Deletion: Insertion and deletion are efficient and take constant time as only the links are manipulated, not the actual elements. <br>


<strong> • Disadvantages over an array </strong> <br>
	- Slightly more memory usage: as each element has to store its data along with the reference information.
	- Sequential Access: Nodes in a linked list must be read in order from the beginning as linked lists are inherently sequential access.
	- Difficult reverse traversal: Difficulties arise in linked lists when it comes to reverse traversing in a singly linked list.
	This can be resolved using doubly linked lists, but this again increases memory as we have to store the previous reference pointer.

