using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class EmployeeList
    {
        private List<Employee> list = new List<Employee>();

        public void addEmployee(Employee emp)
        {
            list.Add(emp);
        }

        public void accept(Department dp)
        {
            foreach (var item in list)
            {
                item.accept(dp);
            }
        }
    }
}
