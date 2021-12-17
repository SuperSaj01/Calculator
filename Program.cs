using System;

namespace My_First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;  
            double result;         
            while(true)
            {
            num1 = Convert.ToDouble(Console.ReadLine());

            string method = Console.ReadLine();

            if(method != "*" &&  method != "/" && method != "-" && method != "+" )
            {
                Console.WriteLine("Invalid Input Try again");
                continue;
            }

            num2 = Convert.ToDouble(Console.ReadLine());
           


            if(method == "*")
            {
                Console.Write("{0} x {1}= ", num1, num2);
                result = num1 * num2;
                Console.Write("\n" + num1 * num2);
            }
            else if(method == "/")
            {
                Console.Write("{0} ÷ {1}= ", num1, num2);
                result = num1 / num2;
                Console.Write("\n"+ num1 / num2); 
            }
            else if(method == "+")
            {
                Console.Write("{0} + {1}= ", num1, num2);
                result = num1 + num2;
                Console.Write("\n"+ num1 + num2); 
            }
            else if(method == "-")
            {
                Console.Write("{0} - {1}= ", num1, num2);
                result = num1 - num2;
                Console.Write("\n" + (num1 - num2)); 
                
            }


           
            
            }
            
        }   
    }        
}

            
            

