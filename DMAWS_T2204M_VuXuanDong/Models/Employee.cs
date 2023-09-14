﻿namespace DMAWS_T2204M_VuXuanDong.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public string EmployeeDepartment { get; set; }
        public virtual ICollection<Employee> Employees { get; set;}
    }
}
