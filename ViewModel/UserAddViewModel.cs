using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Community.ViewModel
{
    public class UserAddViewModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "家庭住址")]
        public string Address { get; set; }
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0}长度至少{2}位，最多 {1}位.", MinimumLength = 6)]
        [Display(Name = "密码")]
        public string Password { get; set; }
        [Display(Name ="电话号码")]
        [StringLength(11, ErrorMessage = "电话号码长度为11位!", MinimumLength = 11)]
        public string PhoneNumber { get; set; }
    }
}
