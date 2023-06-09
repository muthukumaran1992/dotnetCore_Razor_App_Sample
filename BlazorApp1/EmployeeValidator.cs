using BlazorApp1.Data;
using FluentValidation;


namespace BlazorApp1
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty();
            RuleFor(U => U.Id).NotNull().NotEmpty();
            
        }

    }
}
