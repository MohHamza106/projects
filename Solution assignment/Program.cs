namespace Solution_assignment
{
    internal class Program
    {
        #region demo
        //public static void DoSomeCode()
        //{//try catch 
        // //last defence line
        //    try
        //    {
        //        int x, y, z;
        //        Console.Write("please enter value of x:");
        //        x = int.Parse(Console.ReadLine());
        //        Console.Write("please enter value of y:");
        //        y = int.Parse(Console.ReadLine());

        //        z = x / y;

        //        int[] Numbers = { 1, 2, 3 };
        //        Numbers[100] = 33;
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }


        //}
        //public static void DoSomeProtictiveCode()
        //{
        //    try
        //    {
        //        int x, y, z;

        //        do
        //        {
        //            Console.WriteLine("Please enter value of x:");

        //        } while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.WriteLine("Please enter value of y:");

        //        } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);
        //        z = x / y;
        //        int[] arr = { 1, 2, 3 };

        //        if (arr?.Length > 100)
        //        {
        //            arr[100] = 90;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}
        //enum Gender
        //{
        //    Male = 1, Female = 2, male = 1, female = 2
        //}
        //enum Days : int
        //{
        //    Satarday,
        //    Sunday,
        //    Mounday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday
        //}
        //enum Grades
        //{
        //    A, B, C, D, E, F
        //}
        //enum Roles
        //{
        //    Admin = 10,
        //    Viewer = 20,
        //    Editor = 30
        //}
        //enum Branches : byte//0:255
        //{
        //    NaserCity, Maadi = 251, Alex, Doki, Elnahas, SmartVillage

        //}
        //[Flags]
        //enum Permissions : byte
        //{
        //    Delete = 1, Eecute = 2, Read = 4, Write = 8
        //}

        //class Employee
        //{
        //    public string Name;
        //    public int Age;
        //    public decimal Salary;
        //    public Gender Gender;//MAle - Female
        //    public Roles Roles;
        //    public Permissions Permissions;
        //}
        #endregion
        #region MyRegion
        #region eum
        //enum WeekDays
        //{

        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}

        #endregion
        #region Season
        //enum Season
        //{
        //    Spring,
        //    Summer,
        //    Autumn,
        //    Winter
        //}
        #endregion
        #region permission
        //[Flags]
        //enum Permissions : byte
        //{
        //    Delete = 1, Eecute = 2, Read = 4, Write = 8
        //}

        //class Employee
        //{
        //    public string Name;
        //    public int Age;
        //    public decimal Salary;
        //    public Permissions Permissions;
        //}
        #endregion
        #region Colors
        //enum Colors
        //{
        //    Red,
        //    Green,
        //    Blue
        //}
        #endregion
        #endregion
        static void Main(string[] args)
        {
            #region Demo

            #region Excertion handling
            //Exception HAndling => Run time eror
            //DoSomeCode();
            //Console.WriteLine("ayman");
            //FormatException
            //DivideByZeroException
            //Exception => Father class of all exception
            //System Exception
            //1)Format Exception
            //2)Index Out Of Range Exception
            //3)Null Reference
            //4)Arthimitic Exception
            //5)Invalid Operation exception
            //Application Exception
            //try
            //{
            //    DoSomeProtictiveCode();//Try code
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);//Error
            //}
            //finally
            //{
            //    //[Realsed,Deallocate,Delete,Close]
            //    //External Resource
            //}
            #endregion
            #region Access Modiofieers
            //TypeA typeA = new TypeA();


            #endregion
            #region Enums
            #region Ex01
            //string Day = "Hamada";
            //Days days = Days.Sunday;
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            #endregion
            #region Ex02
            //Grades grades = (Grades)2;//Explicit casting 
            //Console.WriteLine(grades);//c

            //Grades grades = (Grades)10;//Explicit casting
            //Console.WriteLine(grades);//10
            //Admin Viewr Editor

            #endregion
            #region Ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(Result);


            #endregion
            #region Ex04
            //string Gender = "male";
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object result);
            //Console.WriteLine(result);
            //Enum.TryParse<Gender>(Gender, true, out Gender result);



            #endregion

            #endregion
            #region Permissions With Enum
            #region Permisions
            //Employee Employee = new Employee();
            //Employee.Name = "Ali";
            //Employee.Salary = 2000;
            //Employee.Age = 30;
            //Employee.Permissions = (Permissions)1;
            //Console.WriteLine(Employee.Permissions);//Delete Execute
            //                                        //XOR ^
            //Employee.Permissions = Employee.Permissions ^ Permissions.Read;//add permision
            //Console.WriteLine(Employee.Permissions);//Delete Execute Read
            //Employee.Permissions = Employee.Permissions ^ Permissions.Read;//Delete for permission.
            //Console.WriteLine(Employee.Permissions);//Delete Execute
            //                                        //& AND
            //if ((Employee.Permissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("permision already exsist");
            //}
            //else
            //{
            //    Employee.Permissions = Employee.Permissions ^ Permissions.Read;
            //    Console.WriteLine(Employee.Permissions);
            //}
            //// Or |
            ////use to check for permission
            //Employee.Permissions = Employee.Permissions | Permissions.Write;
            //Console.WriteLine(Employee.Permissions);
            #endregion
            #region Struct
            //Point p01;
            ////p01.x = 10;
            ////p01.y = 20;
            ////Console.WriteLine(p01.x);//invalid you must assign avalue before
            ////Console.WriteLine(p01.y);//invalid you must assign avalue before
            ////use construcor to assign the values
            //p01 = new Point(2,7);
            ////Console.WriteLine(p01.x);
            ////Console.WriteLine(p01.y);
            //Console.WriteLine(p01.ToString());//Assignment6.Point,bestway
            //Console.WriteLine(p01);//boking and un boking
            //Point p02= new();
            #endregion

            #endregion
            #endregion
            #region eum


            //Array x = Enum.GetValues(typeof(WeekDays));
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x.GetValue(i));
            //}

            #endregion
            #region  seasons
            //  Console.Write("enter session:  ");
            //string seession = Console.ReadLine();
            //if (Enum.TryParse(seession, true, out Season season))
            //{
            //    if (season == Season.Spring)
            //    {
            //        Console.WriteLine("Spring: March to May");
            //    }
            //    else if (season == Season.Summer)
            //    {
            //        Console.WriteLine($"summer june to august");
            //    }
            //    else if (season == Season.Autumn)
            //    {
            //        Console.WriteLine($"autumn September to November");
            //    }
            //    else if (season == Season.Winter)
            //    {
            //        Console.WriteLine($" winter December to February");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("not found in enum season");
            //}


            #endregion
            #region permission
            //Employee Employee = new Employee();
            //Employee.Name = "Ali";
            //Employee.Salary = 2000;
            //Employee.Age = 30;
            //Employee.Permissions = (Permissions)3;
            //Console.WriteLine(Employee.Permissions);//Delete Execute
            //                                       //XOR ^
            //Employee.Permissions = Employee.Permissions ^ Permissions.Read;//add permision
            //Console.WriteLine(Employee.Permissions);//Delete Execute Read
            //Employee.Permissions = Employee.Permissions ^ Permissions.Read;//Delete for permission.
            //Console.WriteLine(Employee.Permissions);//Delete Execute
            //                                        //& AND
            //if ((Employee.Permissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("permision already exsist");
            //}
            //else
            //{
            //    Employee.Permissions = Employee.Permissions ^ Permissions.Read;
            //    Console.WriteLine(Employee.Permissions);
            //}
            //// Or |
            ////use to check for permission
            //Employee.Permissions = Employee.Permissions | Permissions.Write;
            //Console.WriteLine(Employee.Permissions);
            #endregion
            #region Colors
            //Console.Write("enter color:  ");
            //string color = Console.ReadLine();
            //if (Enum.TryParse(color,true,out Colors result))
            //{
            //    if (result == Colors.Blue || result == Colors.Green || result == Colors.Red)
            //    {
            //        Console.WriteLine("color is main");
            //    }
            //}
            //else Console.WriteLine("color is not main");
            #endregion
            #region point

            //bool flag;
            //int x1, x2, y1, y2;
            //do
            //{
            //    Console.Write("enter  frist number x1:  ");
            //    flag = int.TryParse(Console.ReadLine(), out x1);
            //} while (!flag);
            //do
            //{
            //    Console.Write("enter  frist number y1:  ");
            //    flag = int.TryParse(Console.ReadLine(), out y1);
            //} while (!flag);
            //do
            //{
            //    Console.Write("enter  second number x2:  ");
            //    flag = int.TryParse(Console.ReadLine(), out x2);
            //} while (!flag);
            //do
            //{
            //    Console.Write("enter  second number y2:  ");
            //    flag = int.TryParse(Console.ReadLine(), out y2);
            //} while (!flag);

            //Point pointOne = new Point(x1, y1);
            //Point pointTwo = new Point(x2, y2);
            //int result = (int)MathF.Sqrt(MathF.Pow(2, x2 - x1) + MathF.Pow(2, y2 - y1));
            //Console.WriteLine( $" result is: {result}");




            #endregion
            #region Sheet2
            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] person = new Person[3];

            //person[0] = new Person(20, "mohamed");
            //person[1] = new Person(30, "Ahmed");
            //person[2] = new Person(40, "Ali");


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{person[i]}");
            //}
            #endregion
            #region  Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] person = new Person[3];
            //int age1;
            //int age2;
            //int age3;
            //bool checkage;
            //string name1;
            //string name2;
            //string name3;
            //int oldage=0;

            //do {
            //    Console.Write("enter age1:");
            //    checkage = int.TryParse(Console.ReadLine(), out age1);
            //} while (!checkage);
            //Console.Write("enter Name1:");
            //name1 = Console.ReadLine();
            //do
            //{
            //    Console.Write("enter age2:");
            //    checkage = int.TryParse(Console.ReadLine(), out age2);
            //} while (!checkage);
            //Console.Write("enter Name2:");
            //name2 = Console.ReadLine();
            //do
            //{
            //    Console.Write("enter age3:");
            //    checkage = int.TryParse(Console.ReadLine(), out age3);
            //} while (!checkage);
            //Console.Write("enter Name3:");
            //name3 = Console.ReadLine();

            //person[0] = new Person(age1, name1);
            //person[1] = new Person(age2, name2);
            //person[2] = new Person(age3,name3);
            //for (int i = 0; i < 3; i++)
            //{
            //    if (person[i].Age >= oldage  )
            //    {
            //        oldage = person[i].Age;  
            //    }

            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    if (person[i].Age == oldage)
            //    {
            //        Console.WriteLine($" Name :{person[i].Name} Age: {person[i].Age}");
            //    }
            //}





            #endregion
            #region class
            Employee employee=new Employee(20,"mohamed",security.DBA,5000,4,5,2005,Gender.M);
            Console.WriteLine(employee);
            Employee[] Employees = new Employee[3];

            Employees[0] = new Employee(20, "mohamed", security.DBA, 4000, 6, 5, 2004, Gender.M);
            Employees[1] = new Employee(30, "Ahmed", security.guest, 3000, 3, 5, 2002, Gender.M);
            Employees[2] = new Employee(40, " security officer",(security)15 , 8000, 8, 9, 2005, Gender.M);

            Array.Sort(Employees, (e1, e2) => (e1.day).CompareTo(e2.day));
            Array.Sort(Employees, (e1, e2) => (e1.month).CompareTo(e2.month));
            Array.Sort(Employees, (e1, e2) => (e1.year).CompareTo(e2.year));
            Console.WriteLine("Employees sorted by hire date:");
            foreach (var Employee in Employees)
            {
                Console.WriteLine(Employee);
            }
           


            #endregion
            #endregion





        }
    }
}
