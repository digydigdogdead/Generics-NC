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

            Employee bob = new Employee("Bob", 28, 75000.0, "Full-Time", ["Task 1", "Task 2", "Task 3"], ["Customer A", "Customer B", "Customer C"], ["Project X", "Project Y", "Project Z"], "Engineering", ["Monday", "Wednesday", "Friday"]);
            bob.EmployeeDetails(false);

            bob.CompleteTasks("Task 1");
            bob.AddCustomer("Customer D");
            bob.AddProject("Project W");
            bob.ChangeDepartment("Human Resources");
            bob.AddMeetingDay("Thursday");
            bob.AdjustSalary(3000, false); 


            bob.EmployeeDetails(true);


            Employee linda = new Employee("Linda", 35, 80000.0, "Full-Time", ["Task 7", "Task 2", "Task 5"], ["Customer A", "Customer B", "Customer F"], ["Project X"], "Finance", ["Monday", "Tuesday", "Wednesday", "Thursday"]);
            linda.EmployeeDetails(false);

            linda.CompleteTasks(["Task 2", "Task 5"]);

            linda.AddCustomer(["Customer E", "Customer T"]);

            linda.AddProject(["Project W", "Project V", "Project U"]);
            linda.ChangeDepartment("Finance");
            linda.AddMeetingDay("Friday");
            linda.AdjustSalary(0.03, true);
            linda.EmployeeDetails(true);

            Employee sal = new Employee("Sal", 45, 23500.0, "Part-Time", ["Task 5"], ["Customer Q"], ["Project A"], "Engineering", ["Friday"]);
            sal.EmployeeDetails(false);
            sal.CompleteTasks("Task 5");
            sal.AddProject("Project B");
            sal.AddMeetingDay("Thursday");
            sal.AdjustSalary(-500, false);
            sal.EmployeeDetails(true);
        }
    }
}
