using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;  // Validation
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        public bool IsManager { get; set; }

        [Required]
        public int Manager { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(10)")]
        public string MobileNumber { get; set; }

        [Required]
        public string EmailId { get; set; }

        [DisplayName("Department Name")]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
       public Department Department { get; set; }
    }
}
