using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.data
{
    public class DepartmentService:IDepartmentService
    {
        Emoloyee_Context context;
        public DepartmentService(Emoloyee_Context _context)
        {
            context = _context;

        }

        public List<Department> loadalldepartment()
        {
            List<Department> lidepartment = context.Department.ToList();
            return lidepartment;
        }

       


    }
}
