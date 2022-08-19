using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.Entities
{
    internal class IndividualPayer : TaxPayer
    {
        public IndividualPayer(string name, double anualIncome, double healthExpenditures) : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public double HealthExpenditures { get; set; }

        public override double TotalTax()
        {
            double totalTax;
            if (AnualIncome < 20000.00)
            {
                totalTax = AnualIncome * 0.15; // 15%
            }
            else
            {
                totalTax = AnualIncome * 0.25; // 25%
            }
            if (HealthExpenditures > 0.0)
                totalTax -= HealthExpenditures * 0.5; // 50%

            return totalTax;
            

        }

    }
}
