using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class CommissionEmploye : Employe
    {

        #region propierties
        public double CommissionPercentage { get; set; }

        public decimal Sales { get; set; }
        #endregion
        #region methods
        /*The method return commisionPerventage/100
         example:5%->0.05*/
        public double HelpCommissionPercentage(double CommissionPercentage) { 
        
            return CommissionPercentage/100;
        }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)(HelpCommissionPercentage(CommissionPercentage));
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Commission Percentage...{HelpCommissionPercentage(CommissionPercentage):P2}\n\t" +
                $"Sales...................{Sales:C2}\n\t" +
                $"Get Value To Pay........{GetValueToPay():C2}";
        }
        #endregion
    }
}
