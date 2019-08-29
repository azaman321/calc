using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            double bmi;
           

            Console.WriteLine("Enter your height in metres please");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight please in kg, we dont judge");
            weight = Convert.ToDouble(Console.ReadLine());

            bmi = weight / (height * height);
            Console.WriteLine("Your bmi is:{0}", Math.Round(bmi, 4));
            

            if (bmi < 18.5)
                Console.WriteLine("Sorry buddy but you are underweight");

            else if (bmi > 18.5 && bmi < 23)
                Console.WriteLine("According to society you're healthy");

            else if (bmi > 23)
                Console.WriteLine("sorry buddy you are overweight");
            Console.ReadLine();



        }
    }
}
