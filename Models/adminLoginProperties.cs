using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RollCall.Models
{
    public class adminLoginProperties
    {
        [Required(ErrorMessage ="User Name Is Required")]
        public String userName { get; set; }
        [Required(ErrorMessage ="Password Is Required")]
        public String userPassword { get; set; }
    }
}
