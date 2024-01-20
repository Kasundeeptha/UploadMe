// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace app
{

    class programCircle
    {

        


        public static string GetMessage() { return "Hello world"; }

    }



public sealed class Circle {
	 	private double radius = 2;

 		public double Calculate(Func<double, double> op) {
 			return op(radius);
 		}

        public  double op (double radius)
        {
        	return 2 * radius * Math.PI;
        }
	}
    
}



