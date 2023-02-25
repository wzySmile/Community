using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Community.Models
{
    public class ApplicationUser:IdentityUser
    {
        
        [Display(Name ="姓名")]
        public string Name { get; set; }
        [MaxLength(18)]
        [Display(Name ="身份证号")]
        public string IdCard { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="出生日期")]
        public DateTime BirthDate{ get; set; }
        [Display(Name ="家庭住址")]
        public string Address { get; set; }
        
    }
}
