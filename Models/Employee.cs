using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_POC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string EmployeeName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Department { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Email { get; set; }

    }
}
