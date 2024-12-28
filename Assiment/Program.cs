using System.ComponentModel.Design;
using Assiment;

internal class Program
{
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

    enum Season
    {
        Spring,
        Summer, 
        Autumn, 
        Winter
    }

    enum Premissons : byte
    {
        Delete = 1, Execute = 2, Read = 4, Write = 8,
    }
    class   Employee
    {
       public string name;
        public int age;    
       public decimal price;
       public Premissons Premissons;
    }

    enum Colors
    {
        Red ,
        Green ,
        Blue 
    }
    class program
    {
        private static void Main(string[] args)
        {
            #region Q1 Days of the Week
            // Console.WriteLine("Days of the Week are");
            //Array day = Enum.GetValues(typeof(Days));
            // for (int i = 0; i < day.Length; i++)
            // {
            //     Console.WriteLine(day.GetValue(i));
            // }
            #endregion

            #region Q2 What is the Month of The Season
            //Console.WriteLine("Enter The Season");
            //string input = Console.ReadLine();
            //try
            //{
            //    Season season = (Season)Enum.Parse(typeof(Season), input, true);
            //    if (season == Season.Spring)
            //    {
            //        Console.WriteLine("march , april and may");
            //    }
            //    else if (season == Season.Summer)
            //    {
            //        Console.WriteLine("june ,juliy and august ");
            //    }
            //    else if (season == Season.Autumn)
            //    {
            //        Console.WriteLine("September ,Octobur and  November ");
            //    }
            //    else if (season == Season.Winter) 
            //    {
            //        Console.WriteLine("December ,Jenuary and February");
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            #endregion

            #region Q3 Premissons
            //Employee employee = new Employee();
            //employee.name = "fatma";
            //employee.age = 20;
            //employee.Premissons = (Premissons)3;

            //Console.WriteLine(employee.Premissons);
            //employee.Premissons = employee.Premissons ^ Premissons.Read;

            //Console.WriteLine(employee.Premissons);
            //employee.Premissons = employee.Premissons ^ Premissons.Write;

            //if ((employee.Premissons & Premissons.Write) == Premissons.Write)
            //{
            //    Console.WriteLine("Write is exist");
            //}
            //else
            //{
            //    Console.WriteLine("Write is not exist");
            //}
            #endregion

            #region Q4 Color
            //Console.WriteLine("Enter the Color Name");
            //string input = Console.ReadLine();

            //try
            //{
            //    Colors colors = (Colors)Enum.Parse(typeof(Colors), input, true);
            //    if (colors == Colors.Red || colors == Colors.Green || colors == Colors.Blue)
            //    {
            //        Console.WriteLine("color is a primary color");
            //    }
            //    else
            //    {
            //        Console.WriteLine("color isnot a primary color");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion

            #region Q5 Calculate Destence
            //point P1;

            //Console.WriteLine("Enter The 2  for the firt Point(x,y)");
            //string[] input1 = Console.ReadLine().Split(' ');
            //point point1 = new point(double.Parse(input1[0]), double.Parse(input1[1]));

            //Console.WriteLine("Enter The 2  for the second Point(x,y)");
            //string[] input2 = Console.ReadLine().Split(' ');
            //point point2 = new point(double.Parse(input2[0]), double.Parse(input2[1]));

            //double distance = CalculateDistance(point1, point2);
            //Console.WriteLine($"distance is{distance} ");



            //static double CalculateDistance(point p1, point p2)
            //{
            //    return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            //}

            #endregion

        }
    }
}