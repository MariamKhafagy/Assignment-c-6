using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentC6
{
   
    internal class Program
    

    {
        #region Q.1
        //1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c#example.
        #region Value type
        static void Printshapes(int count, string shape = "^_^")
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(shape);
        }
        #endregion
        #region refrence type 
        static void ChangeByValue( ref int x)
        {
            int original= x;
            for (int i = 0; i < original; i++)
            {
                x++;
            }
               
        }

        #endregion
        #endregion 


        #region Q.2

        //Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c#example.
        #region value type
        static void datatype(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr?.Length; i++)
            {
                result += arr[i];
            }
             Console.WriteLine( "Sum of elements = " + result);
        }

        #endregion

        #region reference type




        static void datatype(ref int[] arr)
        {
            
            for (int i = 0; i < arr?.Length; i++)
            {

                arr[i] *= 2;
            
            }




        }

        #endregion



        #endregion


        #region Q.3 
        //3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        static void SumAndSubStarct(int x , int y ,out int sum , out int diff)
        {
            sum = x + y;
            diff = x - y;
        
        }

        #endregion


        #region Q.4
        //4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        static int SumPrimenumbers(int number)
        {
            int sum = 0;
            while (number != 0)
            { 
            
                sum += number % 10;
                number /= 10;
            
            }
            return sum;
        }
        #endregion


        #region Q.5
        //5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        static bool IsPrime(int Number)
        { 
        if(Number <= 1) 
                return false;
            for (int i = 2; i <= Math.Sqrt(Number); i++)
            {
                if (Number % i == 0) 
                return false;
            }
            return true;
        
        }
        #endregion

        #region Q.6
        //6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        static void MinMaxArray(int[] arr, out int max, out int min)
        { 
          max = arr[0];
            min = arr[0];
            foreach (int n in arr)
            { 
               
   
                if (n > max) max = n;
                if (n < min) min = n;




            }

        }
        #endregion

        #region Q.7
        //7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        static long Factorial(int nUm)
        {
            long result = 1;
            for (int i = 2; i <= nUm; i++)
            {
                result *= i;
            }
            return result;

        }
        #endregion

        #region Q.8
        //8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
        static string ChangeChar(string input, int position, char newChar)
        { 
            if(position <0 || position > input.Length) 
                return input;

          char[] chars = input.ToCharArray();
            chars[position]= newChar;
            return new string(chars);

        
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q.1
            Console.WriteLine("Q.1)");
            Printshapes(3);
            Console.WriteLine("-----------");

            int num = 3;
            Console.WriteLine("Before : " +num);
            ChangeByValue(ref num);

            Console.WriteLine("After :" +  num);
            #endregion
            Console.WriteLine("------------------------------------------------------------------------------");
            #region Q.2
            Console.WriteLine("Q.2)");
            int[] data = { 10, 20, 30 };
            datatype(data);

            Console.WriteLine("----------------");
            datatype(ref data);
            Console.WriteLine("modified array in main");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i] + " ");
            
            }

            #endregion
            Console.WriteLine("-------------------------------------------------------------------------");
            #region Q.3
            Console.WriteLine("Q.3)");

            Console.WriteLine("Enter the First Number ");
             int x =int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Secind Number");
            int y =int.Parse(Console.ReadLine()!);

            SumAndSubStarct(x, y, out int total, out int subtract);
            Console.WriteLine($"sum = {total},Subtraction = {subtract}");

            #endregion

            Console.WriteLine("----------------------------------------------------------------------------");
            #region Q.4
            Console.WriteLine("Q.4)");

            Console.WriteLine("Enter the Number :");
           
            int number = int.Parse(Console.ReadLine()!);
             int result = SumPrimenumbers(number);
            Console.WriteLine($"The Sum OF The digit of the {number} is : {result}" );

            #endregion

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            #region Q.5
            Console.WriteLine("Q.5)");

            Console.WriteLine("Enter the Number");
           int Number=int.Parse(Console.ReadLine()!);   
            Console.WriteLine(IsPrime(Number) ? "Prime " :"Not Prime");
            #endregion
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            #region Q.6
            Console.WriteLine("Q.6)");
            int[] n = { 40, 50, 60, 20, 80 };
            MinMaxArray(n, out int maxVal, out int minVal);
            Console.WriteLine($"Max = {maxVal},Min={minVal}");
            #endregion

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            
            #region Q.7
            Console.WriteLine("Q.7)");

            Console.Write("Enter the Number : ");
            int nUm=int.Parse(Console.ReadLine()!);
            long fact=Factorial(nUm);

        Console.WriteLine($"Factorial of {nUm}={fact}");


            #endregion

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            #region Q.8
            Console.WriteLine("Q.8)");
            Console.Write("Enter the String ");
            string text = Console.ReadLine()!;   

            int position=int.Parse(Console.ReadLine()!);    

            Console.Write("Enter a new Character : ");
            char ch= Console.ReadLine()![0];

            string Modified = ChangeChar(text ,position, ch);
            Console.WriteLine("Modified string : "+ Modified);


            #endregion







        }
    }
   
}