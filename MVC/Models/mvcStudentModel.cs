using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class mvcStudentModel
    {
        public int StudentID { get; set; }
        [Required(ErrorMessage="This field is required")]
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}