using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

internal class Program
{
    enum Premissons : byte
    {
        Delete =1, Execute =2, Read =4, Write =8,
    }
    class Employee
    {
        string Name;
        int Age;
        decimal Salary;
        Gender Gender; //Male -Female
        public bool Premissons;
    }
    public static void DoSomeCode()
    {
        int x, y, z;
        x = int.Parse(Console.ReadLine()); //Format Exception
        y = int.Parse(Console.ReadLine());
        z = x / y; //Devided By  Zero

        int[] Numbers = { 1, 2, 3 };
        Numbers[0] = 100; //IndexOutOfRangeException
    }

    public static void DoSomeProtictiveCode()
    {
        {
            int x, y, z;
            bool Flag;
            // x = int.Parse(Console.ReadLine()); //Format Exception
            do {
                Console.WriteLine("Enter the First Number");
                Flag = int.TryParse(Console.ReadLine(), out x);
            } while (!Flag);

            // y = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter the Second Number");
                Flag = int.TryParse(Console.ReadLine(), out y);
            } while (!Flag || y == 0);
            z = x / y; //Devided By  Zero

            //int[] Numbers = { 1, 2, 3 };
            //if (Numbers.Length > 10)
            int[] Numbers = null;
            if (Numbers?.Length > 10)
            {
                Numbers[0] = 100; //IndexOutOfRangeException
            }
        }
    }

    enum Gender
    {
        Male, Female
    }

    enum Days
    {
        Satuday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    enum Grades
    {
        A, B, C, D, E, F,
    }
    private static void Main(string[] args)
    { }
    #region Exception Handling
    //// DoSomeCode();

    //try
    //{
    //    DoSomeProtictiveCode();
    //    throw new Exception();
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}


    //finally
    //{
    //    //Close- Free -Delete -Dealocate Unmanged Recources
    //    //Open File
    //    //Open Connection Database
    //    Console.WriteLine("Finally");
    //}
    //Console.WriteLine("After Try Catch");
    #endregion

    #region Acess Modifiers
    /*
     Acess Modifiers From LessAccessible To Wider
    1. Private
    2. Private Protected
    3. Protected
    4. Internal
    5. Protected Internal
    6. Public
     */
    #endregion



    #region Enum
    #region EX1
    // Days Day = Days.Sunday;
    //    Grades grade = Grades.A;
    //   if (grade = Grades.A)
    //        {

    //        Console.WriteLine(":)") ;
    //        }
    //else
    //{
    // Console.WriteLine(":(")
    //}


    #endregion

    #region EX2
    //Grades grade = (Grades)2; //Exeplest Casting
    //Console.WriteLine(grade);

    #endregion

    #region EX3
    //Grades grades =(Grades)Enum.Parse(typeof(Grades),Console.ReadLine());
    //Enum.TryParse(Typeof(Grades),Console.ReadLine(),out object Result);

    //Console.Writeline(Result);
    #endregion

    #region EX4
    //string gender = "male";
    //Enum.TryParse<Grades>(gender, true ,out Gender Result );
    //Console.WriteLine(Result);
    #endregion
    #endregion

    #region Premtions
    //Employee employee =new Employee();
    //employee.Name ="ALi";
    //employee.Age =20;
    //  employee.permissions=(Premissons)3
    #endregion
}

