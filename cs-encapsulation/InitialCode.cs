using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abs_enc_sprint.encapsulation
{
    public class InitialCode
    {
        public static void Main(string[] args)
        {
            string employeeName = "Bob";
            int employeeAge = 28;
            double employeeSalary = 75000.0;
            string employeeType = "Full-Time";
            string[] employeeTasks = new string[] { "Task 1", "Task 2", "Task 3" };
            string[] customerNames = new string[] { "Customer A", "Customer B", "Customer C" };
            string[] projects = new string[] { "Project X", "Project Y", "Project Z" };
            string department = "Engineering";
            List<string> meetingSchedule = new List<string> { "Monday", "Wednesday", "Friday" };

            Console.WriteLine("Employee Name:      " + employeeName);
            Console.WriteLine("Employee Age:       " + employeeAge);
            Console.WriteLine("Employee Salary:    £" + employeeSalary);
            Console.WriteLine("Employee Type:      " + employeeType);
            Console.WriteLine("Tasks:              " + string.Join(", ", employeeTasks));
            Console.WriteLine("Customers:          " + string.Join(", ", customerNames));
            Console.WriteLine("Projects:           " + string.Join(", ", projects));
            Console.WriteLine("Department:         " + department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", meetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");

            // Completing tasks
            for (int i = 0; i < employeeTasks.Length; i++)
            {
                if (employeeTasks[i] == "Task 1")
                {
                    employeeTasks[i] = "Completed: " + employeeTasks[i];
                    break;
                }
            }

            // Adding new customer(s)
            Array.Resize(ref customerNames, customerNames.Length + 1);
            customerNames[customerNames.Length - 1] = "Customer D";

            // Assigning new project(s)
            Array.Resize(ref projects, projects.Length + 1);
            projects[projects.Length - 1] = "Project W";

            // Changing department
            department = "Human Resources";

            // Adding meeting day(s)
            meetingSchedule.Add("Thursday");

            // Increasing salary
            employeeSalary += 3000;

            Console.WriteLine("--- UPDATED EMPLOYEE DETAILS ---");
            Console.WriteLine("Employee Name:      " + employeeName);
            Console.WriteLine("Employee Age:       " + employeeAge);
            Console.WriteLine("Employee Salary:    £" + employeeSalary);
            Console.WriteLine("Employee Type:      " + employeeType);
            Console.WriteLine("Tasks:              " + string.Join(", ", employeeTasks));
            Console.WriteLine("Customers:          " + string.Join(", ", customerNames));
            Console.WriteLine("Projects:           " + string.Join(", ", projects));
            Console.WriteLine("Department:         " + department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", meetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");

            employeeName = "Linda";
            employeeAge = 35;
            employeeSalary = 80000.0;
            employeeType = "Full-Time";
            employeeTasks = new string[] { "Task 7", "Task 2", "Task 5" };
            customerNames = new string[] { "Customer A", "Customer B", "Customer F" };
            projects = new string[] { "Project X" };
            department = "Finance";
            meetingSchedule = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday" };

            Console.WriteLine("Employee Name:      " + employeeName);
            Console.WriteLine("Employee Age:       " + employeeAge);
            Console.WriteLine("Employee Salary:    £" + employeeSalary);
            Console.WriteLine("Employee Type:      " + employeeType);
            Console.WriteLine("Tasks:              " + string.Join(", ", employeeTasks));
            Console.WriteLine("Customers:          " + string.Join(", ", customerNames));
            Console.WriteLine("Projects:           " + string.Join(", ", projects));
            Console.WriteLine("Department:         " + department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", meetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");

            // Completing tasks
            for (int i = 0; i < employeeTasks.Length; i++)
            {
                if (employeeTasks[i] == "Task 2" || employeeTasks[i] == "Task 5")
                {
                    employeeTasks[i] = "Completed: " + employeeTasks[i];
                }
            }

            // Adding new customer(s)
            Array.Resize(ref customerNames, customerNames.Length + 2);
            customerNames[customerNames.Length - 2] = "Customer E";
            customerNames[customerNames.Length - 1] = "Customer T";

            // Assigning new project(s)
            Array.Resize(ref projects, projects.Length + 3);
            projects[projects.Length - 3] = "Project W";
            projects[projects.Length - 2] = "Project V";
            projects[projects.Length - 1] = "Project U";

            // Changing department
            department = "Finance";

            // Adding meeting day(s)
            meetingSchedule.Add("Friday");

            // Increasing salary
            employeeSalary += employeeSalary * 0.03;

            Console.WriteLine("--- UPDATED EMPLOYEE DETAILS ---");
            Console.WriteLine("Employee Name:      " + employeeName);
            Console.WriteLine("Employee Age:       " + employeeAge);
            Console.WriteLine("Employee Salary:    £" + employeeSalary);
            Console.WriteLine("Employee Type:      " + employeeType);
            Console.WriteLine("Tasks:              " + string.Join(", ", employeeTasks));
            Console.WriteLine("Customers:          " + string.Join(", ", customerNames));
            Console.WriteLine("Projects:           " + string.Join(", ", projects));
            Console.WriteLine("Department:         " + department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", meetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");

            employeeName = "Sal";
            employeeAge = 45;
            employeeSalary = 23500.0;
            employeeType = "Part-Time";
            employeeTasks = new string[] { "Task 5" };
            customerNames = new string[] { "Customer Q" };
            projects = new string[] { "Project A" };
            department = "Engineering";
            meetingSchedule = new List<string> { "Friday" };

            Console.WriteLine("Employee Name:      " + employeeName);
            Console.WriteLine("Employee Age:       " + employeeAge);
            Console.WriteLine("Employee Salary:    £" + employeeSalary);
            Console.WriteLine("Employee Type:      " + employeeType);
            Console.WriteLine("Tasks:              " + string.Join(", ", employeeTasks));
            Console.WriteLine("Customers:          " + string.Join(", ", customerNames));
            Console.WriteLine("Projects:           " + string.Join(", ", projects));
            Console.WriteLine("Department:         " + department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", meetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");

            // Completing tasks
            for (int i = 0; i < employeeTasks.Length; i++)
            {
                if (employeeTasks[i] == "Task 5")
                {
                    employeeTasks[i] = "Completed: " + employeeTasks[i];
                    break;
                }
            }

            // Adding new customer(s)
            /* No new customers for Sal */

            // Assigning new project(s)
            Array.Resize(ref projects, projects.Length + 1);
            projects[projects.Length - 1] = "Project B";

            // Changing department
            /* No new department for Sal */

            // Adding meeting day(s)
            meetingSchedule.Add("Thursday");

            // Decreasing salary
            employeeSalary -= 500;

            Console.WriteLine("--- UPDATED EMPLOYEE DETAILS ---");
            Console.WriteLine("Employee Name:      " + employeeName);
            Console.WriteLine("Employee Age:       " + employeeAge);
            Console.WriteLine("Employee Salary:    £" + employeeSalary);
            Console.WriteLine("Employee Type:      " + employeeType);
            Console.WriteLine("Tasks:              " + string.Join(", ", employeeTasks));
            Console.WriteLine("Customers:          " + string.Join(", ", customerNames));
            Console.WriteLine("Projects:           " + string.Join(", ", projects));
            Console.WriteLine("Department:         " + department);
            Console.WriteLine("Meeting Schedule:   " + string.Join(", ", meetingSchedule));
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
