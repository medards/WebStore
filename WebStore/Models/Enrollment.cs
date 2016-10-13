using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CategoryID{get;set;}
        public int ProductID { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}