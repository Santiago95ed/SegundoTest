namespace ICTPRG520.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }

        [StringLength(50)]
        public string EmployeeLastName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }
    }
}
