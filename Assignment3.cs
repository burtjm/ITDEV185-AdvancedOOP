using System;
using System.Collections.Generic;

namespace Assignment3
{

    public class GenericsClass
	
    {
		// Generics Method 
		public void GenericMethod<T>(T a, T b)
		{	
		
			 Console.WriteLine("1st Parameter Passed {0}", a);
			 Console.WriteLine("2nd Parameter Passed {0}", b);
			 Console.ReadLine();
        }

    }

    class Program

    {

       static void Main(string[] args)

        {


            GenericsClass g = new GenericsClass();

            g.GenericMethod<int>(40, 50);

            g.GenericMethod("Desk", "Laptop");

            Console.ReadLine();

        }

    }

}
