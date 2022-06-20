using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimapIntershipwork2
{
    internal class Program
    {

        int employeeId;
        String EmployeeName;
        int salary;
        //constructors
       Program()
        {
            Console.WriteLine("hello  nilesh you learn  c# and .net fremwork");
            
        } 

        public void Display()
        {
            Console.WriteLine(employeeId + " " + EmployeeName   +  " " + salary  );
        }
       // constructor overloading
        public Program(int i , string n , int s)
        {
            employeeId = i;
            EmployeeName = n;
            salary = s;
        }





        static void Main(string[] args)
        {
            //Program pro = new Program(1, "Nilesh Pathak", 1000);
            //Program pro2 = new Program(2, " kunal bhavsar", 3000);

            //pro.Display();
            //Console.ReadLine();



            string name =  "Kunal";
            int salary = 10000;
            string s = null;
            s = "";

           // string interpolation
            // s = "The sum of "  + name +  "and"  +  salary + " is" + (name+ salary);
            s = $"employee,{name} is and salary {salary} sum {name+salary} ";


            // Console.WriteLine(num3);

            // Console.WriteLine(s);
            //Console.ReadLine();

            //List 
            List<string> cars = new List<string>();
            cars.Add("Maruti");
            cars.Add("Foard");
            cars.Add("nano");

            //for (int i = 0; i < cars.Count; i++)
            //{
            //    Console.WriteLine(cars[i]);

            //}

            //Console.ReadLine();

            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //    Console.ReadLine();
            //} 


            //Lambda Expression

            //Func<int, int> squere = number => number * number; 

            //number => number * number 
            //Console.WriteLine(squere(5));
            //Console.ReadLine(); 

            const int factor = 2;

            Func<int, int> multiplure = n => n * factor;

            var result = multiplure(10);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //static int squere(int number)
        //{
        //   return number * number;
        //} 
    }


}
