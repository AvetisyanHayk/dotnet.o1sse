using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening10
{
    class Waardenlijst<K, T>
    {
        public K[] Keys { get; set; }
        public T[] Values { get; set; }

        public Waardenlijst(int length)
        {
            Init(length);
        }
        public int Count { get; set; }

        public void Add(K key, T value)
        {
            int keyIndex = Array.IndexOf(Keys, key);
            if (keyIndex >= 0)
            {
                Values[keyIndex] = value;
            }
            else
            {
                Keys[Count] = key;
                Values[Count] = value;
                Count++;
            }
        }


        public T this[K key]
        {
            get
            {
                int keyIndex = Array.IndexOf(Keys, key);
                if (keyIndex >= 0)
                {
                    return Values[keyIndex];
                }
                return default(T);
            }
            
        }

        public void Remove(K key)
        {
            int keyIndex = Array.IndexOf(Keys, key);
            if (keyIndex >= 0)
            {
                Keys[keyIndex] = default(K);
                Values[keyIndex] = default(T);
                Count--;
            }
        }

        public void Clear()
        {
            Init(Keys.Length);
            Count = 0;
        }

        private void Init(int length)
        {
            Keys = new K[length];
            Values = new T[length];
        }

    }
}
