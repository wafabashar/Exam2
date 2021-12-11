using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.data
{
    public class EmployeeSercive:IEmployeeService
    {
        Emoloyee_Context context;
        public EmployeeSercive(Emoloyee_Context _context)
        {
            context = _context;

        }

        public void Insert(Employee emp)
        {
            context.Employee.Add(emp);
            context.SaveChanges();
        }

        public void delete(int id)
        {
          Employee emp=  context.Employee.Find(id);
            context.Employee.Remove(emp);
            context.SaveChanges();
        }

        public List<Employee> search(string name)
        {

            List<Employee> liemp = context.Employee.Where(emp => emp.Name == name).ToList();

            return liemp;
        }

    }
}
