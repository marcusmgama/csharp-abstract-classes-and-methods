using System;
using System.Collections.Generic;
using System.Globalization;
using Course2.Entities;


List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company? (i/c) ");
    char answer = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(answer == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new IndividualPayer (name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employeeQuantity = int.Parse(Console.ReadLine());
        list.Add(new CompanyPayer(name, anualIncome, employeeQuantity));
    }
}
Console.WriteLine("\nTAXES PAID: ");
foreach(TaxPayer taxPayer in list)
{
    Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.TotalTax().ToString("F2", CultureInfo.InvariantCulture)}");
}