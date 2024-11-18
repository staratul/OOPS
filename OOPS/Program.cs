using System;
using System.Numerics;
using OOPS.Abstraction;
using OOPS.Class;
using OOPS.Encapsulation;
using OOPS.Inheritance;
using OOPS.Polymorphism.MethodOverloading;
using OOPS.Polymorphism.OperatorOverloading;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Object
            Calculator calculator = new Calculator();

            // Accesssing calculator class member using calculator class object
            int result = calculator.CalculateSum(10, 20);

            Console.WriteLine(result);



            // *********** Encapsulation ***********
            BankAccount myAccount = new BankAccount();
            myAccount.AccountNumber = "123456789";
            myAccount.Deposit(1000);
            myAccount.Withdraw(500);
            Console.WriteLine("Account Number: " + myAccount.AccountNumber);
            Console.WriteLine("Balance: $" + myAccount.Balance);



            // *********** Inheritance ***********
            Shape shape1 = new Circle();
            shape1.Draw(); // Drawing a circle

            Shape shape2 = new Rectangle();
            shape2.Draw(); // Drawing a Rectangle



            // *********** Abstraction ***********
            Vehicle car = new Car();
            car.Start();
            car.Stop();

            Vehicle motercycle = new Motorcycle();
            motercycle.Start();
            motercycle.Stop();



            // *********** Polymorphism ***********
            // Method Overloading
            NumberCalculator numCal = new NumberCalculator();
            int result1 = numCal.Add(10, 20);
            int result2 = numCal.Add(20, 30, 40);

            Console.WriteLine(result1);
            Console.WriteLine(result2);


            // Operator Overloading
            Vectors v1 = new Vectors { X = 1, Y = 2 };
            Vectors v2 = new Vectors { X = 3, Y = 4 };

            Vectors vectors = v1 + v2;

            Console.WriteLine($"Result: ({vectors.X}, {vectors.Y})");


            // Method Overriding
            Shape shape3 = new Circle();
            shape3.Draw();

            Console.ReadLine();
        }
    }
}
