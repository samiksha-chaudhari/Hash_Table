using System;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hash table");
            /* HashTable<string, string> hash = new HashTable<string, string>(5);
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
            */
            int i = 0;

            string samplePara = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = samplePara.Split(" ");
            HashTable<int, string> hash = new HashTable<int, string>(para.Length);

            foreach (string word in para)
            {
                hash.Add(i, word);  //adding each word in para to list
                i++;
            }

           hash.Delete(17);
            for (i = 0; i < para.Length; i++) //for each word in para display index position
            {
                string v = hash.Get(i);
                Console.WriteLine($"Word {v} is at {i} index");
            }

        }
    }
}
