using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc5FuLuA.Areas.LX05.Models
{
    public class UserInfo
    {
        [Required]
        [Display(Name = "用户名")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "用户名必须为3～20个字符")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "密码")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "密码必须为6～20个字符")]
        public string UserPwd { get; set; }

        [Required]
        [Display(Name = "邮箱")]
        [EmailAddress(ErrorMessage = "必须是有效的邮箱地址")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "手机号")]
        [Range(10000000000, 20000000000, ErrorMessage = "手机号必须是11位数字")]
        public long MobilePhone { get; set; }

        [Required]
        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}