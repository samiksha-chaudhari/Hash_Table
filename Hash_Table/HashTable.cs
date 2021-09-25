using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Table
{
    class HashTable<K, V>
    {
        public int size;
        public struct KValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }

        public LinkedList<KValue<K, V>>[] items;
        public HashTable(int size)
        {
            this.size = size;
            this.items = new LinkedList<KValue<K, V>>[size];

        }
        /// <summary>
        /// method to get array position
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public void Add(K Key, V value)
        {
            int position = GetPosition(Key);
            LinkedList<KValue<K, V>> linkedlist = GetLinkedList(position);
            KValue<K, V> item = new KValue<K, V>() { Key = Key, Value = value };
            linkedlist.AddLast(item);
        }
        
        public LinkedList<KValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        
        public V Get(K key)
        {
            int position = GetPosition(key);
            LinkedList<KValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

    }
}