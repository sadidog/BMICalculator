using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main()
        {

            //declare and init variables
            float BMI = 0;
            string bmiValue = null;

            //collect the user data weight in pounds and height in inches
            Console.WriteLine("enter your current weight in pounds.");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("enter your height in inches");
            float height = float.Parse(Console.ReadLine());

            //calculate BMI
            BMI = (weight * 703) / (height * height);


            //Generate user BMI Values
            if (BMI <= 18.5f)
                bmiValue = ("you are underweight");
            else if (BMI <= 24.9f)
                bmiValue = ("you are a normal weight");
            else if (BMI <= 29.9f)
                bmiValue = ("you are overweight");
            else if (BMI >= 30)
                bmiValue = ("you are obese");

            // tell the user how fat they are.
            Console.Write($"your BMI is {BMI} ");
            Console.WriteLine($"{bmiValue}");
            Console.ReadLine();
        }
    }
}
