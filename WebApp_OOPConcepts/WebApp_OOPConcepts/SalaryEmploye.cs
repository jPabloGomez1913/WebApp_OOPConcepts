using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class SalaryEmploye : Employe
    {

        #region propierties
        public decimal Salary { get; set; }
        #endregion

        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salary...{GetValueToPay():C2}";
        }
    }
}
