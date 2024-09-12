using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;
using System;
namespace ExcecoesPersonalizadas
// AL Exceções Personalizadas - Parte 1 a 3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut); // Cria uma reservation se for True
                Console.WriteLine("Reservation: " + reservation); // Mostra a Reserva

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva"); // Aqui atualiza a reserva com base em periodo Atual
                Console.Write("check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut); // atualiza sem mudar o numero do quarto
                Console.WriteLine("Reservation " + reservation); // mostra a reserva atualizada
            }
            catch (DomainException de) // Caso de uma exceção mostra as mensagens feitas na classe onde tem throw por causa do :base(message)
            {
                Console.WriteLine("Erro na reserva: " + de.Message);
            }
            catch (FormatException fe) // Caso haja um erro de formatação
            {
                Console.WriteLine("Erro de Formatação: " + fe.Message);
            }
            catch (Exception e) // caso haja um erro diferente que não previmos
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}