using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_III_Dr4rum.Models
{
    public class Index
    {
        public string Group_Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}