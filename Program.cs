using System;
using System.Globalization;
using System.Collections.Generic;
using Ex_Proposto_2;

namespace Course
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<TaxPayer> list = new List<TaxPayer>();

                System.Console.WriteLine("Enter the number of tax payer:");
                int N = int.Parse(Console.ReadLine());

                for(int i = 1; i <= N; i++)
                {
                    System.Console.WriteLine($"Tax payer #{i} data:");
                    System.Console.Write("Individual or company (i/c)?");
                    char C = char.Parse(Console.ReadLine());
                    System.Console.Write("Name:");
                    string name = Console.ReadLine();
                    System.Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());

                    if(C == 'i')
                    {
                        System.Console.Write("Health expenditures:");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Individual(name , anualIncome, healthExpenditures));
                    }
                    else
                    {
                        System.Console.Write("Number of employees:");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        list.Add(new Company(name, anualIncome, numberOfEmployees));
                    }
                }
                    Console.WriteLine();
                    System.Console.WriteLine("TAXES PAID: ");
                    double Sum = 0.0;
                    foreach(TaxPayer P in list)
                    {
                        Console.WriteLine(P.Name + ": $" + P.Tax().ToString("F2", CultureInfo.InvariantCulture));
                        Sum += P.Tax();
                    }
                    Console.WriteLine();
                    Console.WriteLine("TOTAL TAXES: $ " + Sum.ToString("F2", CultureInfo.InvariantCulture));

                
            }
        }
    }
