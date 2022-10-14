namespace sixthLec
{
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
        }
    }
}