using System.Xml.Linq;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex1 
            #region Deferred Execution
            //var number = new List<int > { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //var result = from i in number where i > 5 select i;
            //foreach (var i in result) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("____________");
            //number.AddRange(new List<int> { 20, 60, 34, 50, });
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion


            #region Immediate Execution
          //  (Elements Operators, Casting Operators, Aggregate Operators)
         var number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            var result = (from i in number where i > 5 select i).ToList();
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("____________");
            number.AddRange(new List<int> { 20, 60, 34, 50, });
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            #endregion

            // by used for 
            //var result = new List<int>();
            //foreach (int i in number)
            //{
            //    if (i > 5)
            //    {
            //        result.Add(i);
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

        }
    }
}
