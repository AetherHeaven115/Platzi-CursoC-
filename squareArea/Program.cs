using System;

namespace squareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //rectangle area calc.
            Console.WriteLine("Please enter the sideA of the rectangle, you can use decimals:  ");
            float sideA = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the sideB of the rectangle , you can use decimals: ");
            float sideB = float.Parse(Console.ReadLine());

            
           
            //rectangle area formula is a*b
            float area = sideA * sideB;


            Console.WriteLine("The rectangle area: " + area);


        }
    }
}
