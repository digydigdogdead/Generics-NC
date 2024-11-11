using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cs_encapsulation
{
    internal class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public string Type { get; set; }
        public List<string> Tasks { get; set; }

        public List<string> Customers { get; set; }

        public List<string> Projects { get; set; }

        public string Department { get; set; }

        public List<string> MeetingSchedule {  get; set; }
        
        public Employee(string name, int age, double salary, string type, List<string> tasks, List<string> customers, List<string> projects, string department, List<string> meetingSchedule) 
        {
            this.Name = name; 
            this.Age = age;
            this.Salary = salary;
            this.Type = type;
            this.Tasks = tasks;
            this.Customers = customers;
            this.Projects = projects;
            this.Department = department;
            this.MeetingSchedule = meetingSchedule;
        }

        public void EmployeeDetails(bool isUpdate)
        {
            if (isUpdate)
            {
                Console.WriteLine("--- UPDATED EMPLOYEE DETAILS ---");
            }
            
            Console.WriteLine("Employee Name:      " + Name);
            Console.WriteLine("Employee Age:       " + Age);
            Console.WriteLine("Employee Salary:    £" + Salary);
            Console.WriteLine("Employee Type:      " + Type);
            Console.WriteLine("Tasks:              " + string.Join(", ", Tasks));
            Console.WriteLine("Customers:          " + string.Join(", ", Customers));
            Console.WriteLine("Projects:           " + string.Join(", ", Projects));
            Console.WriteLine("Department:         " + Department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", MeetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");
        }

        public void CompleteTasks(string TaskName)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i] == TaskName)
                {
                    Tasks[i] = "Completed: " + Tasks[i];
                }
            }
        } 


        public void AddCustomer(string NewCustomer)
        {
            Customers.Add(NewCustomer); 
        }

        public void AddProject(string NewProject) {
            Projects.Add(NewProject);        
        }


        public void ChangeDepartment(string NewDepartment)
        {
            Department = NewDepartment;
        }


        public void AddMeetingDay(string MeetingDay)
        {
            MeetingSchedule.Add(MeetingDay); 
        }

        public void AdjustSalary(double SalaryChange)
        {
            Salary += SalaryChange; 
        }


    }
}
