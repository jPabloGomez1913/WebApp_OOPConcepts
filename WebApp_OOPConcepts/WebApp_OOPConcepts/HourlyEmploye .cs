using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class HourlyEmploye : Employe
    {

        #region propierties
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return (decimal)Hours*HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Hours.....{Hours}\n\t"+
                $"Value per hour.....{HourValue:C2}\n\t" +
                $"Get value to pay...{GetValueToPay():C2}";
        }
    }
}
