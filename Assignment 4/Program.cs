namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sheet 2
            #region 1
            //Console.Write("enter number:  ");
            //bool flag;
            //    flag=int.TryParse(Console.ReadLine(), out var number);
            //if (flag && number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}
            #endregion
            #region 2
            //Console.Write("ENTER NUMBER :  ");
            //int number = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number * i}");
            //}

            #endregion
            #region 3
            //Console.Write("ENTER NUMBER :  ");
            //int number = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out int Number);
            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region 4


            //Console.Write("ENTER NUMBER1 :  ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("ENTER NUMBER2 :  ");
            //int number2 = int.Parse(Console.ReadLine());
            //double result = Math.Pow(number1, number2);
            //Console.WriteLine($"{result}");

            #endregion
            #region 5 not result 
            //Console.Write("enter string:    ");
            //string str = Console.ReadLine();
            //char[] charArray = str.ToCharArray();

            //for (int i = 0; i < charArray.Length; i++)
            //{

            //    Console.Write(charArray[i]);
            //}
            //Console.WriteLine("\n");
            //Array.Reverse(charArray);
            //Console.WriteLine(charArray);
            #endregion
            #region 6
            //bool isprime=true;
            //Console.WriteLine("enter prime number:  ");
            //for (int i = 2; i <= 50; i++)
            //{ 
            //    for (int j = 2; j <= 100; j++)
            //    {
            //        if (i != j && i % j == 0)
            //        {
            //            isprime = false;
            //            break;
            //        }
            //    }
            //         if (isprime) 
            //         {
            //               Console.Write("\t" + i);
            //         }
            //    isprime = true;
            //}
            //Console.ReadKey();

            #endregion
            #region 7 noy result

            Console.Write("enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int reminder = 0;
            string binarycode = "";
            if (n == 0) Console.WriteLine(0);
            while (n > 0)
            {
                reminder = n % 2;
                binarycode = reminder + binarycode;
                n = n / 2;
            }

            Console.WriteLine(binarycode);

            #endregion
            #region   8
            //Console.Write("Enter the size of the identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The identity matrix of size is:{n}");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            #region 9
            //Console.Write("enter string name :  ");
            //string name = Console.ReadLine();
            //string substring = name.Substring(7, 5);
            //Console.WriteLine(substring);

            #endregion
            #region 10
            //Console.Write("enter string1 :  ");
            //string name1 = Console.ReadLine();
            //Console.Write("enter string2 :  ");
            //string name2 = Console.ReadLine(); 
            //Console.WriteLine(name1);   
            //Console.WriteLine(name2);

            //Console.Write ("**********************\n");
            //name1 = name2;
            //Console.WriteLine(name1);   
            //Console.WriteLine(name2);
            #endregion
            #region 11
            //Console.Write("Enter the size of the identity matrix: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The identity matrix of size is:{n}");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region 12
            //int[] number = { 1, 2, 9, 3, 5, 6, 8, 7 ,85,36,95,24,39};
            //Array.Sort(number);
            //Console.WriteLine(number.Sum());
            #endregion
            #region 13
            //int[] number1 = { 1, 2, 3 ,6,2,58,3};
            //int[] array2 = { 4, 5, 6,8,2,7,5 };
            //int[] mergedArray = number1.Concat(array2).ToArray();
            //Console.WriteLine(string.Join(", ", mergedArray));
            #endregion
            #region 14
            //int[] arr = { 1, 2, 2, 3, 5, 3, 4, 6, 7, 4 };
            //Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int currentElement = arr[i];
            //    if (frequencyMap.ContainsKey(currentElement))
            //    {
            //        frequencyMap[currentElement]++;
            //    }
            //    else
            //    {
            //        frequencyMap[currentElement] = 1;
            //    }
            //}
            //Console.WriteLine("Element Frequency:");
            //foreach (var item in frequencyMap)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}


            #endregion
            #region 15
            //int[] number = { 13, 23, 39, 4, 65, 66, 7, 58, 20, 10, 11, 12 };
            //Console.WriteLine(number.Max());
            //Console.WriteLine(number.Min());
            #endregion
            #region 16
            //int[] number = { 13, 23, 39, 4, 65, 66, 7, 58, 20, 10, 11, 12, 76 };
            //Array.Sort(number);
            //Console.WriteLine(number[number.Length - 2]);
            #endregion
            #region 17

            #endregion
            #region 18
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, columns];
            //int[,] secondArray = new int[rows, columns];

            //Console.WriteLine("Enter the elements of the first array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write("Element[{0},{1}]: ", i, j);
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("The elements of the second array are:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 19
            //int[] array = { 1, 52, 9, 8, 3, 9, 7, 6, 85, 93 };
            //Array.Sort(array);
            //Array.Reverse(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #endregion
        }
    }
}
