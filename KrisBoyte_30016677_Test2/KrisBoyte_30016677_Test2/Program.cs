using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrisBoyte_30016677_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This app calculates an employee's weekly salary or weekly wages
            //Kris Boyte
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Extension
            Console.WriteLine("Welcome to the staff payroll system\n" +
                "enter 1. to display Salary\n" +
                "enter 2. to display Wages\n");
            Console.Write("Enter option: ");
            int option = int.Parse(Console.ReadLine());
            
            if(option == 1) //Salary
            {
                Salary sal01 = new Salary(); //create new Salary object
                sal01.DisplaySalary(); //call method to display weekly salary
            }
            else if (option == 2) //Wages
            {
                //get hours worked from user
                Console.WriteLine("\n\nI will calculate your wages");
                Console.Write("Enter the number of hours worked: ");
                double numHours = double.Parse(Console.ReadLine());

                Wages emp01 = new Wages(numHours); //create new Wages object with parameters
                emp01.DisplayWages(); //call method to display weekly wages
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            
            Console.ReadLine();
        }
    }
    class Salary
    {
        //variables
        private double annualSalary = 80000;
        private double weeklySalary;

        //constructor
        public Salary(){
            Console.WriteLine("\n\nYour salary is set at 80000 per year");
            
        }

        //method
        public void DisplaySalary()
        {
            weeklySalary = Math.Round((annualSalary / 52), 2); //calculate weekly salary and round to 2 decimal points
            Console.WriteLine("Youre weekly salary is: $" + weeklySalary);
        }


    }
    class Wages
    {
        //properties
        private double hourlyRate = 33.72;
        private double numHours;
        private double weeklyWages;

        //setters and getters
        public double NumHours { get { return numHours; } set { numHours = value; } }

        //constructor
        public Wages(double _numHours)
        {
            NumHours = _numHours;
        }
        //method
        public void DisplayWages()
        {
            weeklyWages = Math.Round((hourlyRate * NumHours),2); //calculate weekly wages and round to 2 decimal points
            Console.WriteLine("Your wages per week is $" + weeklyWages);
        }




    }
}
