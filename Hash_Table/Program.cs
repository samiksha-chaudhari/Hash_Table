using System;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hash table");
            HashTable<string, string> hash = new HashTable<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value : {0} ", hash5);
            string hash2 = hash.Get("2");
            Console.WriteLine("2nd index value : {0} ", hash2);
        }
    }
}
