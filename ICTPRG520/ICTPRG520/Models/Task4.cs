using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{
    public class Task4
    {
        private double number1;
        private double number2;


        [Display(Name = "Number 1")]
        public double Number1 { get => number1; set => number1 = value; }

        [Display(Name = "Number 2")]
        public double Number2 { get => number2; set => number2 = value; }
        public double ResultPlus { get; set; }
        public double ResultMinus { get; set; }
        public double ResultMul { get; set; }
        public double ResultDiv { get; set; }
    }
}