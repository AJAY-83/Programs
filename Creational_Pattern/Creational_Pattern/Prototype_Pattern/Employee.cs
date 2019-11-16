// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Creational_Pattern.Prototype_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Employee class have the details about the employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// PrototypeFunction as function
        /// </summary>
        public void PrototypeFunction()
        {
            try
            {
                //// create Instance of an SoftwareDeveloperclass
                SoftwareDeveloper software = new SoftwareDeveloper();
                software.EmployeeName = "Ajay";
                software.EmployeeId = "1";
                software.PreferredTechnology = "Backend";

                //// Again create Instance of an SoftwareDeveloperclass
                SoftwareDeveloper developer = (SoftwareDeveloper)software.Clone();
                developer.EmployeeId = "2";
                developer.EmployeeName = "Saurabh";
               
                Console.WriteLine(software.GetEmployeeDetails());
                Console.WriteLine(developer.GetEmployeeDetails());

                //// create Instance of an Department
                Department department = new Department();
                department.DeptName = "Testing";
                department.DId = "T-01";
                department.PreferredTechnology = "Java Testing";
                department.WordsPerMinute = 100;

                //// Again create Instance of an Department
                Department department1 = (Department)department.Clone();
                department1.DeptName = "Development";
                department1.DId = "T-02";
                department1.WordsPerMinute = 150;

                Console.WriteLine(department.GetEmployeeDetails());
                Console.WriteLine(department1.GetEmployeeDetails());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
