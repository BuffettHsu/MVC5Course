using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class MemberProfileViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public DateTime Birthday { get; set; }
    }
}