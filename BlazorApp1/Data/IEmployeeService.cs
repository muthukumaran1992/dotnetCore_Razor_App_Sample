using BlazorApp1.Pages;

namespace BlazorApp1.Data
{
    interface IEmployeeService
    {
       
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);
        void UpdateEmployee(Employee employee);

        void AddEmployee(Employee employee);
        void DeleteEmployee(Guid id);


    }
}
