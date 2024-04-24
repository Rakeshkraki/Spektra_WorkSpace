//using System;
//using System.Collections.Generic;

//using System;


//public class Employee
//{
//    int eno;
//    double salary;
//    string ename;
//    string job;
//    string dName;
//    string location;

//    public Employee(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
//    {
//        this.eno = Eno;
//        this.ename = Ename;
//        this.job = Job;
//        this.salary = Salary;
//        this.dName = Dname;
//        this.location = Location;
//    }
//    public object this[int index]
//    {
//        get
//        {
//            if (index == 0)
//                return eno;
//            else if (index == 1)
//                return ename;
//            else if (index == 2)
//                return job;
//            else if (index == 3)
//                return salary;
//            else if (index == 4)
//                return dName;
//            else if (index == 5)
//                return location;
//            return null;
//        }
//        set
//        {
//            if (index == 0)
//                eno = (int)value;
//            else if (index == 1)
//                ename = (string)value;
//            else if (index == 2)
//                job = (string)value;
//            else if (index == 3)
//                salary = (double)value;
//            else if (index == 4)
//                dName = (string)value;
//            else if (index == 5)
//                location = (string)value;
//        }
//    }
//}

//class TestEmployee
//{
//    static void Main()
//    {
//        Employee Emp = new Employee(1001, "Kanth", "Manager", 20000.00, "Sales", "Mumbai");
//        Console.WriteLine("Eno: " + Emp[0]);
//        Console.WriteLine("Ename: " + Emp[1]);
//        Console.WriteLine("Job: " + Emp[2]);
//        Console.WriteLine("Salary: " + Emp[3]);
//        Console.WriteLine("Dname: " + Emp[4]);
//        Console.WriteLine("Location: " + Emp[5]);

//        Emp[0] = 1002;
//        Emp[2] = "Sr.Manager";
//        Emp[3] = 50000.00;

//        Console.WriteLine("After Modification");
//        Console.WriteLine("Eno: " + Emp[0]);
//        Console.WriteLine("Ename: " + Emp[1]);
//        Console.WriteLine("Job: " + Emp[2]);
//        Console.WriteLine("Salary: " + Emp[3]);
//        Console.WriteLine("Dname: " + Emp[4]);
//        Console.WriteLine("Location: " + Emp[5]);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int temperature = Convert.ToInt32(Console.ReadLine());

//        try
//        {

//            if (temperature == 0)
//            {
//                throw new ZeroTemperatureException("Temperature cannot be zero.");
//            }

//            Console.WriteLine("Temperature is: " + temperature);
//        }
//        catch (ZeroTemperatureException ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}

//public class ZeroTemperatureException : Exception
//{
//    public ZeroTemperatureException(string message) : base(message)
//    {
//    }
//}


/* file Handling */

//using System.IO;

//class FileHandling
//{
//    static void Main(string[] args)
//    {
//        string filePath = @"C:\Users\rakes\Documents\Dekstop_folders\SpektraWorkspace\file.txt";

//        //Console.WriteLine(CreateFIle(filePath));


//        //ReadFile(filePath);

//        //WriteFile(filePath);

//        CreateAndCopy();


//    }

//    static string CreateFIle(string filePath)
//    {
//        File.Create(filePath);
//        if (CheckFileExist(filePath))
//        {

//            return "created";
//        }
//        return "cant able to create";



//    }

//    static void ReadFile(string filePath)
//    {
//        if (CheckFileExist(filePath))
//        {
//            string line = File.ReadAllText(filePath);
//            Console.WriteLine(line);
//        }
//        else
//        {
//            Console.WriteLine("file not found");
//        }

//    }

//    static void WriteFile(String filePath)
//    {
//        string text = "i'm writing text by using c#";

//        if (CheckFileExist(filePath))
//        {
//            File.WriteAllText(filePath, text);

//        }
//        else
//        {
//            Console.WriteLine("File not found");
//        }



//    }

//    static Boolean CheckFileExist(string filePath)
//    {
//        if (File.Exists(filePath))
//        {
//            return true;
//        }
//        return false;
//    }

//    static void CreateAndCopy()
//    {
//        string sourceFilePath = @"C:\Users\rakes\Documents\Dekstop_folders\SpektraWorkspace\sourceFile.txt";
//        string destinationFilePath = @"C:\Users\rakes\Documents\Dekstop_folders\SpektraWorkspace\dest.txt";


//        File.Copy(sourceFilePath, destinationFilePath, true);

//        string copiedContent = File.ReadAllText(destinationFilePath);
//        Console.WriteLine("Content of the copied file:");
//        Console.WriteLine(copiedContent);
//    }
//}



/* generics */
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> myList = new List<int>();

//        myList.Add(10);
//        myList.Add(20);
//        myList.Add(30);

//        Console.WriteLine("Accessing elements using a for loop:");
//        for (int i = 0; i < myList.Count; i++)
//        {
//            Console.WriteLine("Element at index " + i + ": " + myList[i]);
//        }

//        Console.WriteLine("\nAccessing elements using a foreach loop:");
//        foreach (int item in myList)
//        {
//            Console.WriteLine("Element: " + item);
//        }

//        Console.WriteLine("\nAccessing elements by index position:");

//        Console.WriteLine("First element: " + myList[0]);
//        Console.WriteLine("Second element: " + myList[1]);
//        Console.WriteLine("Third element: " + myList[2]);
//    }
//}


/* Merge and Sort */



//class Arrays
//{
//    static void Main()
//    {
//        //MergeAndSort();
//        //CountAndDisplayFrequencies();
//        EvenOdd();
//    }

//    static void MergeAndSort()
//    {

//        int[] array1 = { 1, 2, 5, 6, 9 };
//        int[] array2 = { 3, 4, 7, 8, 10 };

//        int[] mergedArray = array1.Concat(array2).ToArray();

//        Array.Sort(mergedArray);

//        Console.WriteLine("Merged Array:");
//        foreach (int num in mergedArray)
//        {
//            Console.Write(num + " ");
//        }

//    }

//    static void CountAndDisplayFrequencies()
//    {
//        int[] array = { 1, 2, 2, 3, 4, 4, 4, 4, 5, 5 };

//        Array.Sort(array);

//        int n = array.Length;

//        int currentItem = array[0];
//        int currentCount = 1;

//        for (int i = 1; i < n; i++)
//        {
//            if (array[i] == currentItem)
//            {
//                currentCount++;
//            }
//            else
//            {
//                Console.WriteLine($"Item: {currentItem}, Frequency: {currentCount}");
//                currentItem = array[i];
//                currentCount = 1;
//            }
//        }

//        Console.WriteLine($"Item: {currentItem}, Frequency: {currentCount}");
//    }

//    static void EvenOdd()
//    {
//        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        int[] oddIntegers = array.Where(num => num % 2 != 0).ToArray();
//        int[] evenIntegers = array.Where(num => num % 2 == 0).ToArray();

//        Console.WriteLine("Odd Integers:");
//        foreach (var num in oddIntegers)
//        {
//            Console.WriteLine(num);
//        }

//        Console.WriteLine("\nEven Integers:");
//        foreach (var num in evenIntegers)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}

/* cordinates */
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the x-coordinate: ");
//        int x = int.Parse(Console.ReadLine());

//        Console.Write("Enter the y-coordinate: ");
//        int y = Convert.ToInt32(Console.ReadLine());

//        string quadrant = DetermineQuadrant(x, y);

//        Console.WriteLine($"The point ({x}, {y}) lies in {quadrant} quadrant.");
//    }

//    static string DetermineQuadrant(double x, double y)
//    {
//        if (x > 0 && y > 0)
//        {
//            return "the first";
//        }
//        else if (x < 0 && y > 0)
//        {
//            return "the second";
//        }
//        else if (x < 0 && y < 0)
//        {
//            return "the third";
//        }
//        else if (x > 0 && y < 0)
//        {
//            return "the fourth";
//        }
//        else if (x == 0 && y == 0)
//        {
//            return "the origin";
//        }
//        else if (x == 0)
//        {
//            return "the y-axis";
//        }
//        else
//        {
//            return "the x-axis";
//        }
//    }
//}

/* Electricity Bill */

//class ElectricityBill
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter Id : ");
//        long id = Convert.ToInt64(Console.ReadLine());

//        Console.Write("Enter Name : ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Units used : ");

//        int units = Convert.ToInt32(Console.ReadLine());

//        double billAmt = units * PerUnit(units);

//        double tax = (9.0 / 100) * billAmt;

//        int other = 100;

//        double netAmt = tax + other + billAmt;


//        Console.WriteLine("---------- Electricity Bill ----------------");

//        Console.WriteLine("RR Number : " + id);
//        Console.WriteLine("Name : " + name);
//        Console.WriteLine("---------------------------------------------");
//        Console.WriteLine("Units : " + units);
//        Console.WriteLine("Tax : " + tax);
//        Console.WriteLine("Other : " + other);
//        Console.WriteLine("Bill Amt. : " + billAmt);
//        Console.WriteLine("---------------------------------------------");
//        Console.WriteLine("Net Amt. Due : " + netAmt);
//        Console.WriteLine("Date : " + DateTime.Today);


//    }

//    static double PerUnit(int unit)
//    {
//        if (unit <= 100)
//        {
//            return 5.90;
//        }
//        else if (unit <= 200)
//        {
//            return 7.11;
//        }
//        else
//        {
//            return 8.16;
//        }
//    }

//}




using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the string contain special characters");
        string text = Console.ReadLine();

        string updatedText = RemoveSpecialCharacters(text);

        Console.WriteLine("Original Text: " + text);
        Console.WriteLine("Updated Text: " + updatedText);
    }

    static string RemoveSpecialCharacters(string input)
    {
        string pattern = "[^a-zA-Z0-9 _-]";

        return Regex.Replace(input, pattern, "");
    }
}





