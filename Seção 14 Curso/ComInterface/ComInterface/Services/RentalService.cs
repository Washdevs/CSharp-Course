using SolutionSemInterface.Entities;
using System;

namespace SolutionSemInterface.Services
{
    internal class RentalService
    {
        public double pricePerHour { get; set; }
        public double pricePerDay { get; set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void processInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment); // Use o nome correto aqui

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}