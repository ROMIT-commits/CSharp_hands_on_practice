using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;



namespace MyNamespace
{

    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = x + 7;
            Console.WriteLine(8);
            String m = Console.ReadLine();
           // int m=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hi,"+m+"Ans:"+y);
           HelloWorld.Alpha.A a = new HelloWorld.Alpha.A();
            a.DoSomething();
            HelloWorld.Scope obj = new HelloWorld.Scope();
            obj.PrintNumbers();
            obj.HelperMethod();
            HelloWorld.AssembliesAndNamespaces obj2 = new HelloWorld.AssembliesAndNamespaces();
            obj2.PrintString();

            HelloWorld.Car car1 = new HelloWorld.Car();
            HelloWorld.Car car2 = new HelloWorld.Car();
            HelloWorld.Book book1 = new HelloWorld.Book();
            HelloWorld.Book book2 = new HelloWorld.Book();
            HelloWorld.Book book3 = new HelloWorld.Book();

            // test



            //collections
            car1.Brand = "Toyota";
            car1 .Model = "Corolla";
            car1.VIN = "C1";

            car2.Brand = "Toyota";
            car2.Model = "Civic";
            car2.VIN = "C2";

            book1.Title = "C# Programming";
            book1.Author = "John Doe";
            book1.ISBN = "B1";

            book2.Title = "ASP.NET";
            book2.Author = "John Cena";
            book2.ISBN = "B2";

            book3.Title = "React Js";
            book3.Author = "Andrew Corey";
            book3.ISBN = "B3";



            List<Car> MyList = new List<Car>();
            MyList.Add(car1);
            MyList.Add(car2);

            foreach (Car car in MyList)
            {
                Console.WriteLine($"Car Brand: {car.Brand}, Model: {car.Model} VIN:{car.VIN}");
            }


            Dictionary<string, Book> bookCollection = new Dictionary<string, Book>();

            bookCollection.Add(book1.ISBN, book1);
            bookCollection.Add(book2.ISBN, book2);
            bookCollection.Add(book3.ISBN, book3);  
            Console.WriteLine("Books in the collection:" + bookCollection["B2"].Author);



            // LINQ Example

            //List<Car> MyCars = new List<Car>();
            //{
            //    new Car { VIN = "V1", Brand = "Honda", Model = "CITY" };
            //    new Car { VIN = "V2", Brand = "Toyota", Model = "Corolla" };
            //    new Car { VIN = "V3", Brand = "Honda", Model = "Focus" };
            //};
            //var HondaCars = from car in MyCars where car.Brand == "Honda" select car;

            //foreach(var car in HondaCars)
            //{
            //  Console.WriteLine("{0},{1}",car.Model);
            //}

            // LINQ Example

            List<Car> MyCars = new List<Car>
{
                new Car { VIN = "V1", Brand = "Honda", Model = "CITY" },
                new Car { VIN = "V2", Brand = "Toyota", Model = "Corolla" },
                new Car { VIN = "V3", Brand = "Honda", Model = "Focus" }
};

            //var HondaCars = from car in MyCars where car.Brand == "Honda" select car;
            
            var OrderedCars = from cars in MyCars orderby cars.Model select cars;



            //var HondaCars = MyCars.Where(c => c.Brand == "Honda");
            foreach (var car in OrderedCars)
            {
                Console.WriteLine("{0},{1}",car.Model,car.Brand);
            }


            Console.WriteLine(MyCars.TrueForAll(car=>car.VIN == "1"));






        }
    }
}
















