using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Codefirst_RazorSyntax.Models
{
    public class tblcountry
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
    }
}