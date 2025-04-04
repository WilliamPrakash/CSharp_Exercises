using CSharp_Exercises.Data_Structures;
using CSharp_Exercises.LeetCode;


/* Objects */
Easy_Problems easyProblems = new Easy_Problems();
Medium_Problems mediumProblems = new Medium_Problems();

/* Data Structores */
Queue_Custom<string> q = new Queue_Custom<string>(10);
q.enqueue("aa");
q.enqueue("oop");
q.enqueue("REST");
q.enqueue("LINQ");
q.printQueue();
q.dequeue();
q.printQueue();
