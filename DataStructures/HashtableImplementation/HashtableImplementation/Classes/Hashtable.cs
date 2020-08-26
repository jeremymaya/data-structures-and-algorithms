using System;
namespace HashtableImplementation.Classes
{
    public class Hashtable
    {
        private static int tableSize = 1014;
        private Node[] Table { get; set; }
        
        public Hashtable()
        {
            Table = new Node[tableSize];
        }

        /// <summary>
        /// Stores the value parameter at the hashed index in the hashtable
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
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

        /// <summary>
        /// Retrieves a node with the matching key
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Node with the matching key and the associated value</returns>
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

        /// <summary>
        /// Checks if the hashtable contains a node with the matching key
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>True if there is a node with the matching key and False if there is no node matching the key</returns>
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

        /// <summary>
        /// Turns a key into an integer
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Hash code</returns>
        public int Hash(string key)
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
