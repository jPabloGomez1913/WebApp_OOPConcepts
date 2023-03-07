using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class BaseCommissionEmploye : CommissionEmploye
    {

        #region propierties
       

        public decimal Base { get; set; }
        #endregion
        #region methods
        /*The method return commisionPerventage/100
         example:5%->0.05*/
        public double HelpCommissionPercentage(double CommissionPercentage) { 
        
            return CommissionPercentage/100;
        }
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay()+Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base......................{Base:C2}\n\t" +
                $"Total........{GetValueToPay():C2}";
        }
        #endregion
    }
}
