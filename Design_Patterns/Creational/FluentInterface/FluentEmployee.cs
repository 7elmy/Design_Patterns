using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.FluentInterface
{
    public class FluentEmployee
    {
        private readonly Employee _employee;
        public FluentEmployee()
        {
            _employee = new Employee();
        }
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            _employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            _employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            _employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            _employee.Address = Address;
            return this;
        }

        public override string ToString()
        {
            return $"Name: {_employee.FullName}, Birthdate: {_employee.DateOfBirth}, Working On: {_employee.Department}, Stays At: {_employee.Address}";
        }
    }
}
