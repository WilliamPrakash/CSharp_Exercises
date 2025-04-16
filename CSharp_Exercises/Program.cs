using CSharp_Exercises.Data_Structures;
using CSharp_Exercises.LeetCode;


/* Objects */
Easy_Problems easyProblems = new Easy_Problems();
Medium_Problems mediumProblems = new Medium_Problems();

/* Data Structores */
Deque<int> dairyQueen = new Deque<int>(10);
dairyQueen.enqueueFront(5);
dairyQueen.enqueueFront(2);
dairyQueen.enqueueFront(17);
dairyQueen.enqueueFront(8);
dairyQueen.enqueueFront(14);
// 5 2 17 8 14 blank blank blank blank blank
dairyQueen.enqueueBack(22);
dairyQueen.enqueueBack(1);
dairyQueen.enqueueBack(13);
dairyQueen.enqueueBack(30);
dairyQueen.enqueueBack(7);
// 5 2 17 8 14 7 30 13 1 22
dairyQueen.printDeque();

dairyQueen.dequeueFront();
dairyQueen.dequeueFront();
dairyQueen.dequeueFront();

dairyQueen.printDeque();
