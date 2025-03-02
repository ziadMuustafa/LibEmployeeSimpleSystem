﻿using System.ComponentModel.DataAnnotations;

namespace ITI_GraduationProject.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
            = new HashSet<Employee>();
    }
}
