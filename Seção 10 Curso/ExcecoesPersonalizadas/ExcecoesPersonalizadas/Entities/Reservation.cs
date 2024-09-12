using System;
using ExcecoesPersonalizadas.Entities.Exceptions;
namespace ExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {   // minhas auto properties
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                {
                    throw new DomainException("Erro na reserva: ChekOut deve ser depois do CheckIn"); // caso de erro na primeira reserva
                }
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() // Conta o tempo de duração das reservas
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString() // Este é o nosso Print
        {
            return "Room "
                + RoomNumber
                + ", check-In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn <= now || checkOut < now)
            {
                throw new DomainException("Erro na reseva: datas para atualizar devem ser futuras");
            }// Throw serve para lançar uma exceção na domain exception
            if (checkOut <= checkIn)
            {
                {
                    throw new DomainException("Erro na reserva: ChekOut deve ser depois do CheckIn");
                }
            }//throw novamente
            CheckIn = checkIn;
            CheckOut = checkOut;
            // dando true só alterara estas duas ultimas linhas
        }
    }
}