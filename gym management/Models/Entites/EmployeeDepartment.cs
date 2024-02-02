﻿namespace gym_management.Models.Entites
{
    public class EmployeeDepartment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
