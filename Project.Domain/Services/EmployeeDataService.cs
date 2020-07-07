using System;
using System.Collections.Generic;
using System.Text;
using Project.Domain.Helpers;
using Project.Domain.Models;

namespace Project.Domain.Services
{
    public sealed class EmployeeDataService : BaseDataServices<Employee>
    {

        public Employee InsertCommand(Employee employee)
        {
            return InsertData(employee);
        }

        public Employee PersonalGetData(int id)
        {
            return GetDataById(id);
        }

        public List<Employee> PersonalGetDataList()
        {
            return GetData();
        }

        public Employee UpdateCommand(Employee employee)
        {
            return UpdateData(employee);
        }

        public Employee DeleteCommand(Employee employee)
        {
            return DeleteData(employee);
        }

    }
}
