using cs_encapsulation;
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

            List<Customer> bobsCustomers = new List<Customer>();
            Employee bob = new Employee("Bob", 28, 75000.0, "Full-Time", ["Task 1", "Task 2", "Task 3"], [new Customer("Customer A"), new Customer("Customer B"), new Customer("Customer C")], [new Project("Project X"), new Project("Project Y"), new Project("Project Z")], "Engineering", [Weekdays.Monday, Weekdays.Wednesday, Weekdays.Friday]);
            bob.EmployeeDetails(false);

            bob.CompleteTasks("Task 1");
            bob.AddCustomer(new Customer("Customer D"));
            bob.AddProject(new Project("Project W"));
            bob.ChangeDepartment("Human Resources");
            bob.AddMeetingDay(Weekdays.Thursday);
            bob.AdjustSalary(3000, false); 


            bob.EmployeeDetails(true);


            Employee linda = new Employee("Linda", 35, 80000.0, "Full-Time", ["Task 7", "Task 2", "Task 5"], [new Customer("Customer A"), new Customer("Customer B"), new Customer("Customer F")], [new Project("Project X")], "Finance", [Weekdays.Monday, Weekdays.Tuesday, Weekdays.Wednesday, Weekdays.Thursday]);
            linda.EmployeeDetails(false);

            linda.CompleteTasks(["Task 2", "Task 5"]);

            linda.AddCustomer([new Customer("Customer E"), new Customer("Customer T")]);

            linda.AddProject([new Project("Project W"), new Project("Project V"), new Project("Project U")]);
            linda.ChangeDepartment("Finance");
            linda.AddMeetingDay(Weekdays.Friday);
            linda.AdjustSalary(0.03, true);
            linda.EmployeeDetails(true);

            Employee sal = new Employee("Sal", 45, 23500.0, "Part-Time", ["Task 5"], [new Customer("Customer Q")], [new Project("Project A")], "Engineering", [Weekdays.Friday]);
            sal.EmployeeDetails(false);
            sal.CompleteTasks("Task 5");
            sal.AddProject(new Project("Project B"));
            sal.AddMeetingDay(Weekdays.Thursday);
            sal.AdjustSalary(-500, false);
            sal.EmployeeDetails(true);
        }
    }
}
