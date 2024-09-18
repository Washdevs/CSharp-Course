using SolutionSemInterface.Entities;
using System;
namespace SolutionSemInterface.Services
{
    internal class RentalService
    {
        public double pricePerHour { get; set; }
        public double pricePerDay { get; set; }

        private BrazilTaxService brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
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

            double tax = brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}