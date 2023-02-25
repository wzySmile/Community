using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Community.ViewModel
{
    public class RoleAddViewModel
    {
        [Required]
        [Display(Name = "角色名")]
        public string RoleName { get; set; }
    }
}
