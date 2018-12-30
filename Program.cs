using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void bank(float p, float r , float t){
            float i = p*r*t/100;
            Console.WriteLine($"The interest is {i}");
            float a = p+i;
            Console.WriteLine($"The amount is {a}");

            Console.WriteLine("Hello World!");

            Console.WriteLine($"the i is {i} and the  a is {a}");
        }
        static void Main(string[] args)
        {
            float rate ;
            Console.WriteLine("Enter  principal:");
            float principal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter time in years:");
            float time = float.Parse(Console.ReadLine());

            if(time <= 5)
                rate = 4;
            else 
                rate = 5;

            bank(principal,rate,time);
        }
    }
}
