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

              
                DataCapture capture = new DataCapture();
                capture.CaptureSalaryEmployee();
                Console.WriteLine("");

                

                capture.CaptureCommisionEmployee();
                Console.WriteLine("");

           

                capture.CaptureHourlyEmployee();
                Console.WriteLine("");

                /*Employe baseCommissionEmploye = new BaseCommissionEmploye()
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
                Console.WriteLine("");*/

                capture.CaptureBaseCommissionEmployee();
                Console.WriteLine("");


                capture.CaptureInvoice();
                Console.WriteLine("");

            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

        }
    }
}
