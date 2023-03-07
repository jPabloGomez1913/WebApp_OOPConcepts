﻿using System;
using System.Collections.Generic;
using System.Text;
using WebApp_OOPConcepts.Interefaces;

namespace WebApp_OOPConcepts
{
    public class Invoice : Ipay 
    {
        #region propierties
        public int Id { get; set; }
        public String Description { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Description: {Description}\n\t"+
                    $"Quantity:..............{Quantity}\n\t" +
                    $"Price:..............{Price:C2}\n\t"+
                    $"Total Invoice:..............{GetValueToPay():C2}\n\t"

                ;

        }

        #endregion
    }
}
