using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Codefirst_RazorSyntax.Models
{
    public class tblEmployee
    {
        [Key]
        public int empid { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public int salary { get; set; }
        public int country { get; set; }

        public int state { get; set; }
    }
}