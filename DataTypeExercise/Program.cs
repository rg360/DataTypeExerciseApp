using System;

namespace DataTypeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogAge;
            string dogName;
            char y = 'A';
            bool isGoodBoy = true;
            double pi = 3.14;
            decimal purVal = 1899.43m;
            Console.WriteLine("Enter Dog's name");
            dogName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            dogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is he a good boy?");
            isGoodBoy = Convert.ToBoolean(Console.ReadLine());
            if (isGoodBoy != true) 
            {
                Console.WriteLine($"My dog's name is {dogName}. His annual food budget is ${purVal}. " +
                $"He is {dogAge} years old, is not {y} good boy, and eats a lot of \"{pi}\"");
            }
            else

            {
                Console.WriteLine($"My dog's name is {dogName}. His annual food budget is ${purVal}. " +
                $"He is {dogAge} years old, is \"{y}\" {isGoodBoy} good boy, and eats a lot of \"{pi}\"");

            }
            
        }
    }
}


/*
 * Step 1: Declare and initialize variables for the following types: 
string 
int 
char 
bool 
double
decimal 
Step 2: Concatenate these variables in a Console.Writeline();
For example:
string dogName = "Ralph";
int dogAge = 10;	
Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
*/