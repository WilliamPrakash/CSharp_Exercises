using CSharp_Exercises.Data_Structures;
using CSharp_Exercises.LeetCode;


/* Objects */
Easy_Problems easyProblems = new Easy_Problems();
Medium_Problems mediumProblems = new Medium_Problems();

Deque<int> dairyQueen = new Deque<int>(10);
dairyQueen.enqueueFront(5);
dairyQueen.enqueueFront(2);
dairyQueen.enqueueFront(17);
dairyQueen.enqueueFront(8);
dairyQueen.enqueueFront(14);
dairyQueen.enqueueFront(101);
dairyQueen.enqueueFront(73);
// 5 2 17 8 14 101 73 blank blank blank
dairyQueen.enqueueBack(13);
dairyQueen.enqueueBack(30);
dairyQueen.enqueueBack(7);
dairyQueen.enqueueBack(17947);
// 5 2 17 8 14 101 73 7 30 13
dairyQueen.printDeque();

dairyQueen.dequeueFront();
dairyQueen.dequeueFront();
dairyQueen.dequeueBack();

dairyQueen.printDeque();
