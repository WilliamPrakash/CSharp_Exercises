using System;
using System.Linq.Expressions;
using System.Text.Encodings;

namespace CSharp_Exercises.Data_Structures;

// Source: https://stackoverflow.com/questions/625947/what-is-an-example-of-a-hashtable-implementation-in-c

/* Structure (struct) types are value types: they contain an instance of the type.
"Type" here being self-defined by what's in the struct.
Value types are stores on the stack */
public struct KeyValue<K, V>
{
	public required K Key { get; set; }
	public required V Value { get; set; }
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
        if (keyValue.Key == null)
        {
			Console.WriteLine("Empty key.");
            return;
        }

        // Attempt to convert key to string.
        string? keyString;
        try
        {
			keyString = keyValue.Key.ToString();
			if (string.IsNullOrEmpty(keyString))
			{
				Console.WriteLine("Empty string.");
				return;
			}
        }
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			throw new Exception(keyValue.Key + " cannot be converted to string");
		}

        // Generate hash index
        int hashIndex = default(int);
        hashIndex = CreateHash(keyString);
        
        //Console.WriteLine(keyString);
	}

	public int CreateHash(string key)
	{
		int hash = -1;
		// Convert string -> base64Encode to get byte array then convert that byte array to ascii?
		//char[] hashMeChars = hashMe.ToString().ToCharArray();
		byte[] byteArray = System.Text.Encoding.UTF8.GetBytes( key.ToString().ToCharArray() );

        /*for (int i = 0; i < hashMeChars.Length; i++)
		{
			byte[] b = System.Text.Encoding.UTF8.GetBytes( hashMeChars[i].ToString() );
			//hash = 
			Console.WriteLine(b);
		}*/

		// Check this.hashTable for index availability

        return hash;
    }
}
