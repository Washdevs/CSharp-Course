using System;

namespace Execico1.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            // Corrige o cálculo somando 110% da despesa adicional
            return base.Payment() + AdditionalCharge * 1.01;
        }
    }
}
