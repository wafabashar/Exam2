using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.data
{
   public interface IEmployeeService
    {

        void Insert(Employee emp);

        void delete(int id);
    }
}
