using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam2.data
{
    public class Department
    {

        public int ID { get; set; }

  
        public string Name { get; set; }

     
        public double Max_Salary { get; set; }

        public double Min_Salary { get; set; }

        public List<Employee> liemployee { set; get; }
    }
}
