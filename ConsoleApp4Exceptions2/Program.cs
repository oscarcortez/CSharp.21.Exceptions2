using System;

namespace ConsoleApp4Exceptions2
{
    class Program
    {
        /// <summary>
        /// el manejo de excepciones sirve para manejar errores inesperados, se manejan con estos bloques:
        /// try, catch, finally, (throw)
        /// estos son los mas conocidos:
        ///     System.ArithmeticException
        ///     System.ArrayTypeMismatchException
        ///     System.DivideByZeroException
        ///     System.IndexOutOfRangeException
        ///     System.InvalidCastException
        ///     System.NullReferenceException
        ///     System.OutOfMemoryException
        ///     System.OverflowException
        ///     System.StackOverflowException
        ///     System.TypeInitializationException
        ///     
        ///     falta aprender excepciones personalizadas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un numero");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba otro numero");
                int j = int.Parse(Console.ReadLine());

                int k = i / j;
                devuelveThrow(0);
            }
            catch (OverflowException e)
            {

                Console.WriteLine("inicio mensaje overflow exception");
                Console.WriteLine(e);
                Console.WriteLine("fin mensaje overflow exception");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("inicio mensaje divide by zero exception");
                Console.WriteLine(e);
                Console.WriteLine("fin mensaje divide by zero exception");
            }
            finally
            {
                int k = 0;
                Console.WriteLine($"el resultado es: {k}");
            }

            Console.WriteLine("---------------------------------");
            int x = int.MaxValue;

            try
            {
                checked
                {
                    x++;
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("Number too big");
                return;
            }
            Console.WriteLine($"x++: {x}");
        }
        static int devuelveThrow(int x)
        {
            if (x == 0)
                throw new Exception("es un numero 0, NO VALE");
            return x;
        }
    }
}
