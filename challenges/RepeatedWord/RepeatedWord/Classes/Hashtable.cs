﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord.Classes
{
    public class Hashtable
    {
        private static int tableSize = 1014;
        private Node[] Table { get; set; }

        public Hashtable()
        {
            Table = new Node[tableSize];
        }

        public void Add(string key, string value)
        {
            int index = Hash(key);
            Node newNode = new Node(key, value);

            if (Table[index] == null)
            {
                Table[index] = newNode;
            }
            else
            {
                Node current = Table[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(key, value);
            }
        }

        public Node Get(string key)
        {
            int index = Hash(key);
            Node current = Table[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public bool Contains(string key)
        {
            int index = Hash(key);
            Node current = Table[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        private int Hash(string key)
        {
            int hash = 0;

            foreach (int character in key)
            {
                hash += character;
            }

            return hash * 599 % 1014;
        }
    }
}
