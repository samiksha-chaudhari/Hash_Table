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
        public HashTable(int size) //constuctor
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
        /// <summary>
        /// method to add data in list
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="value"></param>
        public void Add(K Key, V value)
        {
            int position = GetPosition(Key);
            LinkedList<KValue<K, V>> linkedlist = GetLinkedList(position);
            KValue<K, V> item = new KValue<K, V>() { Key = Key, Value = value };
            linkedlist.AddLast(item);
        }
        /// <summary>
        /// method to create linked list
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
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
        /// <summary>
        /// method to get value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
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
        /// <summary>
        /// method to delete given index word
        /// </summary>
        /// <param name="key"></param>
        public void Delete(K key)
        {
            int position = GetPosition(key);
            LinkedList<KValue<K, V>> linkedList = GetLinkedList(position);
            bool Found = false;
            KValue<K, V> foundItem = default(KValue<K, V>);
            foreach (KValue<K, V> word in linkedList)
            {
                if (word.Key.Equals(key))
                {
                    Found = true;
                    foundItem = word;
                }
            }
            if (Found)
                linkedList.Remove(foundItem);
        }

    }
}