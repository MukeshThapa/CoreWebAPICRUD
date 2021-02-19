using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public int age { get; set; }
    }
}
