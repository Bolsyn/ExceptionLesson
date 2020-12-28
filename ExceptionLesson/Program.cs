using System;

namespace ExceptionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new NumberProcessService();
            try
            {
                service.ModuleNumber(-16);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }


            // try
            // {
            //    service.IsNormalNumber(-12);
            // }
            // catch (ArgumentException exception)
            // {
            //    Console.WriteLine(exception.Message);
            // }


            // int.TryParse(Console.ReadLine(), out var number);
            // if (number > 10)
            // {
            //    Console.WriteLine("OK");
            // }
            // else
            // {
            //    throw new Exception("Number less 10!");
            // } 

            // var numbers = new int[] { 1, 2, 3, 4, 5 };
            //// try-catch-finally, try-catch, try-finally
            // try
            // {
            //    // numbers[5] = 12;
            //    var number = int.Parse(Console.ReadLine());
            // }
            // catch(OverflowException exception)
            // {
            //    Console.WriteLine($"Very large number, we need use {int.MaxValue}");
            // }
            // catch(Exception exception)
            // {
            //    Console.WriteLine(exception.Message);
            // }
            // finally
            // {
            //    Console.WriteLine("Program finished");
            // }
        }
    }
}
