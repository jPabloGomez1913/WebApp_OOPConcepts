using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    /*When you create an abstract class, put abstract before class*/
    public abstract class Employe
    {
        /*CamelCase para propierties*/
        #region Propierties
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods

        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"---EMPLOYE---\n\t" +
                $"ID...{Id}\n\t" +
                $"FirstName...{FirstName}\n\t" +
                $"LastName...{LastName}\n\t" +
                $"BirhtDate...{BirthDate}\n\t" +
                $"HiringDate...{HiringDate}\n\t" +
                $"IsActive...{IsActive}\n\t";
        }
        #endregion
    }
}
