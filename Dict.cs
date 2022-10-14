namespace sixthLec
{
    public class Dict<K,V>
    {
        List<Pair<K,V>> pairs = new List<Pair<K, V>>();
        public V Get(K k)
        {
            foreach(Pair<K,V> pair in pairs) 
            { 
                if (pair.value1.Equals(k))
                {
                    return pair.value2;
                }
            }
            throw new KeyNotFoundException();
        }
        public void Put(K key, V value)
        {
            #region overskriv-existing
            // overskriv existerende key
            Pair<K, V> removeMe = null;
            foreach (Pair<K, V> pair in pairs)
                if (pair.value1.Equals(key))
                    removeMe = pair;
            pairs.Remove(removeMe);
            #endregion
            pairs.Add(new Pair<K,V>(key, value));
        }

        public void WritePairs()
        {
            Console.WriteLine("All Key-Value Pairs:");
            foreach (Pair<K,V> pair in pairs)
            {
                Console.WriteLine($"{pair.value1}: {pair.value2}");
            }
        }
    }
}