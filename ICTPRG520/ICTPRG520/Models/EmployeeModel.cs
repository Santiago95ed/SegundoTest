using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTPRG520.Models
{
    public class EmployeeModel
    {
        private int _EmployeeID;
        private string _EmployeeName;
        private string _EmployeeLastName;
        private decimal _Rate;
        private double _HoursWorked;
        private decimal _TotalWages;

        [Display(Name = "ID Employee")]
        public int EmployeeID { get => _EmployeeID; set => _EmployeeID = value; }

        [Display(Name = "Employee name")]
        public string EmployeeName { get => _EmployeeName; set => _EmployeeName = value; }

        [Display(Name = "Employee last name")]
        public string EmployeeLastName { get => _EmployeeLastName; set => _EmployeeLastName = value; }
        [Display(Name = "Employee rate")]
        public decimal Rate { get => _Rate; set => _Rate = value; }
        [Display(Name = "Hours worked")]
        public double HoursWorked { get => _HoursWorked; set => _HoursWorked = value; }
        [Display(Name = "Total earned")]
        public decimal TotalWages { get => _TotalWages; set => _TotalWages = value; }
    }
}