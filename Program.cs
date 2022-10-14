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
    internal class Program
    {
        static void Main(string[] args)
        {
            opg1a();
            #region opg1
            void opg1a(){
                List<int> fancyList = new List<int>{1, 2, 3, 4, 5 ,6 ,7};
                HandyMethods hMet = new HandyMethods();
                Console.WriteLine($"This is max: {hMet.Max(fancyList)} and this is min: {hMet.Min(fancyList)}");

            }
            #endregion

            #region Opgave 2
                void opg2()
                {
                    Pair<int, bool> myPair = new Pair<int, bool>(14, true);
                    Console.WriteLine($"{myPair.swap()}");
                    Console.WriteLine($"{myPair.setFst<string>("Henro")}");
                    Console.WriteLine($"{myPair.setSnd<double>(37.98)}");
                }


            opg2();

            #endregion
        }

    }
}