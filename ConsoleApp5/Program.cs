namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array
            int[] number = { 1, 5,2, 6,3 };
            Console.WriteLine(number[3]);
            Array.Sort(number);
            Console.WriteLine(number[2]);
            #endregion
        }
    }
}
