using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.Entities
{
    abstract public class TaxPayer
    {
        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        abstract public double TotalTax();
    }
}
