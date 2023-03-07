using System;

namespace WebApp_OOPConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*************");
                Console.WriteLine("My first class");
                Console.WriteLine("*************");
                Console.WriteLine("");

                Console.WriteLine("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                var dateObject = new Date(year, month, day);
                Console.WriteLine("The date entered is:" + dateObject);


                Employe salaryEmploye = new SalaryEmploye() 
                { 
                    Id= 1,
                    FirstName="juan pablo",
                    LastName="gomez ramirez",
                    BirthDate= dateObject,
                    HiringDate= dateObject,
                    IsActive= true,
                    Salary=1160000
                };
                Console.WriteLine(salaryEmploye);
                Console.WriteLine("");

                Employe CommissionEmploye = new CommissionEmploye()
                {
                    Id = 2,
                    FirstName = "juan ",
                    LastName = "gomez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    CommissionPercentage=10,
                    Sales=20000000
                    
                };
                Console.WriteLine(CommissionEmploye);

            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

        }
    }
}
