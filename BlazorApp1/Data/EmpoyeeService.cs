

using BlazorApp1.Pages;

namespace BlazorApp1.Data
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService() { }
        public EmployeeService(string name) { } 

        private List<Employee> employees = new List<Employee>
        {
          new Employee
               {
                   Id = Guid.NewGuid(),
                   Name = "Employee1"

                      },
               new Employee
               {
                      Id = Guid.NewGuid(),
                      Name = "Employee2"
               }

        };

       public  List<Employee> GetEmployees()
        {
        return employees;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            var getOldEmpployee = GetEmployee(employee.Id); 
            getOldEmpployee.Name = employee.Name;

        }

        public void AddEmployee(Employee employee)
        {
            var id = Guid.NewGuid();
            employee.Id = id;
            employees.Add(employee);

        }


        public void DeleteEmployee(Guid id)
        {
            var Employee = GetEmployee(id); 
            employees.Remove(Employee);
        }

    }
}
