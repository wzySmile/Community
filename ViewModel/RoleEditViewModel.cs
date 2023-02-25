using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Community.ViewModel
{
    public class RoleEditViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name ="角色名称")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
