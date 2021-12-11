using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam2.Models;
using Exam2.data;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Exam2.Controllers
{
    public class EmployeeController : Controller
    {
        IConfiguration Configuration;
        ICountryService country;
        IDepartmentService department;
        IEmployeeService employee;
      

        public EmployeeController(IConfiguration _Configuration,ICountryService _country, IDepartmentService _department, IEmployeeService _employee)
        {
            Configuration = _Configuration;
            country = _country;
            department = _department;
            employee = _employee;


        }

        public IActionResult UPload_page()
        {
            vmEmployee vm = new vmEmployee();
            vm.licountry = country.loadallcountry();
            vm.liDepartment = department.loadalldepartment();
            return View("New_Employee",vm);
        }

        public IActionResult Save(vmEmployee vm)
        {
            if (ModelState.IsValid == true)
            {
                string ImageFile = Path.Combine(Directory.GetCurrentDirectory(), Configuration["ImageFile"] + @"\", vm.employee.Image.FileName);
              //  vm.employee.Image.CopyTo(new FileStream(ImageFile, FileMode.Create));
              //  vm.employee.Path = "http://localhost/Exam2" + Configuration["ImagePath"];
                employee.Insert(vm.employee);


                vm.licountry = country.loadallcountry();
                vm.liDepartment = department.loadalldepartment();
            }
            
            return View("New_Employee", vm);
        }

        public IActionResult Delete(int id)
        {

            vmdepartment vm = new vmdepartment();
            employee.delete(id);
            vm.lidepartment = department.loadalldepartment();
            vm.liemployee = new List<Employee>();

            return View("Department", vm);
        }

        public IActionResult Details(string name)
        {
            department.search(name);
            return View("Department",vm );
        }
        



    }
}
