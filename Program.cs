namespace sixthLec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opg1a();
            //opg2();
            opg3();
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



            #endregion

            void opg3()
            {
                Dict<int,string> dict = new Dict<int,string>();
                dict.Put(0,"Thomas");
                dict.Put(1, "Jan");
                dict.Put(2, "Timothy");
                dict.Put(3, "Stine");
                dict.Put(3, "Lone");
                dict.WritePairs();
                Console.WriteLine();
                int Key = 4;
                int Key0 = 3;
                try
                {
                    Console.WriteLine($"Value {Key0}: {dict.Get(Key0)}");
                    Console.WriteLine($"Value {Key}: {dict.Get(Key)}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine($"error: Key {Key} not found.");
                }
            }
        }

    }
}