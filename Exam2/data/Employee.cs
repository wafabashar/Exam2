using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Exam2.helper;

namespace Exam2.data
{
    public class Employee
    {


        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
    
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [bdValidation]
        [Column("Birth Date")]
        public DateTime BD { get; set; }

        public string Path { get; set; }

        [NotMapped]
        public IFormFile Image { set; get; }


        [ForeignKey("Department")]
        public int Department_id { get; set; }


        public Department Department { set; get; }

        [ForeignKey("Country")]
        public int Country_id { get; set; }


        public Country Country { set; get; }







    }
}
