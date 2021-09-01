using System;

namespace My_First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            double num01, num02;

            Console.WriteLine("press y to start a new calculation, press n to exit");
            // what is going on?
            while(Console.ReadLine() == "y" )
            {
            Console.Write("Please input a number: ");

            num01 = Convert.ToDouble (Console.ReadLine());

            Console.Write("Please input another number: ");

            num02 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("please input what method you would like:\n Multiplication(*)\n Division(/)\n Add(+)\n Subtact(-)");
        
            string method = Console.ReadLine();
            if(method == "*")
            {
                Console.WriteLine(num01 * num02);
                Console.WriteLine("'y' to carry on 'n' to exit");
            }
            if(method == "/")
            {
                Console.WriteLine(num01 / num02);
                Console.WriteLine("'y' to carry on 'n' to exit");
            }

            if(method == "+")
            {
                Console.WriteLine(num01 + num02);
            }

            if(method == "-")
            {
                Console.WriteLine(num01 - num02);
            }
            //exit
            

            }
          
        }
    }
}
