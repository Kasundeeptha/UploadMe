// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Xml.XPath;

namespace app
{

    delegate void Printer();

    class program
    {
        static String location;
        static DateTime time = DateTime.Now;
        public static string result;

        static int[] intArray = {1,2,3,4,5,6};
        static void Main(string []args)
        {
           //value and references
           Console.WriteLine(location==null?"location is null":location);
           Console.WriteLine(time==null?"time is null":time);

            //one line to sumup
           long i = TotalAllEvenNumbers_2(intArray);
           Console.WriteLine(i);

            //this is false
           if(time==null)
           {
             Console.WriteLine("time is null");
           }

           // Create a new object of the Circle class.
		Circle Object = new Circle();
        programCircle p = new programCircle();
		// Calculate the circumference based on the radius of the object and the op function.
		Console.WriteLine("Circumference of the Circle is: " + Object.Calculate(Object.op));

        //checking Func
        Func<string> f = programCircle.GetMessage;
        Console.WriteLine("Func GetMessage: " + programCircle.GetMessage());

            //await task and thread.Sleep
            TaskDelay.SaySomething();
            Thread.Sleep(6);
            Console.WriteLine(result);

            //void delegate
            List<Printer> printers = new List<Printer>();
            int j = 0;
            for(;j<10;j++)
            {
                //printers.Add(delegate{Console.WriteLine(j);});
                                printers.Add(delegate{Console.WriteLine(new string("test"));});

            }

            foreach(var printer in printers)
            {
                printer();
            }
        }

        static long TotalAllEvenNumbers(int[] intArray) {
        return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        }

        static long TotalAllEvenNumbers_2(int[] intArray) {
        return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        }
    }
}



