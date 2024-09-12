using System;

namespace trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite uma Divisão: ");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é Permitido Divisão Por Zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato Não Permitido");
            }
            finally
            {
                Console.WriteLine("Digite Novamente:");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
        }
    }
}