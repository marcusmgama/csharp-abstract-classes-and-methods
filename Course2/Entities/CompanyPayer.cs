using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.Entities
{
    internal class CompanyPayer : TaxPayer
    {
        public CompanyPayer(string name, double anualIncome, int employeeQuantity) : base(name, anualIncome)
        {
            EmployeeQuantity = employeeQuantity;
        }

        public int EmployeeQuantity { get; set; }

        public override double TotalTax()
        {
            double totalTax;
            if (EmployeeQuantity > 10)
            {
                totalTax = AnualIncome * 0.14; // 14%
            }
            else
            {
                totalTax = AnualIncome * 0.16; // 16%
            }

            return totalTax;
        }

    }
}
