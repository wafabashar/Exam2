using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam2.data;

namespace Exam2.Models
{
    public class vmEmployee
    {
        public Employee employee { set; get; }

        public List<Department> liDepartment { set; get; }

        public List<Country>  licountry { set; get; }
    }
}
