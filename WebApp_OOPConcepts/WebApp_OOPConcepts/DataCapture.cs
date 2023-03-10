using System;

namespace WebApp_OOPConcepts
{
    public class DataCapture
    {
        #region fields
        //employee
        int id;
        String firstName, lastName;
        Date birthDate, hiringDate;
        bool isActive = true;

        //HourlyEmployee
        float hours;
        decimal hourValue;

        //SalaryEmployee
        decimal salary;

        //CommissionEmployee
        decimal sales;
        double commissionPercentage;

        //BaseCommissionEmployee
        decimal Base;

        //Invoice
        int idInvoice;
        String description;
        double quantity;
        decimal price;
        #endregion

        #region Methods
        //Empty constructor
        public DataCapture() { }
        public void CaptureSalaryEmployee()
        {
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

            Console.WriteLine("Please type the salary ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Employe salaryEmploye = new SalaryEmploye()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = isActive,
                Salary = salary
            };
            Console.WriteLine(salaryEmploye);

        }

        public void CaptureCommisionEmployee()
        {
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

            Console.WriteLine("Please type the sales ");
            decimal sales = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Please type the commission percentage ");
            double commissionPercentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Employe commissionEmploye = new CommissionEmploye()
            {

                Id = id,
                FirstName = firstName,
                LastName = lastName,
                IsActive = isActive,
                Sales = sales,
                CommissionPercentage = commissionPercentage,
                HiringDate = dateObject,
                BirthDate = dateObject,

            };

            Console.WriteLine(commissionEmploye);
            Console.WriteLine("");

        }

        public void CaptureHourlyEmployee()
        {
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
        }

        public void CaptureBaseCommissionEmployee() {


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

            Console.WriteLine("Please type the sales ");
            decimal sales = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Please type the commission percentage ");
            double commissionPercentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("Please type the base salary ");
            decimal Base = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Employe baseCommisionEmployee = new BaseCommissionEmploye() {

                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = isActive,
                Sales = sales,
                CommissionPercentage = commissionPercentage,
                Base = Base

            };


            Console.WriteLine(baseCommisionEmployee);
            Console.WriteLine("");

        }

        public void CaptureInvoice() {

            Console.WriteLine("Please type the id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Please type the description");
            description= Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Please type the quantity");
            quantity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Please type the price");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Invoice invoice = new Invoice() {

                Id = id,
                Description = description,
                Quantity = quantity,
                Price = price
            
            };

            Console.WriteLine(invoice);
            Console.WriteLine("");

        }
        #endregion
    }
}
