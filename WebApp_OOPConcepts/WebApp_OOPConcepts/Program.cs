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
                Console.WriteLine("");

                Console.WriteLine("Please type the  Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your first name: ");
                String firstName = (Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your last name: ");
                String lastName = (Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type if is active ");
                Boolean isActive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type the number of hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type yhe value per hour ");
                decimal hourValue= Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("");

                Employe hourlyEmploye = new HourlyEmploye() {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = isActive,
                    Hours=hours,
                    HourValue=hourValue



                };

                Console.WriteLine(hourlyEmploye);

                Employe baseCommissionEmploye = new BaseCommissionEmploye()
                {
                    Id = 10,
                    FirstName = "valen",
                    LastName = "i dont know",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = false,
                    Sales=5200000,
                    CommissionPercentage=10,
                    Base=2000000



                };
                Console.WriteLine(baseCommissionEmploye);
                Console.WriteLine("");

                Invoice invoice = new Invoice()
                {
                    Id= 5050,
                    Description="500 de cilantro",
                    Quantity=100,
                    Price=200,
                };

                Console.WriteLine(invoice);

            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

        }
    }
}
