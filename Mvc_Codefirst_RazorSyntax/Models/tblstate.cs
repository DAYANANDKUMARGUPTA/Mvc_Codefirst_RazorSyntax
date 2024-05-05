using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Codefirst_RazorSyntax.Models
{
    public class tblstate
    {
        [Key]
        public int sid { get; set; }
        public int cid { get; set; }

        public string sname { get; set; }
    }
}