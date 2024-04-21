using System;

//abstract class Shape
//{
//    public abstract double Area();

//    class Circle : Shape
//    {
//        private double radius;

//        public Circle(double radius)
//        {
//            this.radius = radius;
//        }

//        public override double Area()
//        {
//            return Math.PI * radius * radius;
//        }
//    }

//    class Triangle : Shape
//    {
//        private double baseLength;
//        private double height;

//        public Triangle(double baseLength, double height)
//        {
//            this.baseLength = baseLength;
//            this.height = height;
//        }

//        public override double Area()
//        {
//            return 0.5 * baseLength * height;
//        }
//    }

//    class Square : Shape
//    {
//        private double sideLength;

//        public Square(double sideLength)
//        {
//            this.sideLength = sideLength;
//        }

//        public override double Area()
//        {
//            return sideLength * sideLength;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Shape circle = new Circle(5);
//            Shape triangle = new Triangle(4, 3);
//            Shape square = new Square(6);

//            Console.WriteLine("Area of circle: " + circle.Area());
//            Console.WriteLine("Area of triangle: " + triangle.Area());
//            Console.WriteLine("Area of square: " + square.Area());
//        }
//    }
//}



//class EmployeDetails
//{
//    private int id;
//    private string name;
//    private string designation;
//    private int salary;

//    public int Id { get { return id; } set { id = value; } }

//    public string Name { get { return name; } set { name = value; } }

//    public string Designation { get { return designation; } set { designation = value; } }

//    public int Salary { get { return salary; } set { salary = value; } }




//    static void Main(string[] args)
//    {
//        EmployeDetails emp1 = new EmployeDetails();

//        Console.WriteLine("Enter Employee id");

//        emp1.Id = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter Employee Name ");

//        emp1.Name = Console.ReadLine();

//        Console.WriteLine("Enter Employee Designation ");

//        emp1.designation = Console.ReadLine();

//        Console.WriteLine("Enter Employee Salary ");

//        emp1.Salary = Convert.ToInt32(Console.ReadLine());





//        Console.WriteLine("Employee id - " + emp1.Id);
//        Console.WriteLine("Employee Name - " + emp1.Name);
//        Console.WriteLine("Employee Designation" + emp1.Designation);
//        Console.WriteLine("Employee Salary" + emp1.Salary);

//    }

//}


// Base class Person

/* asssment 3 */
//class person
//{
//    public string name;
//    public int age;
//    public string address;

//    public person(string name, int age, string address)
//    {
//        this.name = name;
//        this.age = age;
//        this.address = address;
//    }

//    public virtual void displaydetails()
//    {
//        Console.WriteLine("name: " + name);
//        Console.WriteLine("age: " + age);
//        Console.WriteLine("address: " + address);
//    }
//}

//class student : person
//{
//    public student(string name, int age, string address)
//        : base(name, age, address)
//    {
//    }
//}

//class teacher : person
//{
//    public teacher(string name, int age, string address)
//        : base(name, age, address)
//    {
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        student student = new student("student1", 20, "bangalore");
//        teacher teacher = new teacher("teacher", 35, "hydrabad");

//        Console.WriteLine("student details:");
//        student.displaydetails();
//        Console.WriteLine();

//        Console.WriteLine("teacher details:");
//        teacher.displaydetails();
//    }
//}

/* assessment 4 */

//public abstract class PaymentMethod
//{
//    public abstract void MakePayment(double amount);
//}

//public class DigitalWalletPayment : PaymentMethod
//{
//    public override void MakePayment(double amount)
//    {
//        Console.WriteLine($"Paid {amount} using Digital Wallet.");
//    }
//}

//public class BankTransferPayment : PaymentMethod
//{
//    public override void MakePayment(double amount)
//    {
//        Console.WriteLine($"Paid {amount} using Bank Transfer.");
//    }
//}

//public class CreditCardPayment : PaymentMethod
//{
//    public override void MakePayment(double amount)
//    {
//        Console.WriteLine($"Paid {amount} using Credit Card.");
//    }
//}



//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the amount");
//        double amount = Convert.ToDouble(Console.ReadLine());

//        PaymentMethod digitalWallet = new DigitalWalletPayment();
//        digitalWallet.MakePayment(amount);
//        PaymentMethod bankTransfer = new BankTransferPayment();
//        bankTransfer.MakePayment(amount);
//        PaymentMethod creditCard = new CreditCardPayment();
//        creditCard.MakePayment(amount);



//    }

class FileHandling
{
    static void Main(string[] args)
    {
        string filepath = @"C:\Users\rakes\Documents\Dekstop_folders\SpectraWorkspace\text.txt";

        //File.Create(filepath);

        //File.WriteAllText(filepath, "writing");

        string[] read = File.ReadAllLines(filepath);

        if(File.Exists(filepath))
        {
            Console.WriteLine(read);
        }
        else
        {
            Console.WriteLine("cannot find path");
        }
    }
}