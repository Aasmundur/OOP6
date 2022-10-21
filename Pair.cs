namespace sixthLec
{
    public class Pair<T1,T2>
    {
        public Pair(T1 val1, T2 val2)
        {
            value1 = val1;
            value2 = val2;
        }
        public T1 value1 { get;  }
        public T2 value2 { get; }
        public (T2, T1) swap()
        {
            return (value2, value1);
        }
        public (C, T2) setFst<C>(C val)
        {
            return (val, value2);
        }
        public (T1, C) setSnd<C>(C val)
        {
            return (value1, val);
        }
    }
}