using System;
using System.Text.Encodings;

namespace CSharp_Exercises.Data_Structures;

// Source: https://stackoverflow.com/questions/625947/what-is-an-example-of-a-hashtable-implementation-in-c

public struct KeyValue<K, V>
{
	public K Key { get; set; }
	public V Value { get; set; }
}

public class HashTable_Custom<K, V>
{
	private int size;
	private KeyValue<K, V>[] hashTable;

	public HashTable_Custom(int size)
	{
		this.size = size;
		this.hashTable = new KeyValue<K, V>[size];
	}

	public void Add(KeyValue<K, V> keyValue)
	{
		// Generate hash code
		int hash = CreateHash(keyValue.Key.ToString());
		Console.WriteLine(hash);
	}

	public int CreateHash(string hashMe)
	{
		int hash = -1;

		/* https://stackoverflow.com/questions/2624192/good-hash-function-for-strings
		Usually hashes wouldn't do sums, otherwise stop
		and pots will have the same hash.
		Generally hashs take values and multiply it by a
		prime number (makes it more likely to generate
		unique hashes) So you could do something like: */
		char[] hashMeChars = hashMe.ToString().ToCharArray();
		for (int i = 0; i < hashMeChars.Length; i++)
		{
			byte[] b = System.Text.Encoding.UTF8.GetBytes( hashMeChars[i].ToString() );
			//hash = 
			Console.WriteLine(b);
		}

		// Check this.hashTable for index availability

        return hash;
    }
}
