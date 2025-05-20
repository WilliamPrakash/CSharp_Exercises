using CSharp_Exercises.Concepts;
using CSharp_Exercises.DAL;
using CSharp_Exercises.Data_Structures;
using CSharp_Exercises.Leet_Code;
using CSharp_Exercises.Sorting_Algorithms;

//Medium_Problems mp = new Medium_Problems();
//mp.Subsets([1, 2, 3]);
class Program
{
    public static void Main(string[] args)
    {
        HashTable_Custom<string, string> hashTable = new HashTable_Custom<string, string>(10);
        KeyValue<string, string> keyValue = new KeyValue<string, string>();
        keyValue.Key = "unicode";
        keyValue.Value = "ascii";
        hashTable.Add(keyValue);
    }
}