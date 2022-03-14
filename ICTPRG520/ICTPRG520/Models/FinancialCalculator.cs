using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace ICTPRG520.Models
{
    public class FinancialCalculator
    {
        [Display(Name = "Principal amount")]
        public double PrincipalAmount { get; set; }
        [Display(Name = "Annual interest rate")]
        public double AnnualIntrsRate { get; set; }
        [Display(Name = "Mortage Lengh ")]
        public int years { get; set; }


    }
}